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
    /// TelephonyRequest
    /// </summary>
    [DataContract(Name = "TelephonyRequest")]
    
    public partial class TelephonyRequest : IEquatable<TelephonyRequest>
    {
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public TelephonyRequestData Data { get; set; }

        /// <summary>
        /// The type of inline hook. The Telephony inline hook type is &#x60;com.okta.telephony.provider&#x60;.
        /// </summary>
        /// <value>The type of inline hook. The Telephony inline hook type is &#x60;com.okta.telephony.provider&#x60;.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// The type of inline hook request. For example, &#x60;com.okta.user.telephony.pre-enrollment&#x60;.
        /// </summary>
        /// <value>The type of inline hook request. For example, &#x60;com.okta.user.telephony.pre-enrollment&#x60;.</value>
        [DataMember(Name = "requestType", EmitDefaultValue = true)]
        public string RequestType { get; set; }

        /// <summary>
        /// The ID and URL of the Telephony inline hook
        /// </summary>
        /// <value>The ID and URL of the Telephony inline hook</value>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TelephonyRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as TelephonyRequest);
        }

        /// <summary>
        /// Returns true if TelephonyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TelephonyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelephonyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.RequestType != null)
                {
                    hashCode = (hashCode * 59) + this.RequestType.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
