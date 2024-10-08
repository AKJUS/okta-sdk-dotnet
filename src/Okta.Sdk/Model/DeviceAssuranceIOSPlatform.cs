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
using JsonSubTypes;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// DeviceAssuranceIOSPlatform
    /// </summary>
    [DataContract(Name = "DeviceAssuranceIOSPlatform")]
    [JsonConverter(typeof(JsonSubtypes), "Platform")]
    [JsonSubtypes.KnownSubType(typeof(DeviceAssuranceAndroidPlatform), "ANDROID")]
    [JsonSubtypes.KnownSubType(typeof(DeviceAssuranceChromeOSPlatform), "CHROMEOS")]
    [JsonSubtypes.KnownSubType(typeof(DeviceAssuranceIOSPlatform), "IOS")]
    [JsonSubtypes.KnownSubType(typeof(DeviceAssuranceMacOSPlatform), "MACOS")]
    [JsonSubtypes.KnownSubType(typeof(DeviceAssuranceWindowsPlatform), "WINDOWS")]
    
    public partial class DeviceAssuranceIOSPlatform : DeviceAssurance, IEquatable<DeviceAssuranceIOSPlatform>
    {
        
        /// <summary>
        /// Gets or Sets Jailbreak
        /// </summary>
        [DataMember(Name = "jailbreak", EmitDefaultValue = true)]
        public bool Jailbreak { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = true)]
        public OSVersion OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets ScreenLockType
        /// </summary>
        [DataMember(Name = "screenLockType", EmitDefaultValue = true)]
        public DeviceAssuranceAndroidPlatformAllOfScreenLockType ScreenLockType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceAssuranceIOSPlatform {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Jailbreak: ").Append(Jailbreak).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  ScreenLockType: ").Append(ScreenLockType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DeviceAssuranceIOSPlatform);
        }

        /// <summary>
        /// Returns true if DeviceAssuranceIOSPlatform instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceAssuranceIOSPlatform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceAssuranceIOSPlatform input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Jailbreak == input.Jailbreak ||
                    this.Jailbreak.Equals(input.Jailbreak)
                ) && base.Equals(input) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && base.Equals(input) && 
                (
                    this.ScreenLockType == input.ScreenLockType ||
                    (this.ScreenLockType != null &&
                    this.ScreenLockType.Equals(input.ScreenLockType))
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
                int hashCode = base.GetHashCode();
                
                hashCode = (hashCode * 59) + this.Jailbreak.GetHashCode();
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                if (this.ScreenLockType != null)
                {
                    hashCode = (hashCode * 59) + this.ScreenLockType.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
