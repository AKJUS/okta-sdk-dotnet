/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
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
    /// Defines DNSRecordType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class DNSRecordType : StringEnum
    {
        /// <summary>
        /// StringEnum DNSRecordType for value: CNAME
        /// </summary>
        public static DNSRecordType CNAME = new DNSRecordType("CNAME");
        /// <summary>
        /// StringEnum DNSRecordType for value: TXT
        /// </summary>
        public static DNSRecordType TXT = new DNSRecordType("TXT");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="DNSRecordType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator DNSRecordType(string value) => new DNSRecordType(value);

        /// <summary>
        /// Creates a new <see cref="DNSRecordType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public DNSRecordType(string value)
            : base(value)
        {
        }
    }


}