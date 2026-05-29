# MediaMTX.API.Api.PathsApi

All URIs are relative to *http://localhost:9997*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PathsGet**](PathsApi.md#pathsget) | **GET** /v3/paths/get/{name} | returns a path. |
| [**PathsList**](PathsApi.md#pathslist) | **GET** /v3/paths/list | returns all paths. |

<a id="pathsget"></a>
# **PathsGet**
> Path PathsGet (string name)

returns a path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class PathsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new PathsApi(config);
            var name = "name_example";  // string | name of the path.

            try
            {
                // returns a path.
                Path result = apiInstance.PathsGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PathsApi.PathsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PathsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a path.
    ApiResponse<Path> response = apiInstance.PathsGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PathsApi.PathsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | name of the path. |  |

### Return type

[**Path**](Path.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the request was successful. |  -  |
| **400** | invalid request. |  -  |
| **404** | path not found. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pathslist"></a>
# **PathsList**
> PathList PathsList (int page = null, int itemsPerPage = null)

returns all paths.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class PathsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new PathsApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all paths.
                PathList result = apiInstance.PathsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PathsApi.PathsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PathsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all paths.
    ApiResponse<PathList> response = apiInstance.PathsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PathsApi.PathsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | page number. | [optional] [default to 0] |
| **itemsPerPage** | **int** | items per page. | [optional] [default to 100] |

### Return type

[**PathList**](PathList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the request was successful. |  -  |
| **400** | invalid request. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

