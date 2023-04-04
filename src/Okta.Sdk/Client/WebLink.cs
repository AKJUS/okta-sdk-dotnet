﻿/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Okta.Sdk.Client
{
    /// <summary>
    /// Represents an <a href="https://tools.ietf.org/html/rfc5988">RFC 5988</a> Web Link.
    /// </summary>
    public class WebLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebLink"/> class.
        /// </summary>
        /// <param name="target">The link target.</param>
        /// <param name="relation">The link relation.</param>
        public WebLink(string target, string relation)
        {
            Target = target;
            Relation = relation;
        }

        /// <summary>
        /// Gets the link target.
        /// </summary>
        /// <value>
        /// The link target.
        /// </value>
        public string Target { get; }

        /// <summary>
        /// Gets the link relation.
        /// </summary>
        /// <value>
        /// The link relation.
        /// </value>
        public string Relation { get; }

        /// <inheritdoc/>
        public override string ToString() => Target;
    }
}