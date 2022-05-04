# Bludelta.Model.DetectInvoiceResponse
DetectInvoiceResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentResolution** | **int** | Resolution of the original document in dpi. | [optional] 
**DocumentFormat** | **string** | The format of the document. It is either Letter or Receipt | [optional] 
**Language** | **string** | The detected language of the provided invoice document | [optional] 
**Countries** | **string** | The detected countires of the provided invoice document | [optional] 
**InvoiceDetailTypePredictions** | [**List&lt;DetectionResponse&gt;**](DetectionResponse.md) | List of Predictions - One for each predicted invoice detail. | [optional] 
**PredictionGroups** | [**List&lt;DetectionGroupResponse&gt;**](DetectionGroupResponse.md) | List of PredictionGroups - One for each predicted invoice detail&lt;br&gt;e.g. VatGroup, containing predictions for Vat Rate, Net Amount and Vat Amount | [optional] 
**LineItemTable** | [**LineItemTableResponse**](LineItemTableResponse.md) |  | [optional] 
**Sender** | [**ContactResponse**](ContactResponse.md) |  | [optional] 
**Receiver** | [**ContactResponse**](ContactResponse.md) |  | [optional] 
**Contacts** | [**List&lt;ContactResponse&gt;**](ContactResponse.md) | A list containing all contacts that were found on the document - this includes Sender and Receiver | [optional] 
**FormattedResult** | **string** | Special invoice format. (for future use only) | [optional] 
**IsQualityOk** | **bool** | Invoice quality flag. (for future use only) | [optional] 
**OcrWordQuality** | **float** | Measures ratio of word certainty (certainty vs. uncertainty). The higher the value the better | [optional] 
**MeanCharacterConfidenceValue** | **float** | Mean character confidence value. 0 is very confident 100 is very un-confident | [optional] 
**StdDevCharacterConfidenceValue** | **float** | Standard deviation of character confidence value. | [optional] 
**MaxCharacterConfidenceValue** | **int** | Max character confidence value. 0 is very confident 100 is very incofident | [optional] 
**OcrResult** | **string** | OCR-result as json string | [optional] 
**ResultPdf** | **string** | Result pdf-document with marked predictions. (encoded as base64 string) | [optional] 
**OcrPageImages** | **List&lt;string&gt;** | List of OCR-page images (encoded as base64 string). | [optional] 
**DocumentText** | **string** | Plain text of the document as detected by the OCR. | [optional] 
**InvoiceState** | **int** | Describes the state of the processed invoice. 0 &#x3D; Ok | [optional] 
**Confidence** | **float** | Describes the confidence that the invoice can be auto-processed without human validation. (-1 &#x3D; unknown, 0 &#x3D; validate manually, 1 &#x3D; autoprocess) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

