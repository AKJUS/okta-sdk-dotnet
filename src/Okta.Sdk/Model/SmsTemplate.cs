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
    /// SmsTemplate
    /// </summary>
    [DataContract(Name = "SmsTemplate")]
    
    public partial class SmsTemplate : IEquatable<SmsTemplate>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        
        public SmsTemplateType Type { get; set; }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTimeOffset Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTimeOffset LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// Human-readable name of the Template
        /// </summary>
        /// <value>Human-readable name of the Template</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Text of the Template, including any [macros](https://developer.okta.com/docs/api/openapi/okta-management/management/tag/Template/)
        /// </summary>
        /// <value>Text of the Template, including any [macros](https://developer.okta.com/docs/api/openapi/okta-management/management/tag/Template/)</value>
        [DataMember(Name = "template", EmitDefaultValue = true)]
        public string Template { get; set; }

        /// <summary>
        /// - Template translations are optionally provided when you want to localize the SMS messages. Translations are provided as an object that contains &#x60;key:value&#x60; pairs: the language and the translated Template text. The key portion is a two-letter country code that conforms to [ISO 639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php). The value is the translated SMS Template. - Just like with regular SMS Templates, the length of the SMS message can&#39;t exceed 160 characters. 
        /// </summary>
        /// <value>- Template translations are optionally provided when you want to localize the SMS messages. Translations are provided as an object that contains &#x60;key:value&#x60; pairs: the language and the translated Template text. The key portion is a two-letter country code that conforms to [ISO 639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php). The value is the translated SMS Template. - Just like with regular SMS Templates, the length of the SMS message can&#39;t exceed 160 characters. </value>
        [DataMember(Name = "translations", EmitDefaultValue = true)]
        public Object Translations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmsTemplate {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SmsTemplate);
        }

        /// <summary>
        /// Returns true if SmsTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Translations == input.Translations ||
                    (this.Translations != null &&
                    this.Translations.Equals(input.Translations))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this.Translations != null)
                {
                    hashCode = (hashCode * 59) + this.Translations.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
