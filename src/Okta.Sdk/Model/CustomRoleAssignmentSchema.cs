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
    /// CustomRoleAssignmentSchema
    /// </summary>
    [DataContract(Name = "CustomRoleAssignmentSchema")]
    
    public partial class CustomRoleAssignmentSchema : IEquatable<CustomRoleAssignmentSchema>
    {
        /// <summary>
        /// Standard role type
        /// </summary>
        /// <value>Standard role type</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class TypeEnum : StringEnum
        {
            /// <summary>
            /// StringEnum CUSTOM for value: CUSTOM
            /// </summary>
            
            public static TypeEnum CUSTOM = new TypeEnum("CUSTOM");


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
        /// Standard role type
        /// </summary>
        /// <value>Standard role type</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        
        public TypeEnum Type { get; set; }
        
        /// <summary>
        /// Resource Set ID
        /// </summary>
        /// <value>Resource Set ID</value>
        [DataMember(Name = "resource-set", EmitDefaultValue = true)]
        public string ResourceSet { get; set; }

        /// <summary>
        /// Custom Role ID
        /// </summary>
        /// <value>Custom Role ID</value>
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomRoleAssignmentSchema {\n");
            sb.Append("  ResourceSet: ").Append(ResourceSet).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as CustomRoleAssignmentSchema);
        }

        /// <summary>
        /// Returns true if CustomRoleAssignmentSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomRoleAssignmentSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomRoleAssignmentSchema input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResourceSet == input.ResourceSet ||
                    (this.ResourceSet != null &&
                    this.ResourceSet.Equals(input.ResourceSet))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                
                if (this.ResourceSet != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceSet.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
