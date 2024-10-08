/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 2024.07.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// Credential request object for the initialized credential, along with the enrollment and key identifiers to associate with the credential
    /// </summary>
    [DataContract(Name = "WebAuthnCredRequest")]
    
    public partial class WebAuthnCredRequest : IEquatable<WebAuthnCredRequest>
    {
        
        /// <summary>
        /// ID for a WebAuthn Preregistration Factor in Okta
        /// </summary>
        /// <value>ID for a WebAuthn Preregistration Factor in Okta</value>
        [DataMember(Name = "authenticatorEnrollmentId", EmitDefaultValue = true)]
        public string AuthenticatorEnrollmentId { get; set; }

        /// <summary>
        /// Encrypted JWE of credential request for the fulfillment provider
        /// </summary>
        /// <value>Encrypted JWE of credential request for the fulfillment provider</value>
        [DataMember(Name = "credRequestJwe", EmitDefaultValue = true)]
        public string CredRequestJwe { get; set; }

        /// <summary>
        /// ID for the Okta response key-pair used to encrypt and decrypt credential requests and responses
        /// </summary>
        /// <value>ID for the Okta response key-pair used to encrypt and decrypt credential requests and responses</value>
        [DataMember(Name = "keyId", EmitDefaultValue = true)]
        public string KeyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebAuthnCredRequest {\n");
            sb.Append("  AuthenticatorEnrollmentId: ").Append(AuthenticatorEnrollmentId).Append("\n");
            sb.Append("  CredRequestJwe: ").Append(CredRequestJwe).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebAuthnCredRequest);
        }

        /// <summary>
        /// Returns true if WebAuthnCredRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebAuthnCredRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebAuthnCredRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticatorEnrollmentId == input.AuthenticatorEnrollmentId ||
                    (this.AuthenticatorEnrollmentId != null &&
                    this.AuthenticatorEnrollmentId.Equals(input.AuthenticatorEnrollmentId))
                ) && 
                (
                    this.CredRequestJwe == input.CredRequestJwe ||
                    (this.CredRequestJwe != null &&
                    this.CredRequestJwe.Equals(input.CredRequestJwe))
                ) && 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                
                if (this.AuthenticatorEnrollmentId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticatorEnrollmentId.GetHashCode();
                }
                if (this.CredRequestJwe != null)
                {
                    hashCode = (hashCode * 59) + this.CredRequestJwe.GetHashCode();
                }
                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
