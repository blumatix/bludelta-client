# Bludelta.Api.InvoicedetailApi

All URIs are relative to *http://localhost:8090*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DetectInvoiceRequestdetectPost**](InvoicedetailApi.md#detectinvoicerequestdetectpost) | **POST** /invoicedetail/detect | Extracts invoice features of a provided invoice.


<a name="detectinvoicerequestdetectpost"></a>
# **DetectInvoiceRequestdetectPost**
> DetectInvoiceResponse DetectInvoiceRequestdetectPost (string accept, long? filter = null, string invoice = null, int? format = null, bool? createResultPdf = null, bool? addOcrResult = null, bool? addOcrPageImages = null, bool? addDocumentText = null, string languages = null)

Extracts invoice features of a provided invoice.

Extracts invoice features of a provided invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bludelta.Api;
using Bludelta.Client;
using Bludelta.Model;

namespace Example
{
    public class DetectInvoiceRequestdetectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            var apiInstance = new InvoicedetailApi(config);
            var accept = accept_example;  // string | Accept Header
            var filter = 789;  // long? | Filter for Invoice details that shall be predicted<br>flag 'None' will return all available Invoice details for your subscription,<br>else define the filter by providing a bitmask for the Invoice details that shall be predicted.<br>e.g. Filter = GrandTotalAmount | Ibans.<br><br>Filters:<br><ul><li>None:                      0</li><li>DeliveryDate:              8</li><li>GrandTotalAmount:         16</li><li>InvoiceDate:              64</li><li>InvoiceId:              1024</li><li>DocumentType:           8192</li><li>Ibans:                 16384</li><li>InvoiceCurrency:      524288</li><li>CustomerId:          2097152</li><li>UstIds:              8388608</li><li>SenderOrderId:      16777216</li><li>ReceiverOrderId:    33554432</li><li>SenderOrderDate:    67108864</li><li>ReceiverOrderDate: 134217728</li><li>VatGroup:          536870912</li></ul> (optional) 
            var invoice = invoice_example;  // string | Invoice (encoded as base64 string) - accepted formats: PDF, JPG, PNG, GIF, TIFF (optional) 
            var format = 56;  // int? | Special Invoice format.<br>for future use only<ul><li>None: 0</li><li>EbInterface: 1</li></ul> (optional) 
            var createResultPdf = true;  // bool? | If this flag is set, the response will contain the sent invoice as pdf-document with marked predictions. (optional) 
            var addOcrResult = true;  // bool? | If this flag is set, the response will contain the OCR-Result as json string. (optional) 
            var addOcrPageImages = true;  // bool? | If this flag is set, the response will contain the images of the OCR-Result pages as list of Base64 encoded strings. (optional) 
            var addDocumentText = true;  // bool? | If this flag is set, the response will contain the plain text of the document as detected by the OCR. (optional) 
            var languages = languages_example;  // string | Restrict invoice languages to a given set provided as a comma separates string of languages. (optional) 

            try
            {
                // Extracts invoice features of a provided invoice.
                DetectInvoiceResponse result = apiInstance.DetectInvoiceRequestdetectPost(accept, filter, invoice, format, createResultPdf, addOcrResult, addOcrPageImages, addDocumentText, languages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicedetailApi.DetectInvoiceRequestdetectPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| Accept Header | 
 **filter** | **long?**| Filter for Invoice details that shall be predicted&lt;br&gt;flag &#39;None&#39; will return all available Invoice details for your subscription,&lt;br&gt;else define the filter by providing a bitmask for the Invoice details that shall be predicted.&lt;br&gt;e.g. Filter &#x3D; GrandTotalAmount | Ibans.&lt;br&gt;&lt;br&gt;Filters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;None:                      0&lt;/li&gt;&lt;li&gt;DeliveryDate:              8&lt;/li&gt;&lt;li&gt;GrandTotalAmount:         16&lt;/li&gt;&lt;li&gt;InvoiceDate:              64&lt;/li&gt;&lt;li&gt;InvoiceId:              1024&lt;/li&gt;&lt;li&gt;DocumentType:           8192&lt;/li&gt;&lt;li&gt;Ibans:                 16384&lt;/li&gt;&lt;li&gt;InvoiceCurrency:      524288&lt;/li&gt;&lt;li&gt;CustomerId:          2097152&lt;/li&gt;&lt;li&gt;UstIds:              8388608&lt;/li&gt;&lt;li&gt;SenderOrderId:      16777216&lt;/li&gt;&lt;li&gt;ReceiverOrderId:    33554432&lt;/li&gt;&lt;li&gt;SenderOrderDate:    67108864&lt;/li&gt;&lt;li&gt;ReceiverOrderDate: 134217728&lt;/li&gt;&lt;li&gt;VatGroup:          536870912&lt;/li&gt;&lt;/ul&gt; | [optional] 
 **invoice** | **string**| Invoice (encoded as base64 string) - accepted formats: PDF, JPG, PNG, GIF, TIFF | [optional] 
 **format** | **int?**| Special Invoice format.&lt;br&gt;for future use only&lt;ul&gt;&lt;li&gt;None: 0&lt;/li&gt;&lt;li&gt;EbInterface: 1&lt;/li&gt;&lt;/ul&gt; | [optional] 
 **createResultPdf** | **bool?**| If this flag is set, the response will contain the sent invoice as pdf-document with marked predictions. | [optional] 
 **addOcrResult** | **bool?**| If this flag is set, the response will contain the OCR-Result as json string. | [optional] 
 **addOcrPageImages** | **bool?**| If this flag is set, the response will contain the images of the OCR-Result pages as list of Base64 encoded strings. | [optional] 
 **addDocumentText** | **bool?**| If this flag is set, the response will contain the plain text of the document as detected by the OCR. | [optional] 
 **languages** | **string**| Restrict invoice languages to a given set provided as a comma separates string of languages. | [optional] 

### Return type

[**DetectInvoiceResponse**](DetectInvoiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service call successfully finished |  -  |
| **400** | Invoice format error |  -  |
| **401** | Unauthorized. Invalid ApiKey (or invalid ApiIdentifier) |  -  |
| **403** | Customer is not allowed to make any predictions |  -  |
| **500** | Oops, something broke |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

