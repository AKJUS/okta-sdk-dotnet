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
    /// Application name for the provisioning connection
    /// </summary>
    /// <value>Application name for the provisioning connection</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class OAuthProvisioningEnabledApp : StringEnum
    {
        /// <summary>
        /// StringEnum OAuthProvisioningEnabledApp for value: google
        /// </summary>
        public static OAuthProvisioningEnabledApp Google = new OAuthProvisioningEnabledApp("google");
        /// <summary>
        /// StringEnum OAuthProvisioningEnabledApp for value: office365
        /// </summary>
        public static OAuthProvisioningEnabledApp Office365 = new OAuthProvisioningEnabledApp("office365");
        /// <summary>
        /// StringEnum OAuthProvisioningEnabledApp for value: slack
        /// </summary>
        public static OAuthProvisioningEnabledApp Slack = new OAuthProvisioningEnabledApp("slack");
        /// <summary>
        /// StringEnum OAuthProvisioningEnabledApp for value: zoomus
        /// </summary>
        public static OAuthProvisioningEnabledApp Zoomus = new OAuthProvisioningEnabledApp("zoomus");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="OAuthProvisioningEnabledApp"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator OAuthProvisioningEnabledApp(string value) => new OAuthProvisioningEnabledApp(value);

        /// <summary>
        /// Creates a new <see cref="OAuthProvisioningEnabledApp"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public OAuthProvisioningEnabledApp(string value)
            : base(value)
        {
        }
    }


}
