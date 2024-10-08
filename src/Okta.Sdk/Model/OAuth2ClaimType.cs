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
    /// Specifies whether the Claim is for an access token (&#x60;RESOURCE&#x60;) or an ID token (&#x60;IDENTITY&#x60;)
    /// </summary>
    /// <value>Specifies whether the Claim is for an access token (&#x60;RESOURCE&#x60;) or an ID token (&#x60;IDENTITY&#x60;)</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class OAuth2ClaimType : StringEnum
    {
        /// <summary>
        /// StringEnum OAuth2ClaimType for value: IDENTITY
        /// </summary>
        public static OAuth2ClaimType IDENTITY = new OAuth2ClaimType("IDENTITY");
        /// <summary>
        /// StringEnum OAuth2ClaimType for value: RESOURCE
        /// </summary>
        public static OAuth2ClaimType RESOURCE = new OAuth2ClaimType("RESOURCE");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="OAuth2ClaimType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator OAuth2ClaimType(string value) => new OAuth2ClaimType(value);

        /// <summary>
        /// Creates a new <see cref="OAuth2ClaimType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public OAuth2ClaimType(string value)
            : base(value)
        {
        }
    }


}
