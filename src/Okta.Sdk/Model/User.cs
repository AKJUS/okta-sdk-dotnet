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
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    
    public partial class User : IEquatable<User>
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public UserStatus Status { get; set; }
        /// <summary>
        /// The target status of an in-progress asynchronous status transition. This property is only returned if the user&#39;s state is transitioning.
        /// </summary>
        /// <value>The target status of an in-progress asynchronous status transition. This property is only returned if the user&#39;s state is transitioning.</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class TransitioningToStatusEnum : StringEnum
        {
            /// <summary>
            /// StringEnum ACTIVE for value: ACTIVE
            /// </summary>
            
            public static TransitioningToStatusEnum ACTIVE = new TransitioningToStatusEnum("ACTIVE");

            /// <summary>
            /// StringEnum DEPROVISIONED for value: DEPROVISIONED
            /// </summary>
            
            public static TransitioningToStatusEnum DEPROVISIONED = new TransitioningToStatusEnum("DEPROVISIONED");

            /// <summary>
            /// StringEnum PROVISIONED for value: PROVISIONED
            /// </summary>
            
            public static TransitioningToStatusEnum PROVISIONED = new TransitioningToStatusEnum("PROVISIONED");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="TransitioningToStatusEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator TransitioningToStatusEnum(string value) => new TransitioningToStatusEnum(value);

            /// <summary>
            /// Creates a new <see cref="TransitioningToStatus"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public TransitioningToStatusEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// The target status of an in-progress asynchronous status transition. This property is only returned if the user&#39;s state is transitioning.
        /// </summary>
        /// <value>The target status of an in-progress asynchronous status transition. This property is only returned if the user&#39;s state is transitioning.</value>
        [DataMember(Name = "transitioningToStatus", EmitDefaultValue = true)]
        
        public TransitioningToStatusEnum TransitioningToStatus { get; set; }

        /// <summary>
        /// Returns false as TransitioningToStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransitioningToStatus()
        {
            return false;
        }
        
        /// <summary>
        /// The timestamp when the user status transitioned to &#x60;ACTIVE&#x60;
        /// </summary>
        /// <value>The timestamp when the user status transitioned to &#x60;ACTIVE&#x60;</value>
        [DataMember(Name = "activated", EmitDefaultValue = true)]
        public DateTimeOffset? Activated { get; private set; }

        /// <summary>
        /// Returns false as Activated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActivated()
        {
            return false;
        }
        /// <summary>
        /// The timestamp when the user was created
        /// </summary>
        /// <value>The timestamp when the user was created</value>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTimeOffset Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = true)]
        public UserCredentials Credentials { get; set; }

        /// <summary>
        /// The unique key for the user
        /// </summary>
        /// <value>The unique key for the user</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The timestamp of the last login
        /// </summary>
        /// <value>The timestamp of the last login</value>
        [DataMember(Name = "lastLogin", EmitDefaultValue = true)]
        public DateTimeOffset? LastLogin { get; private set; }

        /// <summary>
        /// Returns false as LastLogin should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastLogin()
        {
            return false;
        }
        /// <summary>
        /// The timestamp when the user was last updated
        /// </summary>
        /// <value>The timestamp when the user was last updated</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTimeOffset LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// The timestamp when the user&#39;s password was last updated
        /// </summary>
        /// <value>The timestamp when the user&#39;s password was last updated</value>
        [DataMember(Name = "passwordChanged", EmitDefaultValue = true)]
        public DateTimeOffset? PasswordChanged { get; private set; }

        /// <summary>
        /// Returns false as PasswordChanged should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePasswordChanged()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = true)]
        public UserProfile Profile { get; set; }

        /// <summary>
        /// &lt;div class&#x3D;\&quot;x-lifecycle-container\&quot;&gt;&lt;x-lifecycle class&#x3D;\&quot;ea\&quot;&gt;&lt;/x-lifecycle&gt;&lt;/div&gt;The ID of the Realm in which the user is residing
        /// </summary>
        /// <value>&lt;div class&#x3D;\&quot;x-lifecycle-container\&quot;&gt;&lt;x-lifecycle class&#x3D;\&quot;ea\&quot;&gt;&lt;/x-lifecycle&gt;&lt;/div&gt;The ID of the Realm in which the user is residing</value>
        [DataMember(Name = "realmId", EmitDefaultValue = true)]
        public string RealmId { get; private set; }

        /// <summary>
        /// Returns false as RealmId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRealmId()
        {
            return false;
        }
        /// <summary>
        /// The timestamp when the status of the user last changed
        /// </summary>
        /// <value>The timestamp when the status of the user last changed</value>
        [DataMember(Name = "statusChanged", EmitDefaultValue = true)]
        public DateTimeOffset? StatusChanged { get; private set; }

        /// <summary>
        /// Returns false as StatusChanged should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatusChanged()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public UserType Type { get; set; }

        /// <summary>
        /// If specified, includes embedded resources related to the user
        /// </summary>
        /// <value>If specified, includes embedded resources related to the user</value>
        [DataMember(Name = "_embedded", EmitDefaultValue = true)]
        public Dictionary<string, Object> Embedded { get; private set; }

        /// <summary>
        /// Returns false as Embedded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmbedded()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public UserLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Activated: ").Append(Activated).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  PasswordChanged: ").Append(PasswordChanged).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  RealmId: ").Append(RealmId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusChanged: ").Append(StatusChanged).Append("\n");
            sb.Append("  TransitioningToStatus: ").Append(TransitioningToStatus).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Activated == input.Activated ||
                    (this.Activated != null &&
                    this.Activated.Equals(input.Activated))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.PasswordChanged == input.PasswordChanged ||
                    (this.PasswordChanged != null &&
                    this.PasswordChanged.Equals(input.PasswordChanged))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.RealmId == input.RealmId ||
                    (this.RealmId != null &&
                    this.RealmId.Equals(input.RealmId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusChanged == input.StatusChanged ||
                    (this.StatusChanged != null &&
                    this.StatusChanged.Equals(input.StatusChanged))
                ) && 
                (
                    this.TransitioningToStatus == input.TransitioningToStatus ||
                    this.TransitioningToStatus.Equals(input.TransitioningToStatus)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    this.Embedded != null &&
                    input.Embedded != null &&
                    this.Embedded.SequenceEqual(input.Embedded)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                
                if (this.Activated != null)
                {
                    hashCode = (hashCode * 59) + this.Activated.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LastLogin != null)
                {
                    hashCode = (hashCode * 59) + this.LastLogin.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.PasswordChanged != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordChanged.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.RealmId != null)
                {
                    hashCode = (hashCode * 59) + this.RealmId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StatusChanged != null)
                {
                    hashCode = (hashCode * 59) + this.StatusChanged.GetHashCode();
                }
                if (this.TransitioningToStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TransitioningToStatus.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Embedded != null)
                {
                    hashCode = (hashCode * 59) + this.Embedded.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
