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
    /// EntityRiskPolicyRuleAllOfConditions
    /// </summary>
    [DataContract(Name = "EntityRiskPolicyRule_allOf_conditions")]
    
    public partial class EntityRiskPolicyRuleAllOfConditions : IEquatable<EntityRiskPolicyRuleAllOfConditions>
    {
        
        /// <summary>
        /// Gets or Sets People
        /// </summary>
        [DataMember(Name = "people", EmitDefaultValue = true)]
        public PolicyPeopleCondition People { get; set; }

        /// <summary>
        /// Gets or Sets RiskDetectionTypes
        /// </summary>
        [DataMember(Name = "riskDetectionTypes", EmitDefaultValue = true)]
        public EntityRiskPolicyRuleAllOfConditionsRiskDetectionTypes RiskDetectionTypes { get; set; }

        /// <summary>
        /// Gets or Sets EntityRisk
        /// </summary>
        [DataMember(Name = "EntityRisk", EmitDefaultValue = true)]
        public EntityRiskPolicyRuleAllOfConditionsEntityRisk EntityRisk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityRiskPolicyRuleAllOfConditions {\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  RiskDetectionTypes: ").Append(RiskDetectionTypes).Append("\n");
            sb.Append("  EntityRisk: ").Append(EntityRisk).Append("\n");
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
            return this.Equals(input as EntityRiskPolicyRuleAllOfConditions);
        }

        /// <summary>
        /// Returns true if EntityRiskPolicyRuleAllOfConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityRiskPolicyRuleAllOfConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityRiskPolicyRuleAllOfConditions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.People == input.People ||
                    (this.People != null &&
                    this.People.Equals(input.People))
                ) && 
                (
                    this.RiskDetectionTypes == input.RiskDetectionTypes ||
                    (this.RiskDetectionTypes != null &&
                    this.RiskDetectionTypes.Equals(input.RiskDetectionTypes))
                ) && 
                (
                    this.EntityRisk == input.EntityRisk ||
                    (this.EntityRisk != null &&
                    this.EntityRisk.Equals(input.EntityRisk))
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
                
                if (this.People != null)
                {
                    hashCode = (hashCode * 59) + this.People.GetHashCode();
                }
                if (this.RiskDetectionTypes != null)
                {
                    hashCode = (hashCode * 59) + this.RiskDetectionTypes.GetHashCode();
                }
                if (this.EntityRisk != null)
                {
                    hashCode = (hashCode * 59) + this.EntityRisk.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
