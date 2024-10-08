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
    /// OAuth2RefreshTokenLinksAllOfRevokeAllOfHints
    /// </summary>
    [DataContract(Name = "OAuth2RefreshToken__links_allOf_revoke_allOf_hints")]
    
    public partial class OAuth2RefreshTokenLinksAllOfRevokeAllOfHints : IEquatable<OAuth2RefreshTokenLinksAllOfRevokeAllOfHints>
    {
        /// <summary>
        /// Defines Allow
        /// </summary>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class AllowEnum : StringEnum
        {
            /// <summary>
            /// StringEnum DELETE for value: DELETE
            /// </summary>
            
            public static AllowEnum DELETE = new AllowEnum("DELETE");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="AllowEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator AllowEnum(string value) => new AllowEnum(value);

            /// <summary>
            /// Creates a new <see cref="Allow"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public AllowEnum(string value)
                : base(value)
            {
            }
        }



        /// <summary>
        /// Gets or Sets Allow
        /// </summary>
        [DataMember(Name = "allow", EmitDefaultValue = true)]
        
        public List<AllowEnum> Allow { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuth2RefreshTokenLinksAllOfRevokeAllOfHints {\n");
            sb.Append("  Allow: ").Append(Allow).Append("\n");
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
            return this.Equals(input as OAuth2RefreshTokenLinksAllOfRevokeAllOfHints);
        }

        /// <summary>
        /// Returns true if OAuth2RefreshTokenLinksAllOfRevokeAllOfHints instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuth2RefreshTokenLinksAllOfRevokeAllOfHints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2RefreshTokenLinksAllOfRevokeAllOfHints input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allow == input.Allow ||
                    this.Allow.SequenceEqual(input.Allow)
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
                
                if (this.Allow != null)
                {
                    hashCode = (hashCode * 59) + this.Allow.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
