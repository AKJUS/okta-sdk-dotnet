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
    /// Contains the necessary properties for a dynamic Windows version requirement
    /// </summary>
    [DataContract(Name = "OSVersionConstraint_dynamicVersionRequirement")]
    
    public partial class OSVersionConstraintDynamicVersionRequirement : IEquatable<OSVersionConstraintDynamicVersionRequirement>
    {
        /// <summary>
        /// Indicates the type of the dynamic Windows version requirement
        /// </summary>
        /// <value>Indicates the type of the dynamic Windows version requirement</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class TypeEnum : StringEnum
        {
            /// <summary>
            /// StringEnum MINIMUM for value: MINIMUM
            /// </summary>
            
            public static TypeEnum MINIMUM = new TypeEnum("MINIMUM");

            /// <summary>
            /// StringEnum EXACT for value: EXACT
            /// </summary>
            
            public static TypeEnum EXACT = new TypeEnum("EXACT");

            /// <summary>
            /// StringEnum EXACTANYSUPPORTED for value: EXACT_ANY_SUPPORTED
            /// </summary>
            
            public static TypeEnum EXACTANYSUPPORTED = new TypeEnum("EXACT_ANY_SUPPORTED");

            /// <summary>
            /// StringEnum NOTALLOWED for value: NOT_ALLOWED
            /// </summary>
            
            public static TypeEnum NOTALLOWED = new TypeEnum("NOT_ALLOWED");


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
        /// Indicates the type of the dynamic Windows version requirement
        /// </summary>
        /// <value>Indicates the type of the dynamic Windows version requirement</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        
        public TypeEnum Type { get; set; }
        
        /// <summary>
        /// Indicates the distance from the latest Windows major version
        /// </summary>
        /// <value>Indicates the distance from the latest Windows major version</value>
        [DataMember(Name = "distanceFromLatestMajor", EmitDefaultValue = true)]
        public int DistanceFromLatestMajor { get; set; }

        /// <summary>
        /// Indicates whether the policy requires Windows devices to be on the latest security patch
        /// </summary>
        /// <value>Indicates whether the policy requires Windows devices to be on the latest security patch</value>
        [DataMember(Name = "latestSecurityPatch", EmitDefaultValue = true)]
        public bool LatestSecurityPatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSVersionConstraintDynamicVersionRequirement {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DistanceFromLatestMajor: ").Append(DistanceFromLatestMajor).Append("\n");
            sb.Append("  LatestSecurityPatch: ").Append(LatestSecurityPatch).Append("\n");
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
            return this.Equals(input as OSVersionConstraintDynamicVersionRequirement);
        }

        /// <summary>
        /// Returns true if OSVersionConstraintDynamicVersionRequirement instances are equal
        /// </summary>
        /// <param name="input">Instance of OSVersionConstraintDynamicVersionRequirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OSVersionConstraintDynamicVersionRequirement input)
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
                    this.DistanceFromLatestMajor == input.DistanceFromLatestMajor ||
                    this.DistanceFromLatestMajor.Equals(input.DistanceFromLatestMajor)
                ) && 
                (
                    this.LatestSecurityPatch == input.LatestSecurityPatch ||
                    this.LatestSecurityPatch.Equals(input.LatestSecurityPatch)
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
                hashCode = (hashCode * 59) + this.DistanceFromLatestMajor.GetHashCode();
                hashCode = (hashCode * 59) + this.LatestSecurityPatch.GetHashCode();
                return hashCode;
            }
        }

    }

}