# chemApiClient.Api.SubstancesApi

All URIs are relative to *https://sandbox.chemadvisor.io/chem/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRelatedSubstances**](SubstancesApi.md#getrelatedsubstances) | **GET** /substances/{substance_id}/related_substances | Links to related substances
[**GetSubstance**](SubstancesApi.md#getsubstance) | **GET** /substances/{substance_id} | Find substance by ID
[**GetSubstanceIdentifiers**](SubstancesApi.md#getsubstanceidentifiers) | **GET** /substances/{substance_id}/identifiers | A substance&#39;s public identifiers
[**GetSubstanceInventoryHits**](SubstancesApi.md#getsubstanceinventoryhits) | **GET** /substances/{substance_id}/inventories | A substance&#39;s inventory status
[**GetSubstanceListHits**](SubstancesApi.md#getsubstancelisthits) | **GET** /substances/{substance_id}/regulatory_lists | LOLI lists containing this substance
[**GetSubstanceNames**](SubstancesApi.md#getsubstancenames) | **GET** /substances/{substance_id}/names | Get a Specific Substance&#39;s names
[**GetSubstances**](SubstancesApi.md#getsubstances) | **GET** /substances | All Substances


<a name="getrelatedsubstances"></a>
# **GetRelatedSubstances**
> RelatedSubstances GetRelatedSubstances (string substanceId, string appKey = null, string appId = null)

Links to related substances

Returns a collection of links to related substances

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetRelatedSubstancesExample
    {
        public void main()
        {
            
            var apiInstance = new SubstancesApi();
            var substanceId = substanceId_example;  // string | Substance id
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Links to related substances
                RelatedSubstances result = apiInstance.GetRelatedSubstances(substanceId, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstancesApi.GetRelatedSubstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substanceId** | **string**| Substance id | 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**RelatedSubstances**](RelatedSubstances.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstance"></a>
# **GetSubstance**
> Substance GetSubstance (string substanceId, string appKey = null, string appId = null)

Find substance by ID

Returns a single substance

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetSubstanceExample
    {
        public void main()
        {
            
            var apiInstance = new SubstancesApi();
            var substanceId = substanceId_example;  // string | Substance id
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Find substance by ID
                Substance result = apiInstance.GetSubstance(substanceId, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstancesApi.GetSubstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substanceId** | **string**| Substance id | 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**Substance**](Substance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstanceidentifiers"></a>
# **GetSubstanceIdentifiers**
> Identifiers GetSubstanceIdentifiers (string substanceId, string appKey = null, string appId = null)

A substance's public identifiers

Returns a collection of public identifiers for a substance.

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetSubstanceIdentifiersExample
    {
        public void main()
        {
            
            var apiInstance = new SubstancesApi();
            var substanceId = substanceId_example;  // string | Substance id
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // A substance's public identifiers
                Identifiers result = apiInstance.GetSubstanceIdentifiers(substanceId, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstancesApi.GetSubstanceIdentifiers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substanceId** | **string**| Substance id | 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**Identifiers**](Identifiers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstanceinventoryhits"></a>
# **GetSubstanceInventoryHits**
> Inventories GetSubstanceInventoryHits (string substanceId, string appKey = null, string appId = null)

A substance's inventory status

Returns a collection of inventory objects for a substance

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetSubstanceInventoryHitsExample
    {
        public void main()
        {
            
            var apiInstance = new SubstancesApi();
            var substanceId = substanceId_example;  // string | Substance id
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // A substance's inventory status
                Inventories result = apiInstance.GetSubstanceInventoryHits(substanceId, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstancesApi.GetSubstanceInventoryHits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substanceId** | **string**| Substance id | 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**Inventories**](Inventories.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstancelisthits"></a>
# **GetSubstanceListHits**
> RegulatoryLists GetSubstanceListHits (string substanceId, int? limit = null, int? offset = null, string q = null, string appKey = null, string appId = null)

LOLI lists containing this substance

Returns a paginated collection of list objects for lists contain this substance

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetSubstanceListHitsExample
    {
        public void main()
        {
            
            var apiInstance = new SubstancesApi();
            var substanceId = substanceId_example;  // string | Substance ID
            var limit = 56;  // int? | Number of items to retrieve (optional)  (default to 10)
            var offset = 56;  // int? | Offset of the first item returned (optional)  (default to 0)
            var q = q_example;  // string | Search filter is based on the syntax used for find in mongoDB.  For more information, visit <a href=\"https://developer.chemadvisor.io/docs/integrate/codeExamplesQ\" target=\"blank\">https://developer.chemadvisor.io/docs/integrate/codeExamplesQ</a>. (optional) 
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // LOLI lists containing this substance
                RegulatoryLists result = apiInstance.GetSubstanceListHits(substanceId, limit, offset, q, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstancesApi.GetSubstanceListHits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substanceId** | **string**| Substance ID | 
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

<a name="getsubstancenames"></a>
# **GetSubstanceNames**
> SubstanceNames GetSubstanceNames (string substanceId, string appKey = null, string appId = null)

Get a Specific Substance's names

Gets a collection of **name** objects Required path param of 'substance_id' 

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetSubstanceNamesExample
    {
        public void main()
        {
            
            var apiInstance = new SubstancesApi();
            var substanceId = substanceId_example;  // string | Identifier for the substance
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // Get a Specific Substance's names
                SubstanceNames result = apiInstance.GetSubstanceNames(substanceId, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstancesApi.GetSubstanceNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substanceId** | **string**| Identifier for the substance | 
 **appKey** | **string**|  | [optional] 
 **appId** | **string**|  | [optional] 

### Return type

[**SubstanceNames**](SubstanceNames.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstances"></a>
# **GetSubstances**
> Substances GetSubstances (int? limit = null, int? offset = null, string q = null, string appKey = null, string appId = null)

All Substances

A paginated collection of substances

### Example
```csharp
using System;
using System.Diagnostics;
using chemApiClient.Api;
using chemApiClient.Client;
using chemApiClient.Model;

namespace Example
{
    public class GetSubstancesExample
    {
        public void main()
        {
            
            var apiInstance = new SubstancesApi();
            var limit = 56;  // int? | Number of items to retrieve (optional)  (default to 10)
            var offset = 56;  // int? | Offset of the first item returned (optional)  (default to 0)
            var q = q_example;  // string | Search filter is based on the syntax used for find in mongoDB.  For more information, visit <a href=\"https://developer.chemadvisor.io/docs/integrate/codeExamplesQ\" target=\"blank\">https://developer.chemadvisor.io/docs/integrate/codeExamplesQ</a>. (optional) 
            var appKey = appKey_example;  // string |  (optional) 
            var appId = appId_example;  // string |  (optional) 

            try
            {
                // All Substances
                Substances result = apiInstance.GetSubstances(limit, offset, q, appKey, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstancesApi.GetSubstances: " + e.Message );
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

[**Substances**](Substances.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

