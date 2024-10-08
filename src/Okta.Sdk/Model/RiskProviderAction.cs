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
    /// Action taken by Okta during authentication attempts based on the risk events sent by this provider
    /// </summary>
    /// <value>Action taken by Okta during authentication attempts based on the risk events sent by this provider</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class RiskProviderAction : StringEnum
    {
        /// <summary>
        /// StringEnum RiskProviderAction for value: enforce_and_log
        /// </summary>
        public static RiskProviderAction EnforceAndLog = new RiskProviderAction("enforce_and_log");
        /// <summary>
        /// StringEnum RiskProviderAction for value: log_only
        /// </summary>
        public static RiskProviderAction LogOnly = new RiskProviderAction("log_only");
        /// <summary>
        /// StringEnum RiskProviderAction for value: none
        /// </summary>
        public static RiskProviderAction None = new RiskProviderAction("none");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="RiskProviderAction"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator RiskProviderAction(string value) => new RiskProviderAction(value);

        /// <summary>
        /// Creates a new <see cref="RiskProviderAction"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public RiskProviderAction(string value)
            : base(value)
        {
        }
    }


}
