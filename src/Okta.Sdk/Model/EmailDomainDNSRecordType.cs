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
    /// Defines EmailDomainDNSRecordType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class EmailDomainDNSRecordType : StringEnum
    {
        /// <summary>
        /// StringEnum EmailDomainDNSRecordType for value: CNAME
        /// </summary>
        public static EmailDomainDNSRecordType CNAME = new EmailDomainDNSRecordType("CNAME");
        /// <summary>
        /// StringEnum EmailDomainDNSRecordType for value: TXT
        /// </summary>
        public static EmailDomainDNSRecordType TXT = new EmailDomainDNSRecordType("TXT");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="EmailDomainDNSRecordType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator EmailDomainDNSRecordType(string value) => new EmailDomainDNSRecordType(value);

        /// <summary>
        /// Creates a new <see cref="EmailDomainDNSRecordType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public EmailDomainDNSRecordType(string value)
            : base(value)
        {
        }
    }


}
