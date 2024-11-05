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
    /// The third-party admin setting
    /// </summary>
    [DataContract(Name = "ThirdPartyAdminSetting")]
    
    public partial class ThirdPartyAdminSetting : IEquatable<ThirdPartyAdminSetting>
    {
        
        /// <summary>
        /// Gets or Sets ThirdPartyAdmin
        /// </summary>
        [DataMember(Name = "thirdPartyAdmin", EmitDefaultValue = true)]
        public bool ThirdPartyAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThirdPartyAdminSetting {\n");
            sb.Append("  ThirdPartyAdmin: ").Append(ThirdPartyAdmin).Append("\n");
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
            return this.Equals(input as ThirdPartyAdminSetting);
        }

        /// <summary>
        /// Returns true if ThirdPartyAdminSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ThirdPartyAdminSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThirdPartyAdminSetting input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ThirdPartyAdmin == input.ThirdPartyAdmin ||
                    this.ThirdPartyAdmin.Equals(input.ThirdPartyAdmin)
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
                
                hashCode = (hashCode * 59) + this.ThirdPartyAdmin.GetHashCode();
                return hashCode;
            }
        }

    }

}