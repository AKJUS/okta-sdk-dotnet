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
    /// This object specifies the default action Okta is set to take. Okta takes this action if your external service sends an empty HTTP 204 response. You can override the default action by returning a commands object in your response specifying the action to take.
    /// </summary>
    [DataContract(Name = "PasswordImportRequestData_action")]
    
    public partial class PasswordImportRequestDataAction : IEquatable<PasswordImportRequestDataAction>
    {
        
        /// <summary>
        /// The status of the user credential, either &#x60;UNVERIFIED&#x60; or &#x60;VERIFIED&#x60;
        /// </summary>
        /// <value>The status of the user credential, either &#x60;UNVERIFIED&#x60; or &#x60;VERIFIED&#x60;</value>
        [DataMember(Name = "credential", EmitDefaultValue = true)]
        public string Credential { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordImportRequestDataAction {\n");
            sb.Append("  Credential: ").Append(Credential).Append("\n");
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
            return this.Equals(input as PasswordImportRequestDataAction);
        }

        /// <summary>
        /// Returns true if PasswordImportRequestDataAction instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordImportRequestDataAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordImportRequestDataAction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Credential == input.Credential ||
                    (this.Credential != null &&
                    this.Credential.Equals(input.Credential))
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
                
                if (this.Credential != null)
                {
                    hashCode = (hashCode * 59) + this.Credential.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
