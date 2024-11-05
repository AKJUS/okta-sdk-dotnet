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
    /// Defines ProvisioningConnectionRequestAuthScheme
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class ProvisioningConnectionRequestAuthScheme : StringEnum
    {
        /// <summary>
        /// StringEnum ProvisioningConnectionRequestAuthScheme for value: OAUTH2
        /// </summary>
        public static ProvisioningConnectionRequestAuthScheme OAUTH2 = new ProvisioningConnectionRequestAuthScheme("OAUTH2");
        /// <summary>
        /// StringEnum ProvisioningConnectionRequestAuthScheme for value: TOKEN
        /// </summary>
        public static ProvisioningConnectionRequestAuthScheme TOKEN = new ProvisioningConnectionRequestAuthScheme("TOKEN");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="ProvisioningConnectionRequestAuthScheme"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator ProvisioningConnectionRequestAuthScheme(string value) => new ProvisioningConnectionRequestAuthScheme(value);

        /// <summary>
        /// Creates a new <see cref="ProvisioningConnectionRequestAuthScheme"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public ProvisioningConnectionRequestAuthScheme(string value)
            : base(value)
        {
        }
    }


}