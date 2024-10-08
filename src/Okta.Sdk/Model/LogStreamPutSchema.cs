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
    /// LogStreamPutSchema
    /// </summary>
    [DataContract(Name = "LogStreamPutSchema")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(LogStreamAwsPutSchema), "LogStreamAwsPutSchema")]
    [JsonSubtypes.KnownSubType(typeof(LogStreamSplunkPutSchema), "LogStreamSplunkPutSchema")]
    [JsonSubtypes.KnownSubType(typeof(LogStreamAwsPutSchema), "aws_eventbridge")]
    [JsonSubtypes.KnownSubType(typeof(LogStreamSplunkPutSchema), "splunk_cloud_logstreaming")]
    
    public partial class LogStreamPutSchema : IEquatable<LogStreamPutSchema>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        
        public LogStreamType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogStreamPutSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LogStreamPutSchema() { }
        
        /// <summary>
        /// Unique name for the Log Stream object
        /// </summary>
        /// <value>Unique name for the Log Stream object</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogStreamPutSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as LogStreamPutSchema);
        }

        /// <summary>
        /// Returns true if LogStreamPutSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of LogStreamPutSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogStreamPutSchema input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
