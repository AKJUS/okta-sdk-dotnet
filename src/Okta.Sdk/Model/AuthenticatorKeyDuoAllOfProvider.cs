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
    /// AuthenticatorKeyDuoAllOfProvider
    /// </summary>
    [DataContract(Name = "AuthenticatorKeyDuo_allOf_provider")]
    
    public partial class AuthenticatorKeyDuoAllOfProvider : IEquatable<AuthenticatorKeyDuoAllOfProvider>
    {
        /// <summary>
        /// Provider type
        /// </summary>
        /// <value>Provider type</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class TypeEnum : StringEnum
        {
            /// <summary>
            /// StringEnum DUO for value: DUO
            /// </summary>
            
            public static TypeEnum DUO = new TypeEnum("DUO");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator TypeEnum(string value) => new TypeEnum(value);

            /// <summary>
            /// Creates a new <see cref="Type"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public TypeEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// Provider type
        /// </summary>
        /// <value>Provider type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        
        public TypeEnum Type { get; set; }
        
        /// <summary>
        /// Gets or Sets _Configuration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = true)]
        public AuthenticatorKeyDuoAllOfProviderConfiguration _Configuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticatorKeyDuoAllOfProvider {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Configuration: ").Append(_Configuration).Append("\n");
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
            return this.Equals(input as AuthenticatorKeyDuoAllOfProvider);
        }

        /// <summary>
        /// Returns true if AuthenticatorKeyDuoAllOfProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticatorKeyDuoAllOfProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatorKeyDuoAllOfProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this._Configuration == input._Configuration ||
                    (this._Configuration != null &&
                    this._Configuration.Equals(input._Configuration))
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
                
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this._Configuration != null)
                {
                    hashCode = (hashCode * 59) + this._Configuration.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
