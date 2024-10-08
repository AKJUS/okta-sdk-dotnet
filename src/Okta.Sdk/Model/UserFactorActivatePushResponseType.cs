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
    /// Defines UserFactorActivatePushResponseType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class UserFactorActivatePushResponseType : StringEnum
    {
        /// <summary>
        /// StringEnum UserFactorActivatePushResponseType for value: CANCELLED
        /// </summary>
        public static UserFactorActivatePushResponseType CANCELLED = new UserFactorActivatePushResponseType("CANCELLED");
        /// <summary>
        /// StringEnum UserFactorActivatePushResponseType for value: ERROR
        /// </summary>
        public static UserFactorActivatePushResponseType ERROR = new UserFactorActivatePushResponseType("ERROR");
        /// <summary>
        /// StringEnum UserFactorActivatePushResponseType for value: TIMEOUT
        /// </summary>
        public static UserFactorActivatePushResponseType TIMEOUT = new UserFactorActivatePushResponseType("TIMEOUT");
        /// <summary>
        /// StringEnum UserFactorActivatePushResponseType for value: WAITING
        /// </summary>
        public static UserFactorActivatePushResponseType WAITING = new UserFactorActivatePushResponseType("WAITING");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="UserFactorActivatePushResponseType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator UserFactorActivatePushResponseType(string value) => new UserFactorActivatePushResponseType(value);

        /// <summary>
        /// Creates a new <see cref="UserFactorActivatePushResponseType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public UserFactorActivatePushResponseType(string value)
            : base(value)
        {
        }
    }


}
