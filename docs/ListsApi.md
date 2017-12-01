# chemApiClient.Api.ListsApi

All URIs are relative to *https://sandbox.chemadvisor.io/chem/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEntries**](ListsApi.md#getentries) | **GET** /regulatory_lists/{regulatory_list_id}/entries | Return a paginated collection of entries for a single Regulatory List
[**GetEntry**](ListsApi.md#getentry) | **GET** /regulatory_lists/{regulatory_list_id}/entries/{substance_id} | Find the entries for a specific Substance on List
[**GetList**](ListsApi.md#getlist) | **GET** /regulatory_lists/{regulatory_list_id} | Find a Regulatory List by ID
[**GetLists**](ListsApi.md#getlists) | **GET** /regulatory_lists | All Lists


<a name="getentries"></a>
# **GetEntries**
> Entries GetEntries (string regulatoryListId, int? limit = null, int? offset = null, string q = null, string appKey = null, string appId = null)

Return a paginated collection of entries for a single Regulatory List



### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetEntriesExample
    {
        public void main()
        {
            
            var apiInstance = new ListsApi();
            var regulatoryListId = regulatoryListId_example;  // string | Regulatory List ID
            var limit = 56;  // int? | Number of items to retrieve (optional)  (default to 10)
            var offset = 56;  // int? | Offset of the first item returned (optional)  (default to 0)
            var q = q_example;  // string | Search filter, for more information <http://chemadvisor.io/docs/api/v2/filtering.html> (optional) 
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Return a paginated collection of entries for a single Regulatory List
                Entries result = apiInstance.GetEntries(regulatoryListId, limit, offset, q, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.GetEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regulatoryListId** | **string**| Regulatory List ID | 
 **limit** | **int?**| Number of items to retrieve | [optional] [default to 10]
 **offset** | **int?**| Offset of the first item returned | [optional] [default to 0]
 **q** | **string**| Search filter, for more information &lt;http://chemadvisor.io/docs/api/v2/filtering.html&gt; | [optional] 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**Entries**](Entries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentry"></a>
# **GetEntry**
> Entry GetEntry (string regulatoryListId, string substanceId, string appKey = null, string appId = null)

Find the entries for a specific Substance on List

Returns a collection of entries for a single Substance from a single Regulatory List

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetEntryExample
    {
        public void main()
        {
            
            var apiInstance = new ListsApi();
            var regulatoryListId = regulatoryListId_example;  // string | Regulatory List ID
            var substanceId = substanceId_example;  // string | Substance ID
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Find the entries for a specific Substance on List
                Entry result = apiInstance.GetEntry(regulatoryListId, substanceId, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.GetEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regulatoryListId** | **string**| Regulatory List ID | 
 **substanceId** | **string**| Substance ID | 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**Entry**](Entry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlist"></a>
# **GetList**
> RegulatoryList GetList (string regulatoryListId, string appKey = null, string appId = null)

Find a Regulatory List by ID

Returns a single Regulatory List

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetListExample
    {
        public void main()
        {
            
            var apiInstance = new ListsApi();
            var regulatoryListId = regulatoryListId_example;  // string | Regulatory List ID
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Find a Regulatory List by ID
                RegulatoryList result = apiInstance.GetList(regulatoryListId, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.GetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regulatoryListId** | **string**| Regulatory List ID | 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**RegulatoryList**](RegulatoryList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlists"></a>
# **GetLists**
> RegulatoryLists GetLists (int? limit = null, int? offset = null, string q = null, string appKey = null, string appId = null)

All Lists

A paginated collection of Regulatory Lists

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetListsExample
    {
        public void main()
        {
            
            var apiInstance = new ListsApi();
            var limit = 56;  // int? | Number of items to retrieve (optional)  (default to 10)
            var offset = 56;  // int? | Offset of the first item returned (optional)  (default to 0)
            var q = q_example;  // string | Search filter is based on the syntax used for find in mongoDB.  For more information, visit <a href=\"https://developer.chemadvisor.io/docs/integrate/codeExamplesQ\" target=\"blank\">https://developer.chemadvisor.io/docs/integrate/codeExamplesQ</a>. (optional) 
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // All Lists
                RegulatoryLists result = apiInstance.GetLists(limit, offset, q, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.GetLists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Number of items to retrieve | [optional] [default to 10]
 **offset** | **int?**| Offset of the first item returned | [optional] [default to 0]
 **q** | **string**| Search filter is based on the syntax used for find in mongoDB.  For more information, visit &lt;a href&#x3D;\&quot;https://developer.chemadvisor.io/docs/integrate/codeExamplesQ\&quot; target&#x3D;\&quot;blank\&quot;&gt;https://developer.chemadvisor.io/docs/integrate/codeExamplesQ&lt;/a&gt;. | [optional] 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**RegulatoryLists**](RegulatoryLists.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

