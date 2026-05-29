# MediaMTX.API.Api.SRTApi

All URIs are relative to *http://localhost:9997*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SrtConnsGet**](SRTApi.md#srtconnsget) | **GET** /v3/srtconns/get/{id} | returns a SRT connection. |
| [**SrtConnsKick**](SRTApi.md#srtconnskick) | **POST** /v3/srtconns/kick/{id} | kicks out a SRT connection from the server. |
| [**SrtConnsList**](SRTApi.md#srtconnslist) | **GET** /v3/srtconns/list | returns all SRT connections. |

<a id="srtconnsget"></a>
# **SrtConnsGet**
> SRTConn SrtConnsGet (string id)

returns a SRT connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class SrtConnsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new SRTApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // returns a SRT connection.
                SRTConn result = apiInstance.SrtConnsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SRTApi.SrtConnsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SrtConnsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a SRT connection.
    ApiResponse<SRTConn> response = apiInstance.SrtConnsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SRTApi.SrtConnsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**SRTConn**](SRTConn.md)

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
| **404** | connection not found. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="srtconnskick"></a>
# **SrtConnsKick**
> OK SrtConnsKick (string id)

kicks out a SRT connection from the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class SrtConnsKickExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new SRTApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // kicks out a SRT connection from the server.
                OK result = apiInstance.SrtConnsKick(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SRTApi.SrtConnsKick: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SrtConnsKickWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // kicks out a SRT connection from the server.
    ApiResponse<OK> response = apiInstance.SrtConnsKickWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SRTApi.SrtConnsKickWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**OK**](OK.md)

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
| **404** | connection not found. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="srtconnslist"></a>
# **SrtConnsList**
> SRTConnList SrtConnsList (int page = null, int itemsPerPage = null)

returns all SRT connections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class SrtConnsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new SRTApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all SRT connections.
                SRTConnList result = apiInstance.SrtConnsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SRTApi.SrtConnsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SrtConnsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all SRT connections.
    ApiResponse<SRTConnList> response = apiInstance.SrtConnsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SRTApi.SrtConnsListWithHttpInfo: " + e.Message);
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

[**SRTConnList**](SRTConnList.md)

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

