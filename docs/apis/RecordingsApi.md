# MediaMTX.API.Api.RecordingsApi

All URIs are relative to *http://localhost:9997*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RecordingsDeleteSegment**](RecordingsApi.md#recordingsdeletesegment) | **DELETE** /v3/recordings/deletesegment | deletes a recording segment. |
| [**RecordingsGet**](RecordingsApi.md#recordingsget) | **GET** /v3/recordings/get/{name} | returns recordings of a path. |
| [**RecordingsList**](RecordingsApi.md#recordingslist) | **GET** /v3/recordings/list | returns all recordings, splitted by path. |

<a id="recordingsdeletesegment"></a>
# **RecordingsDeleteSegment**
> OK RecordingsDeleteSegment (string recordingPath, string start)

deletes a recording segment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RecordingsDeleteSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RecordingsApi(config);
            var recordingPath = "recordingPath_example";  // string | path.
            var start = "start_example";  // string | starting date of the segment.

            try
            {
                // deletes a recording segment.
                OK result = apiInstance.RecordingsDeleteSegment(recordingPath, start);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.RecordingsDeleteSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingsDeleteSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // deletes a recording segment.
    ApiResponse<OK> response = apiInstance.RecordingsDeleteSegmentWithHttpInfo(recordingPath, start);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.RecordingsDeleteSegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recordingPath** | **string** | path. |  |
| **start** | **string** | starting date of the segment. |  |

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

<a id="recordingsget"></a>
# **RecordingsGet**
> Recording RecordingsGet (string name)

returns recordings of a path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RecordingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RecordingsApi(config);
            var name = "name_example";  // string | name of the path.

            try
            {
                // returns recordings of a path.
                Recording result = apiInstance.RecordingsGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.RecordingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns recordings of a path.
    ApiResponse<Recording> response = apiInstance.RecordingsGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.RecordingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | name of the path. |  |

### Return type

[**Recording**](Recording.md)

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

<a id="recordingslist"></a>
# **RecordingsList**
> RecordingList RecordingsList (int page = null, int itemsPerPage = null)

returns all recordings, splitted by path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MediaMTX.API.Api;
using MediaMTX.API.Client;
using MediaMTX.API.Model;

namespace Example
{
    public class RecordingsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9997";
            var apiInstance = new RecordingsApi(config);
            var page = 0;  // int | page number. (optional)  (default to 0)
            var itemsPerPage = 100;  // int | items per page. (optional)  (default to 100)

            try
            {
                // returns all recordings, splitted by path.
                RecordingList result = apiInstance.RecordingsList(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.RecordingsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordingsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns all recordings, splitted by path.
    ApiResponse<RecordingList> response = apiInstance.RecordingsListWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.RecordingsListWithHttpInfo: " + e.Message);
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

[**RecordingList**](RecordingList.md)

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

