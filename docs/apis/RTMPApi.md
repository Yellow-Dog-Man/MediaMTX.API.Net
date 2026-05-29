# MediaMTX.API.Api.RTMPApi

All URIs are relative to *http://localhost:9997*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RtmpConnectionsGet**](RTMPApi.md#rtmpconnectionsget) | **GET** /v3/rtmpconns/get/{id} | returns a RTMP connection. |
| [**RtmpConnsKick**](RTMPApi.md#rtmpconnskick) | **POST** /v3/rtmpconns/kick/{id} | kicks out a RTMP connection from the server. |
| [**RtmpConnsList**](RTMPApi.md#rtmpconnslist) | **GET** /v3/rtmpconns/list | returns all RTMP connections. |
| [**RtmpsConnectionsGet**](RTMPApi.md#rtmpsconnectionsget) | **GET** /v3/rtmpsconns/get/{id} | returns a RTMPS connection. |
| [**RtmpsConnsKick**](RTMPApi.md#rtmpsconnskick) | **POST** /v3/rtmpsconns/kick/{id} | kicks out a RTMPS connection from the server. |
| [**RtmpsConnsList**](RTMPApi.md#rtmpsconnslist) | **GET** /v3/rtmpsconns/list | returns all RTMPS connections. |

<a id="rtmpconnectionsget"></a>
# **RtmpConnectionsGet**
> RTMPConn RtmpConnectionsGet (string id)

returns a RTMP connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtmpConnectionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTMPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // returns a RTMP connection.
                RTMPConn result = apiInstance.RtmpConnectionsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTMPApi.RtmpConnectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtmpConnectionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a RTMP connection.
    ApiResponse<RTMPConn> response = apiInstance.RtmpConnectionsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTMPApi.RtmpConnectionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**RTMPConn**](RTMPConn.md)

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

<a id="rtmpconnskick"></a>
# **RtmpConnsKick**
> OK RtmpConnsKick (string id)

kicks out a RTMP connection from the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtmpConnsKickExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTMPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // kicks out a RTMP connection from the server.
                OK result = apiInstance.RtmpConnsKick(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTMPApi.RtmpConnsKick: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtmpConnsKickWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // kicks out a RTMP connection from the server.
    ApiResponse<OK> response = apiInstance.RtmpConnsKickWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTMPApi.RtmpConnsKickWithHttpInfo: " + e.Message);
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

<a id="rtmpconnslist"></a>
# **RtmpConnsList**
> RTMPConnList RtmpConnsList (int page = null, int itemsPerPage = null)

returns all RTMP connections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtmpConnsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTMPApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all RTMP connections.
                RTMPConnList result = apiInstance.RtmpConnsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTMPApi.RtmpConnsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtmpConnsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all RTMP connections.
    ApiResponse<RTMPConnList> response = apiInstance.RtmpConnsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTMPApi.RtmpConnsListWithHttpInfo: " + e.Message);
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

[**RTMPConnList**](RTMPConnList.md)

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

<a id="rtmpsconnectionsget"></a>
# **RtmpsConnectionsGet**
> RTMPConn RtmpsConnectionsGet (string id)

returns a RTMPS connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtmpsConnectionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTMPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // returns a RTMPS connection.
                RTMPConn result = apiInstance.RtmpsConnectionsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTMPApi.RtmpsConnectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtmpsConnectionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a RTMPS connection.
    ApiResponse<RTMPConn> response = apiInstance.RtmpsConnectionsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTMPApi.RtmpsConnectionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**RTMPConn**](RTMPConn.md)

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

<a id="rtmpsconnskick"></a>
# **RtmpsConnsKick**
> OK RtmpsConnsKick (string id)

kicks out a RTMPS connection from the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtmpsConnsKickExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTMPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // kicks out a RTMPS connection from the server.
                OK result = apiInstance.RtmpsConnsKick(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTMPApi.RtmpsConnsKick: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtmpsConnsKickWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // kicks out a RTMPS connection from the server.
    ApiResponse<OK> response = apiInstance.RtmpsConnsKickWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTMPApi.RtmpsConnsKickWithHttpInfo: " + e.Message);
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

<a id="rtmpsconnslist"></a>
# **RtmpsConnsList**
> RTMPConnList RtmpsConnsList (int page = null, int itemsPerPage = null)

returns all RTMPS connections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtmpsConnsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTMPApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all RTMPS connections.
                RTMPConnList result = apiInstance.RtmpsConnsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTMPApi.RtmpsConnsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtmpsConnsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all RTMPS connections.
    ApiResponse<RTMPConnList> response = apiInstance.RtmpsConnsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTMPApi.RtmpsConnsListWithHttpInfo: " + e.Message);
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

[**RTMPConnList**](RTMPConnList.md)

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

