﻿/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 2024.07.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Okta.Sdk.Client
{
    public interface IDpopProofJwtGenerator
    {
        /// <summary>
        /// Generate a new DPoP Proof JWT
        /// </summary>
        /// <param name="nonce">The nonce</param>
        /// <param name="httpMethod">The HTTP method of the request</param>
        /// <param name="uri">The HTTP URI of the request (without query and fragment parts)</param>
        /// <param name="accessToken">The access token</param>
        /// <returns>A DPoP Proof JWT</returns>
        /// <exception cref="InvalidOperationException"></exception>
        string GenerateJwt(string? nonce = null, string? httpMethod = null, string? uri = null, string? accessToken = null);
    }

    /// <inheritdoc />
    public class DefaultDpopProofJwtGenerator : IDpopProofJwtGenerator
    {
        private readonly IReadableConfiguration _configuration;
        private readonly RSA _rsa;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public DefaultDpopProofJwtGenerator(IReadableConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException($"The Okta Configuration cannot be null.");
            _rsa = RSA.Create();
            if (configuration.PrivateKey != null)
            {
                // Get JWK from configured private key
                var privateKey = configuration.PrivateKey ??
                                 throw new ArgumentException("Private key configuration is required for DPoP");
                _rsa.ImportParameters(new RSAParameters
                {
                    Modulus = Base64UrlEncoder.DecodeBytes(privateKey.N),
                    Exponent = Base64UrlEncoder.DecodeBytes(privateKey.E),
                    D = Base64UrlEncoder.DecodeBytes(privateKey.D),
                    P = Base64UrlEncoder.DecodeBytes(privateKey.P),
                    Q = Base64UrlEncoder.DecodeBytes(privateKey.Q),
                    DP = Base64UrlEncoder.DecodeBytes(privateKey.Dp),
                    DQ = Base64UrlEncoder.DecodeBytes(privateKey.Dq),
                    InverseQ = Base64UrlEncoder.DecodeBytes(privateKey.Qi)
                });
            }
        }

        /// <summary>
        /// Generate a new DPoP Proof JWT
        /// </summary>
        /// <param name="nonce">The nonce</param>
        /// <param name="httpMethod">The HTTP method of the request</param>
        /// <param name="uri">The HTTP URI of the request (without query and fragment parts)</param>
        /// <param name="accessToken">The access token</param>
        /// <returns>A DPoP Proof JWT</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public string GenerateJwt(string? nonce = null, string? httpMethod = null,
            string? uri = null, string? accessToken = null)
        {
            try
            {
                var payload = new JwtPayload
                {
                    { "htm", httpMethod ?? "POST" },
                    { "htu", uri ?? $"{ClientUtils.EnsureTrailingSlash(_configuration.OktaDomain)}oauth2/v1/token" },
                    { "iat", DateTimeOffset.UtcNow.ToUnixTimeSeconds() },
                    { "jti", Guid.NewGuid().ToString() }
                };

                if (!string.IsNullOrEmpty(nonce))
                    payload.Add("nonce", nonce);

                if (!string.IsNullOrEmpty(accessToken))
                    if (accessToken != null)
                        payload.Add("ath", HashAccessToken(accessToken));

                // Build minimal JWK
                var publicParams = _rsa.ExportParameters(false);
                var jwkDict = new Dictionary<string, object>
                {
                    { "kty", "RSA" },
                    { "use", "sig" },
                    { "alg", SecurityAlgorithms.RsaSha256 },
                    { "e", Base64UrlEncoder.Encode(publicParams.Exponent) },
                    { "n", Base64UrlEncoder.Encode(publicParams.Modulus) }
                };

                var signingCredentials = new SigningCredentials(
                    new RsaSecurityKey(_rsa),
                    SecurityAlgorithms.RsaSha256
                );
                var header = new JwtHeader(signingCredentials);
                if (header.ContainsKey("typ"))
                {
                    header.Remove("typ");
                }
                header.Add("typ", "dpop+jwt");
                header.Add("jwk", jwkDict);

                var securityToken = new JwtSecurityToken(header, payload);
                return new JwtSecurityTokenHandler().WriteToken(securityToken);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Failed to generate DPoP proof JWT", e);
            }
        }

        /// <summary>
        /// Hash of the access token. The value MUST be the result of a base64url encoding (as defined in Section 2 of [RFC7515]) the SHA-256 [SHS] hash of the ASCII encoding of the associated access token's value.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>The hash of the access token.</returns>
        private static string HashAccessToken(string accessToken)
        {
            //Create an instance of SHA256 algorithm
            using var sha256 = SHA256.Create();

            //Compute the hash
            var hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(accessToken));

            //Perform the base64url encoding on the hash
            return Base64UrlEncoder.Encode(hash);
        }
    }
}
