/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 5.1.0
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
    /// AuthenticatorMethodWebAuthnAllOfSettings
    /// </summary>
    [DataContract(Name = "AuthenticatorMethodWebAuthn_allOf_settings")]
    
    public partial class AuthenticatorMethodWebAuthnAllOfSettings : IEquatable<AuthenticatorMethodWebAuthnAllOfSettings>
    {

        /// <summary>
        /// Gets or Sets UserVerification
        /// </summary>
        [DataMember(Name = "userVerification", EmitDefaultValue = true)]
        
        public UserVerificationEnum UserVerification { get; set; }

        /// <summary>
        /// Gets or Sets Attachment
        /// </summary>
        [DataMember(Name = "attachment", EmitDefaultValue = true)]
        
        public WebAuthnAttachment Attachment { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticatorMethodWebAuthnAllOfSettings {\n");
            sb.Append("  UserVerification: ").Append(UserVerification).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
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
            return this.Equals(input as AuthenticatorMethodWebAuthnAllOfSettings);
        }

        /// <summary>
        /// Returns true if AuthenticatorMethodWebAuthnAllOfSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticatorMethodWebAuthnAllOfSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatorMethodWebAuthnAllOfSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserVerification == input.UserVerification ||
                    this.UserVerification.Equals(input.UserVerification)
                ) && 
                (
                    this.Attachment == input.Attachment ||
                    this.Attachment.Equals(input.Attachment)
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
                
                if (this.UserVerification != null)
                {
                    hashCode = (hashCode * 59) + this.UserVerification.GetHashCode();
                }
                if (this.Attachment != null)
                {
                    hashCode = (hashCode * 59) + this.Attachment.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}