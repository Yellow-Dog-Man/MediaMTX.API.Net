# MediaMTX.API.Api.RTSPApi

All URIs are relative to *http://localhost:9997*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RtspConnsGet**](RTSPApi.md#rtspconnsget) | **GET** /v3/rtspconns/get/{id} | returns a RTSP connection. |
| [**RtspConnsList**](RTSPApi.md#rtspconnslist) | **GET** /v3/rtspconns/list | returns all RTSP connections. |
| [**RtspSessionsGet**](RTSPApi.md#rtspsessionsget) | **GET** /v3/rtspsessions/get/{id} | returns a RTSP session. |
| [**RtspSessionsKick**](RTSPApi.md#rtspsessionskick) | **POST** /v3/rtspsessions/kick/{id} | kicks out a RTSP session from the server. |
| [**RtspSessionsList**](RTSPApi.md#rtspsessionslist) | **GET** /v3/rtspsessions/list | returns all RTSP sessions. |
| [**RtspsConnsGet**](RTSPApi.md#rtspsconnsget) | **GET** /v3/rtspsconns/get/{id} | returns a RTSPS connection. |
| [**RtspsConnsList**](RTSPApi.md#rtspsconnslist) | **GET** /v3/rtspsconns/list | returns all RTSPS connections. |
| [**RtspsSessionsGet**](RTSPApi.md#rtspssessionsget) | **GET** /v3/rtspssessions/get/{id} | returns a RTSPS session. |
| [**RtspsSessionsKick**](RTSPApi.md#rtspssessionskick) | **POST** /v3/rtspssessions/kick/{id} | kicks out a RTSPS session from the server. |
| [**RtspsSessionsList**](RTSPApi.md#rtspssessionslist) | **GET** /v3/rtspssessions/list | returns all RTSPS sessions. |

<a id="rtspconnsget"></a>
# **RtspConnsGet**
> RTSPConn RtspConnsGet (string id)

returns a RTSP connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspConnsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // returns a RTSP connection.
                RTSPConn result = apiInstance.RtspConnsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspConnsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspConnsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a RTSP connection.
    ApiResponse<RTSPConn> response = apiInstance.RtspConnsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspConnsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**RTSPConn**](RTSPConn.md)

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

<a id="rtspconnslist"></a>
# **RtspConnsList**
> RTSPConnList RtspConnsList (int page = null, int itemsPerPage = null)

returns all RTSP connections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspConnsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all RTSP connections.
                RTSPConnList result = apiInstance.RtspConnsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspConnsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspConnsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all RTSP connections.
    ApiResponse<RTSPConnList> response = apiInstance.RtspConnsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspConnsListWithHttpInfo: " + e.Message);
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

[**RTSPConnList**](RTSPConnList.md)

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

<a id="rtspsessionsget"></a>
# **RtspSessionsGet**
> RTSPSession RtspSessionsGet (string id)

returns a RTSP session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspSessionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // returns a RTSP session.
                RTSPSession result = apiInstance.RtspSessionsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspSessionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspSessionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a RTSP session.
    ApiResponse<RTSPSession> response = apiInstance.RtspSessionsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspSessionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**RTSPSession**](RTSPSession.md)

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
| **404** | session not found. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rtspsessionskick"></a>
# **RtspSessionsKick**
> OK RtspSessionsKick (string id)

kicks out a RTSP session from the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspSessionsKickExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var id = "id_example";  // string | ID of the session.

            try
            {
                // kicks out a RTSP session from the server.
                OK result = apiInstance.RtspSessionsKick(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspSessionsKick: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspSessionsKickWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // kicks out a RTSP session from the server.
    ApiResponse<OK> response = apiInstance.RtspSessionsKickWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspSessionsKickWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the session. |  |

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
| **404** | session not found. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rtspsessionslist"></a>
# **RtspSessionsList**
> RTSPSessionList RtspSessionsList (int page = null, int itemsPerPage = null)

returns all RTSP sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspSessionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all RTSP sessions.
                RTSPSessionList result = apiInstance.RtspSessionsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspSessionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspSessionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all RTSP sessions.
    ApiResponse<RTSPSessionList> response = apiInstance.RtspSessionsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspSessionsListWithHttpInfo: " + e.Message);
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

[**RTSPSessionList**](RTSPSessionList.md)

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

<a id="rtspsconnsget"></a>
# **RtspsConnsGet**
> RTSPConn RtspsConnsGet (string id)

returns a RTSPS connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspsConnsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // returns a RTSPS connection.
                RTSPConn result = apiInstance.RtspsConnsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspsConnsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspsConnsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a RTSPS connection.
    ApiResponse<RTSPConn> response = apiInstance.RtspsConnsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspsConnsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**RTSPConn**](RTSPConn.md)

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

<a id="rtspsconnslist"></a>
# **RtspsConnsList**
> RTSPConnList RtspsConnsList (int page = null, int itemsPerPage = null)

returns all RTSPS connections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspsConnsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all RTSPS connections.
                RTSPConnList result = apiInstance.RtspsConnsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspsConnsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspsConnsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all RTSPS connections.
    ApiResponse<RTSPConnList> response = apiInstance.RtspsConnsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspsConnsListWithHttpInfo: " + e.Message);
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

[**RTSPConnList**](RTSPConnList.md)

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

<a id="rtspssessionsget"></a>
# **RtspsSessionsGet**
> RTSPSession RtspsSessionsGet (string id)

returns a RTSPS session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspsSessionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var id = "id_example";  // string | ID of the connection.

            try
            {
                // returns a RTSPS session.
                RTSPSession result = apiInstance.RtspsSessionsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspsSessionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspsSessionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a RTSPS session.
    ApiResponse<RTSPSession> response = apiInstance.RtspsSessionsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspsSessionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the connection. |  |

### Return type

[**RTSPSession**](RTSPSession.md)

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
| **404** | session not found. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rtspssessionskick"></a>
# **RtspsSessionsKick**
> OK RtspsSessionsKick (string id)

kicks out a RTSPS session from the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspsSessionsKickExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var id = "id_example";  // string | ID of the session.

            try
            {
                // kicks out a RTSPS session from the server.
                OK result = apiInstance.RtspsSessionsKick(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspsSessionsKick: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspsSessionsKickWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // kicks out a RTSPS session from the server.
    ApiResponse<OK> response = apiInstance.RtspsSessionsKickWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspsSessionsKickWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the session. |  |

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
| **404** | session not found. |  -  |
| **500** | server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rtspssessionslist"></a>
# **RtspsSessionsList**
> RTSPSessionList RtspsSessionsList (int page = null, int itemsPerPage = null)

returns all RTSPS sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RtspsSessionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RTSPApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all RTSPS sessions.
                RTSPSessionList result = apiInstance.RtspsSessionsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RTSPApi.RtspsSessionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RtspsSessionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all RTSPS sessions.
    ApiResponse<RTSPSessionList> response = apiInstance.RtspsSessionsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RTSPApi.RtspsSessionsListWithHttpInfo: " + e.Message);
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

[**RTSPSessionList**](RTSPSessionList.md)

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

