# Bludelta.Model.DetectInvoiceRequest
Extracts invoice features of a provided invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | **long** | Filter for Invoice details that shall be predicted&lt;br&gt;flag &#39;None&#39; will return all available Invoice details for your subscription,&lt;br&gt;else define the filter by providing a bitmask for the Invoice details that shall be predicted.&lt;br&gt;e.g. Filter &#x3D; GrandTotalAmount | Ibans.&lt;br&gt;&lt;br&gt;Filters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;None:                      0&lt;/li&gt;&lt;li&gt;DeliveryDate:              8&lt;/li&gt;&lt;li&gt;GrandTotalAmount:         16&lt;/li&gt;&lt;li&gt;InvoiceDate:              64&lt;/li&gt;&lt;li&gt;InvoiceId:              1024&lt;/li&gt;&lt;li&gt;DocumentType:           8192&lt;/li&gt;&lt;li&gt;Ibans:                 16384&lt;/li&gt;&lt;li&gt;InvoiceCurrency:      524288&lt;/li&gt;&lt;li&gt;CustomerId:          2097152&lt;/li&gt;&lt;li&gt;UstIds:              8388608&lt;/li&gt;&lt;li&gt;SenderOrderId:      16777216&lt;/li&gt;&lt;li&gt;ReceiverOrderId:    33554432&lt;/li&gt;&lt;li&gt;SenderOrderDate:    67108864&lt;/li&gt;&lt;li&gt;ReceiverOrderDate: 134217728&lt;/li&gt;&lt;li&gt;VatGroup:          536870912&lt;/li&gt;&lt;/ul&gt; | [optional] 
**Invoice** | **string** | Invoice (encoded as base64 string) - accepted formats: PDF, JPG, PNG, GIF, TIFF | [optional] 
**Format** | **int** | Special Invoice format.&lt;br&gt;for future use only&lt;ul&gt;&lt;li&gt;None: 0&lt;/li&gt;&lt;li&gt;EbInterface: 1&lt;/li&gt;&lt;/ul&gt; | [optional] 
**PropertyStore** | **Dictionary&lt;string, string&gt;** | Dictionary&lt;String,String&gt; | [optional] 
**CreateResultPdf** | **bool** | If this flag is set, the response will contain the sent invoice as pdf-document with marked predictions. | [optional] 
**AddOcrResult** | **bool** | If this flag is set, the response will contain the OCR-Result as json string. | [optional] 
**AddDocumentText** | **bool** | If this flag is set, the response will contain the plain text of the document as detected by the OCR. | [optional] 
**Languages** | **string** | Restrict invoice languages to a given set provided as a comma separates string of languages. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

