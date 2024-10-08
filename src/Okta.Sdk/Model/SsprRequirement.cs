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
    /// Describes the initial and secondary authenticator requirements a user needs to reset their password
    /// </summary>
    [DataContract(Name = "SsprRequirement")]
    
    public partial class SsprRequirement : IEquatable<SsprRequirement>
    {
        
        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public SsprPrimaryRequirement Primary { get; set; }

        /// <summary>
        /// Gets or Sets StepUp
        /// </summary>
        [DataMember(Name = "stepUp", EmitDefaultValue = true)]
        public SsprStepUpRequirement StepUp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SsprRequirement {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  StepUp: ").Append(StepUp).Append("\n");
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
            return this.Equals(input as SsprRequirement);
        }

        /// <summary>
        /// Returns true if SsprRequirement instances are equal
        /// </summary>
        /// <param name="input">Instance of SsprRequirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SsprRequirement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && 
                (
                    this.StepUp == input.StepUp ||
                    (this.StepUp != null &&
                    this.StepUp.Equals(input.StepUp))
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
                
                if (this.Primary != null)
                {
                    hashCode = (hashCode * 59) + this.Primary.GetHashCode();
                }
                if (this.StepUp != null)
                {
                    hashCode = (hashCode * 59) + this.StepUp.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
