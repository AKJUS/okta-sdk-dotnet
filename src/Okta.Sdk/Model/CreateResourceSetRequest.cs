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
    /// CreateResourceSetRequest
    /// </summary>
    [DataContract(Name = "CreateResourceSetRequest")]
    
    public partial class CreateResourceSetRequest : IEquatable<CreateResourceSetRequest>
    {
        
        /// <summary>
        /// Description of the Resource Set
        /// </summary>
        /// <value>Description of the Resource Set</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Unique name for the Resource Set
        /// </summary>
        /// <value>Unique name for the Resource Set</value>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// The endpoint (URL) that references all resource objects included in the Resource Set. Resources are identified by either an Okta Resource Name (ORN) or by a REST URL format. See [Okta Resource Name](/openapi/okta-management/guides/roles/#okta-resource-name-orn).
        /// </summary>
        /// <value>The endpoint (URL) that references all resource objects included in the Resource Set. Resources are identified by either an Okta Resource Name (ORN) or by a REST URL format. See [Okta Resource Name](/openapi/okta-management/guides/roles/#okta-resource-name-orn).</value>
        [DataMember(Name = "resources", EmitDefaultValue = true)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateResourceSetRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as CreateResourceSetRequest);
        }

        /// <summary>
        /// Returns true if CreateResourceSetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateResourceSetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResourceSetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
