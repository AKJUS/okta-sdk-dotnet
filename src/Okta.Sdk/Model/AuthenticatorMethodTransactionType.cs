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
    /// Defines AuthenticatorMethodTransactionType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class AuthenticatorMethodTransactionType : StringEnum
    {
        /// <summary>
        /// StringEnum AuthenticatorMethodTransactionType for value: CIBA
        /// </summary>
        public static AuthenticatorMethodTransactionType CIBA = new AuthenticatorMethodTransactionType("CIBA");
        /// <summary>
        /// StringEnum AuthenticatorMethodTransactionType for value: LOGIN
        /// </summary>
        public static AuthenticatorMethodTransactionType LOGIN = new AuthenticatorMethodTransactionType("LOGIN");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="AuthenticatorMethodTransactionType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator AuthenticatorMethodTransactionType(string value) => new AuthenticatorMethodTransactionType(value);

        /// <summary>
        /// Creates a new <see cref="AuthenticatorMethodTransactionType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public AuthenticatorMethodTransactionType(string value)
            : base(value)
        {
        }
    }


}
