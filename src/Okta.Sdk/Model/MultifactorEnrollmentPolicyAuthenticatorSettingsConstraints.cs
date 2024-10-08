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
    /// MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints
    /// </summary>
    [DataContract(Name = "MultifactorEnrollmentPolicyAuthenticatorSettings_constraints")]
    
    public partial class MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints : IEquatable<MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints>
    {
        
        /// <summary>
        /// Gets or Sets AaguidGroups
        /// </summary>
        [DataMember(Name = "aaguidGroups", EmitDefaultValue = true)]
        public List<string> AaguidGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints {\n");
            sb.Append("  AaguidGroups: ").Append(AaguidGroups).Append("\n");
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
            return this.Equals(input as MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints);
        }

        /// <summary>
        /// Returns true if MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints instances are equal
        /// </summary>
        /// <param name="input">Instance of MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultifactorEnrollmentPolicyAuthenticatorSettingsConstraints input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AaguidGroups == input.AaguidGroups ||
                    this.AaguidGroups != null &&
                    input.AaguidGroups != null &&
                    this.AaguidGroups.SequenceEqual(input.AaguidGroups)
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
                
                if (this.AaguidGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AaguidGroups.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
