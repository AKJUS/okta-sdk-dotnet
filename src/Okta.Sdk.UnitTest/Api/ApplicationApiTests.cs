/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * The version of the OpenAPI document: 2.10.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.Net;
using Xunit;
using System.Threading.Tasks;
using FluentAssertions;
using Okta.Sdk.UnitTest.Internal;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Okta.Sdk.UnitTest
{
    /// <summary>
    ///  Class for testing ApplicationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApplicationApiTests 
    {
        [Fact]
        public async Task GetOAuthToken()
        {
            var mockClient = new MockAsyncClient(GetOAuthTokenStubResponse(), HttpStatusCode.OK);
            var appApi = new ApplicationTokensApi(mockClient, new Configuration { BasePath = "https://foo.com" });

            var token = await appApi.GetOAuth2TokenForApplicationAsync("foo", "oar579Mcp7OUsNTlo0g3");

            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/tokens/{tokenId}");
            mockClient.ReceivedPathParams["tokenId"].Should().Contain("oar579Mcp7OUsNTlo0g3");
            mockClient.ReceivedPathParams["appId"].Should().Contain("foo");

            token.Should().NotBeNull();
            token.Id.Should().Be("oar579Mcp7OUsNTlo0g3");
            token.Status.Value.Should().Be("ACTIVE");
            token.Created.Date.Should().Be(new DateTime(2018, 3, 9));
            token.LastUpdated.Date.Should().Be(new DateTime(2018, 3, 9));
            token.ExpiresAt.Date.Should().Be(new DateTime(2018, 3, 16));
            token.Issuer.Should().Be("https://${yourOktaDomain}/oauth2/ausain6z9zIedDCxB0h7");
            token.ClientId.Should().Be("0oabskvc6442nkvQO0h7");
            token.UserId.Should().Be("00u5t60iloOHN9pBi0h7");
            token.Scopes.Should().Contain("offline_access");
            token.Scopes.Should().Contain("car:drive");
        }

        [Fact]
        public async Task ListOAuthTokens()
        {
            var mockClient = new MockAsyncClient(GetListOAuthTokensStubResponse(), HttpStatusCode.OK);
            var appApi = new ApplicationTokensApi(mockClient, new Configuration { BasePath = "https://foo.com" });

            var tokens = await appApi.ListOAuth2TokensForApplication("foo").ToListAsync();

            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/tokens");
            mockClient.ReceivedPathParams["appId"].Should().Contain("foo");

            tokens.FirstOrDefault().Should().NotBeNull();
            tokens.FirstOrDefault().Id.Should().Be("oar579Mcp7OUsNTlo0g3");
            tokens.FirstOrDefault().Status.Value.Should().Be("ACTIVE");
            tokens.FirstOrDefault().Created.Date.Should().Be(new DateTime(2018, 3, 9));
            tokens.FirstOrDefault().LastUpdated.Date.Should().Be(new DateTime(2018, 3, 9));
            tokens.FirstOrDefault().ExpiresAt.Date.Should().Be(new DateTime(2018, 3, 16));
            tokens.FirstOrDefault().Issuer.Should().Be("https://${yourOktaDomain}/oauth2/ausain6z9zIedDCxB0h7");
            tokens.FirstOrDefault().ClientId.Should().Be("0oabskvc6442nkvQO0h7");
            tokens.FirstOrDefault().UserId.Should().Be("00u5t60iloOHN9pBi0h7");
            tokens.FirstOrDefault().Scopes.Should().Contain("offline_access");
            tokens.FirstOrDefault().Scopes.Should().Contain("car:drive");
        }

        [Fact]
        public async Task UpdateFeature()
        {
            var rawResponse = @"{
                                        ""name"": ""USER_PROVISIONING"",
                                        ""status"": ""ENABLED"",
                                        ""description"": ""User provisioning settings from Okta to a downstream application"",
                                        ""capabilities"": {
                                            ""create"": {
                                                ""lifecycleCreate"": {
                                                    ""status"": ""DISABLED""
                                                }
                                            },
                                            ""update"": {
                                                ""profile"": {
                                                    ""status"": ""DISABLED""
                                                },
                                                ""lifecycleDeactivate"": {
                                                    ""status"": ""DISABLED""
                                                },
                                                ""password"": {
                                                    ""status"": ""DISABLED"",
                                                    ""seed"": ""RANDOM"",
                                                    ""change"": ""KEEP_EXISTING""
                                                }
                                            }
                                        }
                                    }";
            var mockClient = new MockAsyncClient(rawResponse, HttpStatusCode.OK);
            var appApi = new ApplicationFeaturesApi(mockClient, new Configuration { BasePath = "https://foo.com" });

            var capabilitiesObj = new UpdateFeatureForApplicationRequest(new CapabilitiesObject
            {
                Create = new CapabilitiesCreateObject
                {
                    LifecycleCreate = new LifecycleCreateSettingObject
                    {
                        Status = "DISABLED",
                    },
                },
            });

            var feature = await appApi.UpdateFeatureForApplicationAsync("foo", "bar", capabilitiesObj);

            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/features/{featureName}");
            mockClient.ReceivedPathParams["appId"].Should().Contain("foo");
            mockClient.ReceivedPathParams["featureName"].Should().Contain("bar");

            var expectedBody = @"{""create"":{""lifecycleCreate"":{""status"":""DISABLED""}},""update"":null}";

            mockClient.ReceivedBody.Should().Be(expectedBody);

            feature.Should().NotBeNull();
            feature.Status.Value.Should().Be("ENABLED");
            feature.Name.Should().Be(ApplicationFeatureType.USERPROVISIONING);
            feature.Capabilities.Create.LifecycleCreate.Status.Value.Should().Be("DISABLED");

        }

        [Fact]
        public async Task GetFeature()
        {
            var rawResponse = @"{
                                        ""name"": ""USER_PROVISIONING"",
                                        ""status"": ""ENABLED"",
                                        ""description"": ""User provisioning settings from Okta to a downstream application"",
                                        ""capabilities"": {
                                            ""create"": {
                                                ""lifecycleCreate"": {
                                                    ""status"": ""DISABLED""
                                                }
                                            },
                                            ""update"": {
                                                ""profile"": {
                                                    ""status"": ""DISABLED""
                                                },
                                                ""lifecycleDeactivate"": {
                                                    ""status"": ""DISABLED""
                                                },
                                                ""password"": {
                                                    ""status"": ""DISABLED"",
                                                    ""seed"": ""RANDOM"",
                                                    ""change"": ""KEEP_EXISTING""
                                                }
                                            }
                                        }
                                    }";
            var mockClient = new MockAsyncClient(rawResponse, HttpStatusCode.OK);
            var appApi = new ApplicationFeaturesApi(mockClient, new Configuration { BasePath = "https://foo.com" });
            var feature = await appApi.GetFeatureForApplicationAsync("foo", "bar");

            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/features/{featureName}");
            mockClient.ReceivedPathParams["appId"].Should().Contain("foo");
            mockClient.ReceivedPathParams["featureName"].Should().Contain("bar");

            feature.Should().NotBeNull();
            feature.Status.Value.Should().Be("ENABLED");
            feature.Name.Should().Be(ApplicationFeatureType.USERPROVISIONING);
            feature.Capabilities.Create.LifecycleCreate.Status.Value.Should().Be("DISABLED");
        }

        [Fact]
        public async Task ListFeatures()
        {
            var rawResponse = @"[{
                                        ""name"": ""USER_PROVISIONING"",
                                        ""status"": ""ENABLED"",
                                        ""description"": ""User provisioning settings from Okta to a downstream application"",
                                        ""capabilities"": {
                                            ""create"": {
                                                ""lifecycleCreate"": {
                                                    ""status"": ""DISABLED""
                                                }
                                            },
                                            ""update"": {
                                                ""profile"": {
                                                    ""status"": ""DISABLED""
                                                },
                                                ""lifecycleDeactivate"": {
                                                    ""status"": ""DISABLED""
                                                },
                                                ""password"": {
                                                    ""status"": ""DISABLED"",
                                                    ""seed"": ""RANDOM"",
                                                    ""change"": ""KEEP_EXISTING""
                                                }
                                            }
                                        }
                                    }]";
            var mockClient = new MockAsyncClient(rawResponse, HttpStatusCode.OK);
            var appApi = new ApplicationFeaturesApi(mockClient, new Configuration { BasePath = "https://foo.com" });
            var features = await appApi.ListFeaturesForApplication("foo").ToListAsync();

            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/features");
            mockClient.ReceivedPathParams["appId"].Should().Contain("foo");

            features.Should().NotBeNull();
            features.FirstOrDefault().Status.Value.Should().Be("ENABLED");
            features.FirstOrDefault().Name.Should().Be(ApplicationFeatureType.USERPROVISIONING);
            features.FirstOrDefault().Capabilities.Create.LifecycleCreate.Status.Value.Should().Be("DISABLED");
        }

        [Fact]
        public async Task ActivateDefaultConnection()
        {
            var mockClient = new MockAsyncClient(string.Empty, HttpStatusCode.OK);
            var appApi = new ApplicationConnectionsApi(mockClient, new Configuration { BasePath = "https://foo.com" });

            await appApi.ActivateDefaultProvisioningConnectionForApplicationAsync("foo");
            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/connections/default/lifecycle/activate");
            mockClient.ReceivedPathParams["appId"].Should().Contain("foo");
        }

        [Fact]
        public async Task DeactivateDefaultConnection()
        {
            var mockClient = new MockAsyncClient(string.Empty, HttpStatusCode.OK);
            var appApi = new ApplicationConnectionsApi(mockClient, new Configuration { BasePath = "https://foo.com" });

            await appApi.DeactivateDefaultProvisioningConnectionForApplicationAsync("foo");
            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/connections/default/lifecycle/deactivate");
            mockClient.ReceivedPathParams["appId"].Should().Contain("foo");
        }

        [Fact]
        public async Task SetDefaultConnection()
        {
            var rawResponse = @"{
                                    ""authScheme"": ""TOKEN"",
                                    ""profile"": {""authScheme"": ""TOKEN""},
                                    ""status"": ""ENABLED"",
                                    ""_links"": {
                                        ""self"": {
                                            ""href"": ""https://${yourOktaDomain}/api/v1/apps/${applicationId}/connections/default"",
                                            ""hints"": {
                                                ""allow"": [
                                                    ""POST"",
                                                    ""GET""
                                                ]
                                            }
                                        },
                                        ""deactivate"": {
                                            ""href"": ""https://${yourOktaDomain}/api/v1/apps/${applicationId}/connections/default/lifecycle/deactivate"",
                                            ""hints"": {
                                                ""allow"": [
                                                    ""POST""
                                                ]
                                            }
                                        }
                                    }
                                }";

            var mockClient = new MockAsyncClient(rawResponse, HttpStatusCode.OK);
            var appApi = new ApplicationConnectionsApi(mockClient, new Configuration { BasePath = "https://foo.com" });
            
            var connectionProfile = new UpdateDefaultProvisioningConnectionForApplicationRequest(new ProvisioningConnectionTokenRequest
            {
                Profile = new ProvisioningConnectionTokenRequestProfile
                {
                    AuthScheme = ProvisioningConnectionTokenAuthScheme.TOKEN
                }
            });

            var response = await appApi.UpdateDefaultProvisioningConnectionForApplicationAsync("bar", connectionProfile, true);
            mockClient.ReceivedPath.Should().StartWith("/api/v1/apps/{appId}/connections/default");
            mockClient.ReceivedPathParams["appId"].Should().Contain("bar");
            mockClient.ReceivedQueryParams.ContainsKey("activate").Should().BeTrue();
            mockClient.ReceivedQueryParams["activate"].Should().Contain("true");

            var expectedBody = @"{""baseUrl"":null,""profile"":{""authScheme"":""TOKEN"",""token"":null}}";
            mockClient.ReceivedBody.Should().Be(expectedBody);
            response.Status.Value.Should().Be("ENABLED");
            response.Profile.AuthScheme.Value.Should().Be("TOKEN");
            response.AuthScheme.Value.Should().Be("TOKEN");
        }

        private string GetListOAuthTokensStubResponse()
        {
            var rawResponse = @"
                                [
                                  {
                                    ""id"": ""oar579Mcp7OUsNTlo0g3"",
                                    ""status"": ""ACTIVE"",
                                    ""created"": ""2018-03-09T03:18:06.000Z"",
                                    ""lastUpdated"": ""2018-03-09T03:18:06.000Z"",
                                    ""expiresAt"": ""2018-03-16T03:18:06.000Z"",
                                    ""issuer"": ""https://${yourOktaDomain}/oauth2/ausain6z9zIedDCxB0h7"",
                                    ""clientId"": ""0oabskvc6442nkvQO0h7"",
                                    ""userId"": ""00u5t60iloOHN9pBi0h7"",
                                    ""scopes"": [
                                      ""offline_access"",
                                      ""car:drive""
                                    ],
                                    ""_links"": {
                                      ""app"": {
                                        ""href"": ""https://${yourOktaDomain}/api/v1/apps/0oabskvc6442nkvQO0h7"",
                                        ""title"": ""Native""
                                      },
                                      ""self"": {
                                        ""href"": ""https://${yourOktaDomain}/api/v1/apps/0oabskvc6442nkvQO0h7/tokens/oar579Mcp7OUsNTlo0g3""
                                      },
                                      ""revoke"": {
                                        ""href"": ""https://${yourOktaDomain}/api/v1/apps/0oabskvc6442nkvQO0h7/tokens/oar579Mcp7OUsNTlo0g3"",
                                        ""hints"": {
                                          ""allow"": [
                                            ""DELETE""
                                          ]
                                        }
                                      },
                                      ""client"": {
                                        ""href"": ""https://${yourOktaDomain}/oauth2/v1/clients/0oabskvc6442nkvQO0h7"",
                                        ""title"": ""Example Client App""
                                      },
                                      ""user"": {
                                        ""href"": ""https://${yourOktaDomain}/api/v1/users/00upcgi9dyWEOeCwM0g3"",
                                        ""title"": ""Saml Jackson""
                                      },
                                      ""authorizationServer"": {
                                        ""href"": ""https://${yourOktaDomain}/api/v1/authorizationServers/ausain6z9zIedDCxB0h7"",
                                        ""title"": ""Example Authorization Server""
                                      }
                                    }
                                  }
                                ]";

            return rawResponse;
        }

        private string GetOAuthTokenStubResponse()
        {
            var rawResponse = @"
                                {
                                  ""id"": ""oar579Mcp7OUsNTlo0g3"",
                                  ""status"": ""ACTIVE"",
                                  ""created"": ""2018-03-09T03:18:06.000Z"",
                                  ""lastUpdated"": ""2018-03-09T03:18:06.000Z"",
                                  ""expiresAt"": ""2018-03-16T03:18:06.000Z"",
                                  ""issuer"": ""https://${yourOktaDomain}/oauth2/ausain6z9zIedDCxB0h7"",
                                  ""clientId"": ""0oabskvc6442nkvQO0h7"",
                                  ""userId"": ""00u5t60iloOHN9pBi0h7"",
                                  ""scopes"": [
                                    ""offline_access"",
                                    ""car:drive""
                                  ],
                                  ""_links"": {
                                    ""app"": {
                                      ""href"": ""https://${yourOktaDomain}/api/v1/apps/0oabskvc6442nkvQO0h7"",
                                      ""title"": ""Native""
                                    },
                                    ""self"": {
                                      ""href"": ""https://${yourOktaDomain}/api/v1/apps/0oabskvc6442nkvQO0h7/tokens/oar579Mcp7OUsNTlo0g3""
                                    },
                                    ""revoke"": {
                                      ""href"": ""https://${yourOktaDomain}/api/v1/apps/0oabskvc6442nkvQO0h7/tokens/oar579Mcp7OUsNTlo0g3"",
                                      ""hints"": {
                                        ""allow"": [
                                          ""DELETE""
                                        ]
                                      }
                                    },
                                    ""client"": {
                                      ""href"": ""https://${yourOktaDomain}/oauth2/v1/clients/0oabskvc6442nkvQO0h7"",
                                      ""title"": ""Example Client App""
                                    },
                                    ""user"": {
                                      ""href"": ""https://${yourOktaDomain}/api/v1/users/00upcgi9dyWEOeCwM0g3"",
                                      ""title"": ""Saml Jackson""
                                    },
                                    ""authorizationServer"": {
                                      ""href"": ""https://${yourOktaDomain}/api/v1/authorizationServers/ausain6z9zIedDCxB0h7"",
                                      ""title"": ""Example Authorization Server""
                                    }
                                  }
                                }";

            return rawResponse;
        }

        [Fact]
        public async Task GetSamlApplicationSettingsAppAdditionalProperties()
        {
            var samlAppStub = @"{
                                ""id"": ""<id>"",
                                ""name"": ""salesforce"",
                                ""label"": ""Salesforce.com"",
                                ""status"": ""ACTIVE"",
                                ""lastUpdated"": ""2023-05-09T14:01:21.000Z"",
                                ""created"": ""2023-05-09T13:58:16.000Z"",
                                ""accessibility"": {
                                    ""selfService"": false,
                                    ""errorRedirectUrl"": null,
                                    ""loginRedirectUrl"": null
                                },
                                ""licensing"": {
                                    ""seatCount"": 0
                                },
                                ""visibility"": {
                                    ""autoLaunch"": false,
                                    ""autoSubmitToolbar"": true,
                                    ""hide"": {
                                        ""iOS"": false,
                                        ""web"": false
                                    },
                                    ""appLinks"": {
                                        ""mc"": true
                                    }
                                },
                                ""features"": [],
                                ""signOnMode"": ""SAML_2_0"",
                                ""credentials"": {
                                    ""userNameTemplate"": {
                                        ""template"": ""${source.login}"",
                                        ""type"": ""BUILT_IN""
                                    },
                                    ""signing"": {
                                        ""kid"": ""<kid>""
                                    }
                                },
                                ""settings"": {
                                    ""app"": {
                                        ""integrationType"": ""STANDARD"",
                                        ""siteURL"": null,
                                        ""loginUrl"": ""https://<domain>.my.salesforce.com"",
                                        ""logoutUrl"": null,
                                        ""instanceType"": ""PRODUCTION"",
                                        ""portalID"": null,
                                        ""orgID"": null,
                                        ""customDomain"": ""<domain>""
                                    },
                                    ""notifications"": {
                                        ""vpn"": {
                                            ""network"": {
                                                ""connection"": ""DISABLED""
                                            },
                                            ""message"": null,
                                            ""helpUrl"": null
                                        }
                                    },
                                    ""notes"": {
                                        ""admin"": null,
                                        ""enduser"": null
                                    },
                                    ""signOn"": {
                                        ""defaultRelayState"": null,
                                        ""ssoAcsUrlOverride"": null,
                                        ""audienceOverride"": null,
                                        ""recipientOverride"": null,
                                        ""destinationOverride"": null,
                                        ""attributeStatements"": []
                                    }
                                }
                            }";

            var mockClient = new MockAsyncClient(samlAppStub, HttpStatusCode.OK);
            var appApi = new ApplicationApi(mockClient, new Configuration { BasePath = "https://foo.com" });

            var samlApp = await appApi.GetApplicationAsync("foo") as SamlApplication;
            samlApp.Settings.App.AdditionalProperties["integrationType"].Should().Be("STANDARD");
            samlApp.Settings.App.AdditionalProperties["siteURL"].Should().BeNull();
            samlApp.Settings.App.AdditionalProperties["loginUrl"].Should().Be("https://<domain>.my.salesforce.com");
            samlApp.Settings.App.AdditionalProperties["logoutUrl"].Should().BeNull();
            samlApp.Settings.App.AdditionalProperties["instanceType"].Should().Be("PRODUCTION");
            samlApp.Settings.App.AdditionalProperties["portalID"].Should().BeNull();
            samlApp.Settings.App.AdditionalProperties["orgID"].Should().BeNull();
            samlApp.Settings.App.AdditionalProperties["customDomain"].Should().Be("<domain>");

        }
    }
}
