# chemApiClient.Api.UpdatesApi

All URIs are relative to *https://sandbox.chemadvisor.io/chem/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEntryUpdate**](UpdatesApi.md#getentryupdate) | **GET** /updates_since/{release_id}/entry_changes/{substance_id} | Get Specific Regulatory Data Updates that were released after release_id
[**GetListUpdates**](UpdatesApi.md#getlistupdates) | **GET** /updates_since/{release_id}/regulatory_list_changes | Get All List additions and removals released after release_id


<a name="getentryupdate"></a>
# **GetEntryUpdate**
> EntryChanges GetEntryUpdate (string releaseId, string substanceId, int? limit = null, int? offset = null, string appKey = null, string appId = null)

Get Specific Regulatory Data Updates that were released after release_id

Returns an **EntryChanges** collection. 

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetEntryUpdateExample
    {
        public void main()
        {
            
            var apiInstance = new UpdatesApi();
            var releaseId = releaseId_example;  // string | Release ID
            var substanceId = substanceId_example;  // string | Substance ID
            var limit = 56;  // int? | Number of items to retrieve (optional)  (default to 10)
            var offset = 56;  // int? | Offset of the first item returned (optional)  (default to 0)
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Get Specific Regulatory Data Updates that were released after release_id
                EntryChanges result = apiInstance.GetEntryUpdate(releaseId, substanceId, limit, offset, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetEntryUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **string**| Release ID | 
 **substanceId** | **string**| Substance ID | 
 **limit** | **int?**| Number of items to retrieve | [optional] [default to 10]
 **offset** | **int?**| Offset of the first item returned | [optional] [default to 0]
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**EntryChanges**](EntryChanges.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistupdates"></a>
# **GetListUpdates**
> RegulatoryListChanges GetListUpdates (string releaseId, int? limit = null, int? offset = null, string appKey = null, string appId = null)

Get All List additions and removals released after release_id

Returns a **RegulatoryListChanges** object. 

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetListUpdatesExample
    {
        public void main()
        {
            
            var apiInstance = new UpdatesApi();
            var releaseId = releaseId_example;  // string | Release ID
            var limit = 56;  // int? | Number of items to retrieve (optional)  (default to 10)
            var offset = 56;  // int? | Offset of the first item returned (optional)  (default to 0)
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Get All List additions and removals released after release_id
                RegulatoryListChanges result = apiInstance.GetListUpdates(releaseId, limit, offset, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetListUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **releaseId** | **string**| Release ID | 
 **limit** | **int?**| Number of items to retrieve | [optional] [default to 10]
 **offset** | **int?**| Offset of the first item returned | [optional] [default to 0]
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**RegulatoryListChanges**](RegulatoryListChanges.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

