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
    /// EmailTemplateResponseEmbedded
    /// </summary>
    [DataContract(Name = "EmailTemplateResponse__embedded")]
    
    public partial class EmailTemplateResponseEmbedded : IEquatable<EmailTemplateResponseEmbedded>
    {
        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = true)]
        public EmailSettingsResponse Settings { get; set; }

        /// <summary>
        /// Gets or Sets CustomizationCount
        /// </summary>
        [DataMember(Name = "customizationCount", EmitDefaultValue = true)]
        public int CustomizationCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailTemplateResponseEmbedded {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  CustomizationCount: ").Append(CustomizationCount).Append("\n");
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
            return this.Equals(input as EmailTemplateResponseEmbedded);
        }

        /// <summary>
        /// Returns true if EmailTemplateResponseEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailTemplateResponseEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTemplateResponseEmbedded input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.CustomizationCount == input.CustomizationCount ||
                    this.CustomizationCount.Equals(input.CustomizationCount)
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
                
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CustomizationCount.GetHashCode();
                return hashCode;
            }
        }

    }

}