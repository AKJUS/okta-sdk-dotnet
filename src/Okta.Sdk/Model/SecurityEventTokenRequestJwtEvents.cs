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
    /// A non-empty collection of events
    /// </summary>
    [DataContract(Name = "SecurityEventTokenRequestJwtEvents")]
    
    public partial class SecurityEventTokenRequestJwtEvents : IEquatable<SecurityEventTokenRequestJwtEvents>
    {
        
        /// <summary>
        /// Gets or Sets HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange
        /// </summary>
        [DataMember(Name = "https://schemas.okta.com/secevent/okta/event-type/device-risk-change", EmitDefaultValue = true)]
        public OktaDeviceRiskChangeEvent HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange { get; set; }

        /// <summary>
        /// Gets or Sets HttpsSchemasOktaComSeceventOktaEventTypeIpChange
        /// </summary>
        [DataMember(Name = "https://schemas.okta.com/secevent/okta/event-type/ip-change", EmitDefaultValue = true)]
        public OktaIpChangeEvent HttpsSchemasOktaComSeceventOktaEventTypeIpChange { get; set; }

        /// <summary>
        /// Gets or Sets HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange
        /// </summary>
        [DataMember(Name = "https://schemas.okta.com/secevent/okta/event-type/user-risk-change", EmitDefaultValue = true)]
        public OktaUserRiskChangeEvent HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange { get; set; }

        /// <summary>
        /// Gets or Sets HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange
        /// </summary>
        [DataMember(Name = "https://schemas.openid.net/secevent/caep/event-type/device-compliance-change", EmitDefaultValue = true)]
        public CaepDeviceComplianceChangeEvent HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange { get; set; }

        /// <summary>
        /// Gets or Sets HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked
        /// </summary>
        [DataMember(Name = "https://schemas.openid.net/secevent/caep/event-type/session-revoked", EmitDefaultValue = true)]
        public CaepSessionRevokedEvent HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked { get; set; }

        /// <summary>
        /// Gets or Sets HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged
        /// </summary>
        [DataMember(Name = "https://schemas.openid.net/secevent/risc/event-type/identifier-changed", EmitDefaultValue = true)]
        public RiscIdentifierChangedEvent HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityEventTokenRequestJwtEvents {\n");
            sb.Append("  HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange: ").Append(HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange).Append("\n");
            sb.Append("  HttpsSchemasOktaComSeceventOktaEventTypeIpChange: ").Append(HttpsSchemasOktaComSeceventOktaEventTypeIpChange).Append("\n");
            sb.Append("  HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange: ").Append(HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange).Append("\n");
            sb.Append("  HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange: ").Append(HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange).Append("\n");
            sb.Append("  HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked: ").Append(HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked).Append("\n");
            sb.Append("  HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged: ").Append(HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged).Append("\n");
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
            return this.Equals(input as SecurityEventTokenRequestJwtEvents);
        }

        /// <summary>
        /// Returns true if SecurityEventTokenRequestJwtEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityEventTokenRequestJwtEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityEventTokenRequestJwtEvents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange == input.HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange ||
                    (this.HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange != null &&
                    this.HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange.Equals(input.HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange))
                ) && 
                (
                    this.HttpsSchemasOktaComSeceventOktaEventTypeIpChange == input.HttpsSchemasOktaComSeceventOktaEventTypeIpChange ||
                    (this.HttpsSchemasOktaComSeceventOktaEventTypeIpChange != null &&
                    this.HttpsSchemasOktaComSeceventOktaEventTypeIpChange.Equals(input.HttpsSchemasOktaComSeceventOktaEventTypeIpChange))
                ) && 
                (
                    this.HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange == input.HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange ||
                    (this.HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange != null &&
                    this.HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange.Equals(input.HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange))
                ) && 
                (
                    this.HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange == input.HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange ||
                    (this.HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange != null &&
                    this.HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange.Equals(input.HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange))
                ) && 
                (
                    this.HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked == input.HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked ||
                    (this.HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked != null &&
                    this.HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked.Equals(input.HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked))
                ) && 
                (
                    this.HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged == input.HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged ||
                    (this.HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged != null &&
                    this.HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged.Equals(input.HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged))
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
                
                if (this.HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsSchemasOktaComSeceventOktaEventTypeDeviceRiskChange.GetHashCode();
                }
                if (this.HttpsSchemasOktaComSeceventOktaEventTypeIpChange != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsSchemasOktaComSeceventOktaEventTypeIpChange.GetHashCode();
                }
                if (this.HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsSchemasOktaComSeceventOktaEventTypeUserRiskChange.GetHashCode();
                }
                if (this.HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsSchemasOpenidNetSeceventCaepEventTypeDeviceComplianceChange.GetHashCode();
                }
                if (this.HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsSchemasOpenidNetSeceventCaepEventTypeSessionRevoked.GetHashCode();
                }
                if (this.HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsSchemasOpenidNetSeceventRiscEventTypeIdentifierChanged.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}