# chemApiClient.Api.ReleasesApi

All URIs are relative to *https://sandbox.chemadvisor.io/chem/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetReleases**](ReleasesApi.md#getreleases) | **GET** /releases | All Releases


<a name="getreleases"></a>
# **GetReleases**
> Releases GetReleases (int? limit = null, int? offset = null, string q = null, string appKey = null, string appId = null)

All Releases

A paginated collection of Releases

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetReleasesExample
    {
        public void main()
        {
            
            var apiInstance = new ReleasesApi();
            var limit = 56;  // int? | Number of items to retrieve (optional)  (default to 10)
            var offset = 56;  // int? | Offset of the first item returned (optional)  (default to 0)
            var q = q_example;  // string | Search filter is based on the syntax used for find in mongoDB.  For more information, visit <a href=\"https://developer.chemadvisor.io/docs/integrate/codeExamplesQ\" target=\"blank\">https://developer.chemadvisor.io/docs/integrate/codeExamplesQ</a>. (optional) 
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // All Releases
                Releases result = apiInstance.GetReleases(limit, offset, q, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReleasesApi.GetReleases: " + e.Message );
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

[**Releases**](Releases.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

