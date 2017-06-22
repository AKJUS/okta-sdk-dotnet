﻿// <copyright file="CustomProxy.cs" company="Okta, Inc">
// Copyright (c) 2014-2017 Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Net;
using Microsoft.Extensions.Logging;
using Okta.Sdk.Configuration;

namespace Okta.Sdk.Internal
{
    public sealed class CustomProxy : IWebProxy
    {
        private readonly ICredentials _credentials;
        private readonly Uri _proxyUri;

        public CustomProxy(ProxyConfiguration proxyConfiguration, ILogger logger)
        {
            if (proxyConfiguration == null)
            {
                throw new ArgumentNullException(nameof(proxyConfiguration));
            }

            if (!string.IsNullOrEmpty(proxyConfiguration.Username) || !string.IsNullOrEmpty(proxyConfiguration.Password))
            {
                logger.LogInformation("Using supplied proxy credentials");
                _credentials = new NetworkCredential(proxyConfiguration.Username, proxyConfiguration.Password);
            }

            var host = proxyConfiguration.Host;

            if (!host.Contains(":"))
            {
                var port = proxyConfiguration?.Port ?? 8080;
                host = $"{host}:{port}";
            }

            logger.LogInformation($"Using proxy host {host}");
            _proxyUri = new Uri(host, UriKind.Absolute);
        }

        /// <inheritdoc/>
        public ICredentials Credentials
        {
            get => _credentials;
            set => throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Uri GetProxy(Uri destination) => _proxyUri;

        /// <inheritdoc/>
        public bool IsBypassed(Uri host) => false;
    }
}
