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
    /// An IP service offered by a provider, such as a proxy or VPN
    /// </summary>
    /// <value>An IP service offered by a provider, such as a proxy or VPN</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class IPServiceCategory : StringEnum
    {
        /// <summary>
        /// StringEnum IPServiceCategory for value: ALL_ANONYMIZERS
        /// </summary>
        public static IPServiceCategory ALLANONYMIZERS = new IPServiceCategory("ALL_ANONYMIZERS");
        /// <summary>
        /// StringEnum IPServiceCategory for value: ALL_ANONYMIZERS_EXCEPT_TOR
        /// </summary>
        public static IPServiceCategory ALLANONYMIZERSEXCEPTTOR = new IPServiceCategory("ALL_ANONYMIZERS_EXCEPT_TOR");
        /// <summary>
        /// StringEnum IPServiceCategory for value: ALL_IP_SERVICES
        /// </summary>
        public static IPServiceCategory ALLIPSERVICES = new IPServiceCategory("ALL_IP_SERVICES");
        /// <summary>
        /// StringEnum IPServiceCategory for value: ALL_PROXIES_VPNS
        /// </summary>
        public static IPServiceCategory ALLPROXIESVPNS = new IPServiceCategory("ALL_PROXIES_VPNS");
        /// <summary>
        /// StringEnum IPServiceCategory for value: ANONYMIZER_TOR
        /// </summary>
        public static IPServiceCategory ANONYMIZERTOR = new IPServiceCategory("ANONYMIZER_TOR");
        /// <summary>
        /// StringEnum IPServiceCategory for value: APPLE_ICLOUD_RELAY_PROXY
        /// </summary>
        public static IPServiceCategory APPLEICLOUDRELAYPROXY = new IPServiceCategory("APPLE_ICLOUD_RELAY_PROXY");
        /// <summary>
        /// StringEnum IPServiceCategory for value: AVAST_VPN
        /// </summary>
        public static IPServiceCategory AVASTVPN = new IPServiceCategory("AVAST_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: GLOBALPROTECT_VPN
        /// </summary>
        public static IPServiceCategory GLOBALPROTECTVPN = new IPServiceCategory("GLOBALPROTECT_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: GOOGLE_VPN
        /// </summary>
        public static IPServiceCategory GOOGLEVPN = new IPServiceCategory("GOOGLE_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: MULLVAD_VPN
        /// </summary>
        public static IPServiceCategory MULLVADVPN = new IPServiceCategory("MULLVAD_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: NORD_VPN
        /// </summary>
        public static IPServiceCategory NORDVPN = new IPServiceCategory("NORD_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: OXYLABS_PROXY
        /// </summary>
        public static IPServiceCategory OXYLABSPROXY = new IPServiceCategory("OXYLABS_PROXY");
        /// <summary>
        /// StringEnum IPServiceCategory for value: SAMSUNG_VPN
        /// </summary>
        public static IPServiceCategory SAMSUNGVPN = new IPServiceCategory("SAMSUNG_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: SURFSHARK_VPN
        /// </summary>
        public static IPServiceCategory SURFSHARKVPN = new IPServiceCategory("SURFSHARK_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: SYMANTEC_VPN
        /// </summary>
        public static IPServiceCategory SYMANTECVPN = new IPServiceCategory("SYMANTEC_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: TRENDMICRO_VPN
        /// </summary>
        public static IPServiceCategory TRENDMICROVPN = new IPServiceCategory("TRENDMICRO_VPN");
        /// <summary>
        /// StringEnum IPServiceCategory for value: ULTRASURF_VPN
        /// </summary>
        public static IPServiceCategory ULTRASURFVPN = new IPServiceCategory("ULTRASURF_VPN");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="IPServiceCategory"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator IPServiceCategory(string value) => new IPServiceCategory(value);

        /// <summary>
        /// Creates a new <see cref="IPServiceCategory"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public IPServiceCategory(string value)
            : base(value)
        {
        }
    }


}
