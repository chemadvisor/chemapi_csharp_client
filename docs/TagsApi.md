# chemApiClient.Api.TagsApi

All URIs are relative to *https://sandbox.chemadvisor.io/chem/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTags**](TagsApi.md#gettags) | **GET** /tags | Get All Available Tags


<a name="gettags"></a>
# **GetTags**
> Tags GetTags (string q = null, string appKey = null, string appId = null)

Get All Available Tags

Gets a collection of **tag** objects. 

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetTagsExample
    {
        public void main()
        {
            
            var apiInstance = new TagsApi();
            var q = q_example;  // string | Search filter is based on the syntax used for find in mongoDB.  For more information, visit <a href=\"https://developer.chemadvisor.io/docs/integrate/codeExamplesQ\" target=\"blank\">https://developer.chemadvisor.io/docs/integrate/codeExamplesQ</a>. (optional) 
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Get All Available Tags
                Tags result = apiInstance.GetTags(q, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.GetTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Search filter is based on the syntax used for find in mongoDB.  For more information, visit &lt;a href&#x3D;\&quot;https://developer.chemadvisor.io/docs/integrate/codeExamplesQ\&quot; target&#x3D;\&quot;blank\&quot;&gt;https://developer.chemadvisor.io/docs/integrate/codeExamplesQ&lt;/a&gt;. | [optional] 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**Tags**](Tags.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

