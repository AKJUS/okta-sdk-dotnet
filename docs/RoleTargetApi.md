# Okta.Sdk.Api.RoleTargetApi

All URIs are relative to *https://subdomain.okta.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignAllAppsAsTargetToRoleForUser**](RoleTargetApi.md#assignallappsastargettoroleforuser) | **PUT** /api/v1/users/{userId}/roles/{roleId}/targets/catalog/apps | Assign all Apps as Target to Role
[**AssignAppInstanceTargetToAppAdminRoleForGroup**](RoleTargetApi.md#assignappinstancetargettoappadminroleforgroup) | **PUT** /api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName}/{appId} | Assign an Application Instance Target to Application Administrator Role
[**AssignAppInstanceTargetToAppAdminRoleForUser**](RoleTargetApi.md#assignappinstancetargettoappadminroleforuser) | **PUT** /api/v1/users/{userId}/roles/{roleId}/targets/catalog/apps/{appName}/{appId} | Assign an Application Instance Target to an Application Administrator Role
[**AssignAppTargetInstanceRoleForClient**](RoleTargetApi.md#assignapptargetinstanceroleforclient) | **PUT** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/catalog/apps/{appName}/{appInstanceId} | Replace an App Instance Target for a Client
[**AssignAppTargetRoleToClient**](RoleTargetApi.md#assignapptargetroletoclient) | **PUT** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/catalog/apps/{appName} | Assign an App Target to a Client
[**AssignAppTargetToAdminRoleForGroup**](RoleTargetApi.md#assignapptargettoadminroleforgroup) | **PUT** /api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName} | Assign an Application Target to Administrator Role
[**AssignAppTargetToAdminRoleForUser**](RoleTargetApi.md#assignapptargettoadminroleforuser) | **PUT** /api/v1/users/{userId}/roles/{roleId}/targets/catalog/apps/{appName} | Assign an Application Target to Administrator Role
[**AssignGroupTargetRoleForClient**](RoleTargetApi.md#assigngrouptargetroleforclient) | **PUT** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/groups/{groupId} | Assign a Group Target to a Client
[**AssignGroupTargetToGroupAdminRole**](RoleTargetApi.md#assigngrouptargettogroupadminrole) | **PUT** /api/v1/groups/{groupId}/roles/{roleId}/targets/groups/{targetGroupId} | Assign a Group Target to a Group Role
[**AssignGroupTargetToUserRole**](RoleTargetApi.md#assigngrouptargettouserrole) | **PUT** /api/v1/users/{userId}/roles/{roleId}/targets/groups/{groupId} | Assign a Group Target to Role
[**ListAppTargetRoleToClient**](RoleTargetApi.md#listapptargetroletoclient) | **GET** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/catalog/apps | List all App Targets assigned to a Client
[**ListApplicationTargetsForApplicationAdministratorRoleForGroup**](RoleTargetApi.md#listapplicationtargetsforapplicationadministratorroleforgroup) | **GET** /api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps | List all Application Targets for an Application Administrator Role
[**ListApplicationTargetsForApplicationAdministratorRoleForUser**](RoleTargetApi.md#listapplicationtargetsforapplicationadministratorroleforuser) | **GET** /api/v1/users/{userId}/roles/{roleId}/targets/catalog/apps | List all Application Targets for Application Administrator Role
[**ListGroupTargetRoleForClient**](RoleTargetApi.md#listgrouptargetroleforclient) | **GET** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/groups | List all Group Targets for a Client
[**ListGroupTargetsForGroupRole**](RoleTargetApi.md#listgrouptargetsforgrouprole) | **GET** /api/v1/groups/{groupId}/roles/{roleId}/targets/groups | List all Group Targets for a Group Role
[**ListGroupTargetsForRole**](RoleTargetApi.md#listgrouptargetsforrole) | **GET** /api/v1/users/{userId}/roles/{roleId}/targets/groups | List all Group Targets for Role
[**RemoveAppTargetInstanceRoleForClient**](RoleTargetApi.md#removeapptargetinstanceroleforclient) | **DELETE** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/catalog/apps/{appName}/{appInstanceId} | Delete an App Instance Target for a Client
[**RemoveAppTargetRoleFromClient**](RoleTargetApi.md#removeapptargetrolefromclient) | **DELETE** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/catalog/apps/{appName} | Remove an App Target from a Client
[**RemoveGroupTargetRoleFromClient**](RoleTargetApi.md#removegrouptargetrolefromclient) | **DELETE** /oauth2/v1/clients/{clientId}/roles/{roleId}/targets/groups/{groupId} | Delete a Group Target from a Client
[**UnassignAppInstanceTargetFromAdminRoleForUser**](RoleTargetApi.md#unassignappinstancetargetfromadminroleforuser) | **DELETE** /api/v1/users/{userId}/roles/{roleId}/targets/catalog/apps/{appName}/{appId} | Unassign an Application Instance Target from an Application Administrator Role
[**UnassignAppInstanceTargetToAppAdminRoleForGroup**](RoleTargetApi.md#unassignappinstancetargettoappadminroleforgroup) | **DELETE** /api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName}/{appId} | Unassign an Application Instance Target from an Application Administrator Role
[**UnassignAppTargetFromAppAdminRoleForUser**](RoleTargetApi.md#unassignapptargetfromappadminroleforuser) | **DELETE** /api/v1/users/{userId}/roles/{roleId}/targets/catalog/apps/{appName} | Unassign an Application Target from an Application Administrator Role
[**UnassignAppTargetToAdminRoleForGroup**](RoleTargetApi.md#unassignapptargettoadminroleforgroup) | **DELETE** /api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName} | Unassign an Application Target from Application Administrator Role
[**UnassignGroupTargetFromGroupAdminRole**](RoleTargetApi.md#unassigngrouptargetfromgroupadminrole) | **DELETE** /api/v1/groups/{groupId}/roles/{roleId}/targets/groups/{targetGroupId} | Unassign a Group Target from a Group Role
[**UnassignGroupTargetFromUserAdminRole**](RoleTargetApi.md#unassigngrouptargetfromuseradminrole) | **DELETE** /api/v1/users/{userId}/roles/{roleId}/targets/groups/{groupId} | Unassign a Group Target from Role


<a name="assignallappsastargettoroleforuser"></a>
# **AssignAllAppsAsTargetToRoleForUser**
> void AssignAllAppsAsTargetToRoleForUser (string userId, string roleId)

Assign all Apps as Target to Role

Assigns all Apps as Target to Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignAllAppsAsTargetToRoleForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role

            try
            {
                // Assign all Apps as Target to Role
                apiInstance.AssignAllAppsAsTargetToRoleForUser(userId, roleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignAllAppsAsTargetToRoleForUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignappinstancetargettoappadminroleforgroup"></a>
# **AssignAppInstanceTargetToAppAdminRoleForGroup**
> void AssignAppInstanceTargetToAppAdminRoleForGroup (string groupId, string roleId, string appName, string appId)

Assign an Application Instance Target to Application Administrator Role

Assigns App Instance Target to App Administrator Role given to a Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignAppInstanceTargetToAppAdminRoleForGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type
            var appId = 0oafxqCAJWWGELFTYASJ;  // string | Application ID

            try
            {
                // Assign an Application Instance Target to Application Administrator Role
                apiInstance.AssignAppInstanceTargetToAppAdminRoleForGroup(groupId, roleId, appName, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignAppInstanceTargetToAppAdminRoleForGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 
 **appId** | **string**| Application ID | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignappinstancetargettoappadminroleforuser"></a>
# **AssignAppInstanceTargetToAppAdminRoleForUser**
> void AssignAppInstanceTargetToAppAdminRoleForUser (string userId, string roleId, string appName, string appId)

Assign an Application Instance Target to an Application Administrator Role

Assigns anapplication instance target to appplication administrator role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignAppInstanceTargetToAppAdminRoleForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type
            var appId = 0oafxqCAJWWGELFTYASJ;  // string | Application ID

            try
            {
                // Assign an Application Instance Target to an Application Administrator Role
                apiInstance.AssignAppInstanceTargetToAppAdminRoleForUser(userId, roleId, appName, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignAppInstanceTargetToAppAdminRoleForUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 
 **appId** | **string**| Application ID | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignapptargetinstanceroleforclient"></a>
# **AssignAppTargetInstanceRoleForClient**
> void AssignAppTargetInstanceRoleForClient (string clientId, string roleId, string appName, string appInstanceId)

Replace an App Instance Target for a Client

Replaces an App Instance Target by `clientId`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignAppTargetInstanceRoleForClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type
            var appInstanceId = "appInstanceId_example";  // string | `id` of the application instance

            try
            {
                // Replace an App Instance Target for a Client
                apiInstance.AssignAppTargetInstanceRoleForClient(clientId, roleId, appName, appInstanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignAppTargetInstanceRoleForClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 
 **appInstanceId** | **string**| &#x60;id&#x60; of the application instance | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignapptargetroletoclient"></a>
# **AssignAppTargetRoleToClient**
> void AssignAppTargetRoleToClient (string clientId, string roleId, string appName)

Assign an App Target to a Client

Assigns an Application Target to a Client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignAppTargetRoleToClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type

            try
            {
                // Assign an App Target to a Client
                apiInstance.AssignAppTargetRoleToClient(clientId, roleId, appName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignAppTargetRoleToClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignapptargettoadminroleforgroup"></a>
# **AssignAppTargetToAdminRoleForGroup**
> void AssignAppTargetToAdminRoleForGroup (string groupId, string roleId, string appName)

Assign an Application Target to Administrator Role

Assigns an application target to administrator role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignAppTargetToAdminRoleForGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type

            try
            {
                // Assign an Application Target to Administrator Role
                apiInstance.AssignAppTargetToAdminRoleForGroup(groupId, roleId, appName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignAppTargetToAdminRoleForGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignapptargettoadminroleforuser"></a>
# **AssignAppTargetToAdminRoleForUser**
> void AssignAppTargetToAdminRoleForUser (string userId, string roleId, string appName)

Assign an Application Target to Administrator Role

Assigns an application target to administrator role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignAppTargetToAdminRoleForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type

            try
            {
                // Assign an Application Target to Administrator Role
                apiInstance.AssignAppTargetToAdminRoleForUser(userId, roleId, appName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignAppTargetToAdminRoleForUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assigngrouptargetroleforclient"></a>
# **AssignGroupTargetRoleForClient**
> void AssignGroupTargetRoleForClient (string clientId, string roleId, string groupId)

Assign a Group Target to a Client

Assigns a Group Target to a Client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignGroupTargetRoleForClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group

            try
            {
                // Assign a Group Target to a Client
                apiInstance.AssignGroupTargetRoleForClient(clientId, roleId, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignGroupTargetRoleForClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **groupId** | **string**| The &#x60;id&#x60; of the group | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assigngrouptargettogroupadminrole"></a>
# **AssignGroupTargetToGroupAdminRole**
> void AssignGroupTargetToGroupAdminRole (string groupId, string roleId, string targetGroupId)

Assign a Group Target to a Group Role

Assigns a group target to a group role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignGroupTargetToGroupAdminRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var targetGroupId = 00g1e9dfjHeLAsdX983d;  // string | 

            try
            {
                // Assign a Group Target to a Group Role
                apiInstance.AssignGroupTargetToGroupAdminRole(groupId, roleId, targetGroupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignGroupTargetToGroupAdminRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **targetGroupId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assigngrouptargettouserrole"></a>
# **AssignGroupTargetToUserRole**
> void AssignGroupTargetToUserRole (string userId, string roleId, string groupId)

Assign a Group Target to Role

Assigns a Group Target to Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignGroupTargetToUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group

            try
            {
                // Assign a Group Target to Role
                apiInstance.AssignGroupTargetToUserRole(userId, roleId, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.AssignGroupTargetToUserRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **groupId** | **string**| The &#x60;id&#x60; of the group | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapptargetroletoclient"></a>
# **ListAppTargetRoleToClient**
> ModelClient ListAppTargetRoleToClient (string clientId, string roleId, string after = null, int? limit = null)

List all App Targets assigned to a Client

Lists App Targets for Client and Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListAppTargetRoleToClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var after = "after_example";  // string | The cursor to use for pagination. It is an opaque string that specifies your current location in the list and is obtained from the `Link` response header. See [Pagination](/#pagination). (optional) 
            var limit = 20;  // int? | A limit on the number of objects to return (optional)  (default to 20)

            try
            {
                // List all App Targets assigned to a Client
                ModelClient result = apiInstance.ListAppTargetRoleToClient(clientId, roleId, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.ListAppTargetRoleToClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **after** | **string**| The cursor to use for pagination. It is an opaque string that specifies your current location in the list and is obtained from the &#x60;Link&#x60; response header. See [Pagination](/#pagination). | [optional] 
 **limit** | **int?**| A limit on the number of objects to return | [optional] [default to 20]

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapplicationtargetsforapplicationadministratorroleforgroup"></a>
# **ListApplicationTargetsForApplicationAdministratorRoleForGroup**
> List&lt;CatalogApplication&gt; ListApplicationTargetsForApplicationAdministratorRoleForGroup (string groupId, string roleId, string after = null, int? limit = null)

List all Application Targets for an Application Administrator Role

Lists all App targets for an `APP_ADMIN` Role assigned to a Group. This methods return list may include full Applications or Instances. The response for an instance will have an `ID` value, while Application will not have an ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListApplicationTargetsForApplicationAdministratorRoleForGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var after = "after_example";  // string |  (optional) 
            var limit = 20;  // int? |  (optional)  (default to 20)

            try
            {
                // List all Application Targets for an Application Administrator Role
                List<CatalogApplication> result = apiInstance.ListApplicationTargetsForApplicationAdministratorRoleForGroup(groupId, roleId, after, limit).ToListAsync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.ListApplicationTargetsForApplicationAdministratorRoleForGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 20]

### Return type

[**List&lt;CatalogApplication&gt;**](CatalogApplication.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapplicationtargetsforapplicationadministratorroleforuser"></a>
# **ListApplicationTargetsForApplicationAdministratorRoleForUser**
> List&lt;CatalogApplication&gt; ListApplicationTargetsForApplicationAdministratorRoleForUser (string userId, string roleId, string after = null, int? limit = null)

List all Application Targets for Application Administrator Role

Lists all App targets for an `APP_ADMIN` Role assigned to a User. This methods return list may include full Applications or Instances. The response for an instance will have an `ID` value, while Application will not have an ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListApplicationTargetsForApplicationAdministratorRoleForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var after = "after_example";  // string |  (optional) 
            var limit = 20;  // int? |  (optional)  (default to 20)

            try
            {
                // List all Application Targets for Application Administrator Role
                List<CatalogApplication> result = apiInstance.ListApplicationTargetsForApplicationAdministratorRoleForUser(userId, roleId, after, limit).ToListAsync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.ListApplicationTargetsForApplicationAdministratorRoleForUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 20]

### Return type

[**List&lt;CatalogApplication&gt;**](CatalogApplication.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgrouptargetroleforclient"></a>
# **ListGroupTargetRoleForClient**
> ModelClient ListGroupTargetRoleForClient (string clientId, string roleId, string after = null, int? limit = null)

List all Group Targets for a Client

Lists all Group Targets by `clientId` and `roleId`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListGroupTargetRoleForClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var after = "after_example";  // string | The cursor to use for pagination. It is an opaque string that specifies your current location in the list and is obtained from the `Link` response header. See [Pagination](/#pagination). (optional) 
            var limit = 20;  // int? | A limit on the number of objects to return (optional)  (default to 20)

            try
            {
                // List all Group Targets for a Client
                ModelClient result = apiInstance.ListGroupTargetRoleForClient(clientId, roleId, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.ListGroupTargetRoleForClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **after** | **string**| The cursor to use for pagination. It is an opaque string that specifies your current location in the list and is obtained from the &#x60;Link&#x60; response header. See [Pagination](/#pagination). | [optional] 
 **limit** | **int?**| A limit on the number of objects to return | [optional] [default to 20]

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgrouptargetsforgrouprole"></a>
# **ListGroupTargetsForGroupRole**
> List&lt;Group&gt; ListGroupTargetsForGroupRole (string groupId, string roleId, string after = null, int? limit = null)

List all Group Targets for a Group Role

Lists all group targets for a group role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListGroupTargetsForGroupRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var after = "after_example";  // string |  (optional) 
            var limit = 20;  // int? |  (optional)  (default to 20)

            try
            {
                // List all Group Targets for a Group Role
                List<Group> result = apiInstance.ListGroupTargetsForGroupRole(groupId, roleId, after, limit).ToListAsync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.ListGroupTargetsForGroupRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 20]

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgrouptargetsforrole"></a>
# **ListGroupTargetsForRole**
> List&lt;Group&gt; ListGroupTargetsForRole (string userId, string roleId, string after = null, int? limit = null)

List all Group Targets for Role

Lists all group targets for role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListGroupTargetsForRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var after = "after_example";  // string |  (optional) 
            var limit = 20;  // int? |  (optional)  (default to 20)

            try
            {
                // List all Group Targets for Role
                List<Group> result = apiInstance.ListGroupTargetsForRole(userId, roleId, after, limit).ToListAsync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.ListGroupTargetsForRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 20]

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeapptargetinstanceroleforclient"></a>
# **RemoveAppTargetInstanceRoleForClient**
> void RemoveAppTargetInstanceRoleForClient (string clientId, string roleId, string appName, string appInstanceId)

Delete an App Instance Target for a Client

Deletes an App Instance Target from a Client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RemoveAppTargetInstanceRoleForClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type
            var appInstanceId = "appInstanceId_example";  // string | `id` of the application instance

            try
            {
                // Delete an App Instance Target for a Client
                apiInstance.RemoveAppTargetInstanceRoleForClient(clientId, roleId, appName, appInstanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.RemoveAppTargetInstanceRoleForClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 
 **appInstanceId** | **string**| &#x60;id&#x60; of the application instance | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeapptargetrolefromclient"></a>
# **RemoveAppTargetRoleFromClient**
> void RemoveAppTargetRoleFromClient (string clientId, string roleId, string appName)

Remove an App Target from a Client

Removes an Application Target by `clientId`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RemoveAppTargetRoleFromClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type

            try
            {
                // Remove an App Target from a Client
                apiInstance.RemoveAppTargetRoleFromClient(clientId, roleId, appName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.RemoveAppTargetRoleFromClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removegrouptargetrolefromclient"></a>
# **RemoveGroupTargetRoleFromClient**
> void RemoveGroupTargetRoleFromClient (string clientId, string roleId, string groupId)

Delete a Group Target from a Client

Deletes a Group Target from a Client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RemoveGroupTargetRoleFromClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var clientId = 52Uy4BUWVBOjFItcg2jWsmnd83Ad8dD;  // string | `client_id` of the app
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group

            try
            {
                // Delete a Group Target from a Client
                apiInstance.RemoveGroupTargetRoleFromClient(clientId, roleId, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.RemoveGroupTargetRoleFromClient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| &#x60;client_id&#x60; of the app | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **groupId** | **string**| The &#x60;id&#x60; of the group | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignappinstancetargetfromadminroleforuser"></a>
# **UnassignAppInstanceTargetFromAdminRoleForUser**
> void UnassignAppInstanceTargetFromAdminRoleForUser (string userId, string roleId, string appName, string appId)

Unassign an Application Instance Target from an Application Administrator Role

Unassigns an application instance target from an application administrator role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnassignAppInstanceTargetFromAdminRoleForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type
            var appId = 0oafxqCAJWWGELFTYASJ;  // string | Application ID

            try
            {
                // Unassign an Application Instance Target from an Application Administrator Role
                apiInstance.UnassignAppInstanceTargetFromAdminRoleForUser(userId, roleId, appName, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.UnassignAppInstanceTargetFromAdminRoleForUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 
 **appId** | **string**| Application ID | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignappinstancetargettoappadminroleforgroup"></a>
# **UnassignAppInstanceTargetToAppAdminRoleForGroup**
> void UnassignAppInstanceTargetToAppAdminRoleForGroup (string groupId, string roleId, string appName, string appId)

Unassign an Application Instance Target from an Application Administrator Role

Unassigns an application instance target from application administrator role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnassignAppInstanceTargetToAppAdminRoleForGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type
            var appId = 0oafxqCAJWWGELFTYASJ;  // string | Application ID

            try
            {
                // Unassign an Application Instance Target from an Application Administrator Role
                apiInstance.UnassignAppInstanceTargetToAppAdminRoleForGroup(groupId, roleId, appName, appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.UnassignAppInstanceTargetToAppAdminRoleForGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 
 **appId** | **string**| Application ID | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignapptargetfromappadminroleforuser"></a>
# **UnassignAppTargetFromAppAdminRoleForUser**
> void UnassignAppTargetFromAppAdminRoleForUser (string userId, string roleId, string appName)

Unassign an Application Target from an Application Administrator Role

Unassigns an application target from application administrator role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnassignAppTargetFromAppAdminRoleForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type

            try
            {
                // Unassign an Application Target from an Application Administrator Role
                apiInstance.UnassignAppTargetFromAppAdminRoleForUser(userId, roleId, appName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.UnassignAppTargetFromAppAdminRoleForUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignapptargettoadminroleforgroup"></a>
# **UnassignAppTargetToAdminRoleForGroup**
> void UnassignAppTargetToAdminRoleForGroup (string groupId, string roleId, string appName)

Unassign an Application Target from Application Administrator Role

Unassigns an application target from application administrator role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnassignAppTargetToAdminRoleForGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var appName = oidc_client;  // string | Application name for the app type

            try
            {
                // Unassign an Application Target from Application Administrator Role
                apiInstance.UnassignAppTargetToAdminRoleForGroup(groupId, roleId, appName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.UnassignAppTargetToAdminRoleForGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **appName** | **string**| Application name for the app type | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassigngrouptargetfromgroupadminrole"></a>
# **UnassignGroupTargetFromGroupAdminRole**
> void UnassignGroupTargetFromGroupAdminRole (string groupId, string roleId, string targetGroupId)

Unassign a Group Target from a Group Role

Unassigns a group target from a group role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnassignGroupTargetFromGroupAdminRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var targetGroupId = 00g1e9dfjHeLAsdX983d;  // string | 

            try
            {
                // Unassign a Group Target from a Group Role
                apiInstance.UnassignGroupTargetFromGroupAdminRole(groupId, roleId, targetGroupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.UnassignGroupTargetFromGroupAdminRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The &#x60;id&#x60; of the group | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **targetGroupId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassigngrouptargetfromuseradminrole"></a>
# **UnassignGroupTargetFromUserAdminRole**
> void UnassignGroupTargetFromUserAdminRole (string userId, string roleId, string groupId)

Unassign a Group Target from Role

Unassigns a Group Target from Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnassignGroupTargetFromUserAdminRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.OktaDomain = "https://subdomain.okta.com";
            // Configure API key authorization: apiToken
            config.Token ="YOUR_API_KEY";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleTargetApi(config);
            var userId = "userId_example";  // string | ID of an existing Okta user
            var roleId = 3Vg1Pjp3qzw4qcCK5EdO;  // string | `id` of the Role
            var groupId = 00g1emaKYZTWRYYRRTSK;  // string | The `id` of the group

            try
            {
                // Unassign a Group Target from Role
                apiInstance.UnassignGroupTargetFromUserAdminRole(userId, roleId, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoleTargetApi.UnassignGroupTargetFromUserAdminRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of an existing Okta user | 
 **roleId** | **string**| &#x60;id&#x60; of the Role | 
 **groupId** | **string**| The &#x60;id&#x60; of the group | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

