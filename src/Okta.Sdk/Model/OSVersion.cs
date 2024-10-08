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
    /// Specifies the OS requirement for the policy.  There are two types of OS requirements:  * **Static**: A specific OS version requirement that doesn&#39;t change until you update the policy. A static OS requirement is specified with the &#x60;osVersion.minimum&#x60; property. * **Dynamic**: An OS version requirement that is relative to the latest major OS release and security patch. A dynamic OS requirement is specified with the &#x60;osVersion.dynamicVersionRequirement&#x60; property. &gt; **Note:** Dynamic OS requirements are available only if the **Dynamic OS version compliance** [self-service EA](/openapi/okta-management/guides/release-lifecycle/#early-access-ea) feature is enabled. You can&#39;t specify both &#x60;osVersion.minimum&#x60; and &#x60;osVersion.dynamicVersionRequirement&#x60; properties at the same time. 
    /// </summary>
    [DataContract(Name = "OSVersion")]
    
    public partial class OSVersion : IEquatable<OSVersion>
    {
        
        /// <summary>
        /// Gets or Sets DynamicVersionRequirement
        /// </summary>
        [DataMember(Name = "dynamicVersionRequirement", EmitDefaultValue = true)]
        public OSVersionDynamicVersionRequirement DynamicVersionRequirement { get; set; }

        /// <summary>
        /// The device version must be equal to or newer than the specified version string (maximum of three components for iOS and macOS, and maximum of four components for Android)
        /// </summary>
        /// <value>The device version must be equal to or newer than the specified version string (maximum of three components for iOS and macOS, and maximum of four components for Android)</value>
        [DataMember(Name = "minimum", EmitDefaultValue = true)]
        public string Minimum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSVersion {\n");
            sb.Append("  DynamicVersionRequirement: ").Append(DynamicVersionRequirement).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
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
            return this.Equals(input as OSVersion);
        }

        /// <summary>
        /// Returns true if OSVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of OSVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OSVersion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DynamicVersionRequirement == input.DynamicVersionRequirement ||
                    (this.DynamicVersionRequirement != null &&
                    this.DynamicVersionRequirement.Equals(input.DynamicVersionRequirement))
                ) && 
                (
                    this.Minimum == input.Minimum ||
                    (this.Minimum != null &&
                    this.Minimum.Equals(input.Minimum))
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
                
                if (this.DynamicVersionRequirement != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicVersionRequirement.GetHashCode();
                }
                if (this.Minimum != null)
                {
                    hashCode = (hashCode * 59) + this.Minimum.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
