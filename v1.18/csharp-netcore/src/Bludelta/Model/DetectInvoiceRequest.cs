/*
 * Blumatix.Capture.Webservice.Client.Selfhosted
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.9
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Bludelta.Client.OpenAPIDateConverter;

namespace Bludelta.Model
{
    /// <summary>
    /// Extracts invoice features of a provided invoice.
    /// </summary>
    [DataContract(Name = "DetectInvoiceRequest")]
    public partial class DetectInvoiceRequest : IEquatable<DetectInvoiceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectInvoiceRequest" /> class.
        /// </summary>
        /// <param name="filter">Filter for Invoice details that shall be predicted&lt;br&gt;flag &#39;None&#39; will return all available Invoice details for your subscription,&lt;br&gt;else define the filter by providing a bitmask for the Invoice details that shall be predicted.&lt;br&gt;e.g. Filter &#x3D; GrandTotalAmount | Ibans.&lt;br&gt;&lt;br&gt;Filters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;None:                      0&lt;/li&gt;&lt;li&gt;DeliveryDate:              8&lt;/li&gt;&lt;li&gt;GrandTotalAmount:         16&lt;/li&gt;&lt;li&gt;InvoiceDate:              64&lt;/li&gt;&lt;li&gt;InvoiceId:              1024&lt;/li&gt;&lt;li&gt;DocumentType:           8192&lt;/li&gt;&lt;li&gt;Ibans:                 16384&lt;/li&gt;&lt;li&gt;InvoiceCurrency:      524288&lt;/li&gt;&lt;li&gt;CustomerId:          2097152&lt;/li&gt;&lt;li&gt;UstIds:              8388608&lt;/li&gt;&lt;li&gt;SenderOrderId:      16777216&lt;/li&gt;&lt;li&gt;ReceiverOrderId:    33554432&lt;/li&gt;&lt;li&gt;SenderOrderDate:    67108864&lt;/li&gt;&lt;li&gt;ReceiverOrderDate: 134217728&lt;/li&gt;&lt;li&gt;VatGroup:          536870912&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="invoice">Invoice (encoded as base64 string) - accepted formats: PDF, JPG, PNG, GIF, TIFF.</param>
        /// <param name="format">Special Invoice format.&lt;br&gt;for future use only&lt;ul&gt;&lt;li&gt;None: 0&lt;/li&gt;&lt;li&gt;EbInterface: 1&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="propertyStore">Dictionary&lt;String,String&gt;.</param>
        /// <param name="createResultPdf">If this flag is set, the response will contain the sent invoice as pdf-document with marked predictions..</param>
        /// <param name="addOcrResult">If this flag is set, the response will contain the OCR-Result as json string..</param>
        /// <param name="addDocumentText">If this flag is set, the response will contain the plain text of the document as detected by the OCR..</param>
        /// <param name="languages">Restrict invoice languages to a given set provided as a comma separates string of languages..</param>
        public DetectInvoiceRequest(long filter = default(long), string invoice = default(string), int format = default(int), Dictionary<string, string> propertyStore = default(Dictionary<string, string>), bool createResultPdf = default(bool), bool addOcrResult = default(bool), bool addDocumentText = default(bool), string languages = default(string))
        {
            this.Filter = filter;
            this.Invoice = invoice;
            this.Format = format;
            this.PropertyStore = propertyStore;
            this.CreateResultPdf = createResultPdf;
            this.AddOcrResult = addOcrResult;
            this.AddDocumentText = addDocumentText;
            this.Languages = languages;
        }

        /// <summary>
        /// Filter for Invoice details that shall be predicted&lt;br&gt;flag &#39;None&#39; will return all available Invoice details for your subscription,&lt;br&gt;else define the filter by providing a bitmask for the Invoice details that shall be predicted.&lt;br&gt;e.g. Filter &#x3D; GrandTotalAmount | Ibans.&lt;br&gt;&lt;br&gt;Filters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;None:                      0&lt;/li&gt;&lt;li&gt;DeliveryDate:              8&lt;/li&gt;&lt;li&gt;GrandTotalAmount:         16&lt;/li&gt;&lt;li&gt;InvoiceDate:              64&lt;/li&gt;&lt;li&gt;InvoiceId:              1024&lt;/li&gt;&lt;li&gt;DocumentType:           8192&lt;/li&gt;&lt;li&gt;Ibans:                 16384&lt;/li&gt;&lt;li&gt;InvoiceCurrency:      524288&lt;/li&gt;&lt;li&gt;CustomerId:          2097152&lt;/li&gt;&lt;li&gt;UstIds:              8388608&lt;/li&gt;&lt;li&gt;SenderOrderId:      16777216&lt;/li&gt;&lt;li&gt;ReceiverOrderId:    33554432&lt;/li&gt;&lt;li&gt;SenderOrderDate:    67108864&lt;/li&gt;&lt;li&gt;ReceiverOrderDate: 134217728&lt;/li&gt;&lt;li&gt;VatGroup:          536870912&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Filter for Invoice details that shall be predicted&lt;br&gt;flag &#39;None&#39; will return all available Invoice details for your subscription,&lt;br&gt;else define the filter by providing a bitmask for the Invoice details that shall be predicted.&lt;br&gt;e.g. Filter &#x3D; GrandTotalAmount | Ibans.&lt;br&gt;&lt;br&gt;Filters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;None:                      0&lt;/li&gt;&lt;li&gt;DeliveryDate:              8&lt;/li&gt;&lt;li&gt;GrandTotalAmount:         16&lt;/li&gt;&lt;li&gt;InvoiceDate:              64&lt;/li&gt;&lt;li&gt;InvoiceId:              1024&lt;/li&gt;&lt;li&gt;DocumentType:           8192&lt;/li&gt;&lt;li&gt;Ibans:                 16384&lt;/li&gt;&lt;li&gt;InvoiceCurrency:      524288&lt;/li&gt;&lt;li&gt;CustomerId:          2097152&lt;/li&gt;&lt;li&gt;UstIds:              8388608&lt;/li&gt;&lt;li&gt;SenderOrderId:      16777216&lt;/li&gt;&lt;li&gt;ReceiverOrderId:    33554432&lt;/li&gt;&lt;li&gt;SenderOrderDate:    67108864&lt;/li&gt;&lt;li&gt;ReceiverOrderDate: 134217728&lt;/li&gt;&lt;li&gt;VatGroup:          536870912&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "Filter", EmitDefaultValue = false)]
        public long Filter { get; set; }

        /// <summary>
        /// Invoice (encoded as base64 string) - accepted formats: PDF, JPG, PNG, GIF, TIFF
        /// </summary>
        /// <value>Invoice (encoded as base64 string) - accepted formats: PDF, JPG, PNG, GIF, TIFF</value>
        [DataMember(Name = "Invoice", EmitDefaultValue = false)]
        public string Invoice { get; set; }

        /// <summary>
        /// Special Invoice format.&lt;br&gt;for future use only&lt;ul&gt;&lt;li&gt;None: 0&lt;/li&gt;&lt;li&gt;EbInterface: 1&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Special Invoice format.&lt;br&gt;for future use only&lt;ul&gt;&lt;li&gt;None: 0&lt;/li&gt;&lt;li&gt;EbInterface: 1&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "Format", EmitDefaultValue = false)]
        public int Format { get; set; }

        /// <summary>
        /// Dictionary&lt;String,String&gt;
        /// </summary>
        /// <value>Dictionary&lt;String,String&gt;</value>
        [DataMember(Name = "PropertyStore", EmitDefaultValue = false)]
        public Dictionary<string, string> PropertyStore { get; set; }

        /// <summary>
        /// If this flag is set, the response will contain the sent invoice as pdf-document with marked predictions.
        /// </summary>
        /// <value>If this flag is set, the response will contain the sent invoice as pdf-document with marked predictions.</value>
        [DataMember(Name = "CreateResultPdf", EmitDefaultValue = true)]
        public bool CreateResultPdf { get; set; }

        /// <summary>
        /// If this flag is set, the response will contain the OCR-Result as json string.
        /// </summary>
        /// <value>If this flag is set, the response will contain the OCR-Result as json string.</value>
        [DataMember(Name = "AddOcrResult", EmitDefaultValue = true)]
        public bool AddOcrResult { get; set; }

        /// <summary>
        /// If this flag is set, the response will contain the plain text of the document as detected by the OCR.
        /// </summary>
        /// <value>If this flag is set, the response will contain the plain text of the document as detected by the OCR.</value>
        [DataMember(Name = "AddDocumentText", EmitDefaultValue = true)]
        public bool AddDocumentText { get; set; }

        /// <summary>
        /// Restrict invoice languages to a given set provided as a comma separates string of languages.
        /// </summary>
        /// <value>Restrict invoice languages to a given set provided as a comma separates string of languages.</value>
        [DataMember(Name = "Languages", EmitDefaultValue = false)]
        public string Languages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectInvoiceRequest {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  PropertyStore: ").Append(PropertyStore).Append("\n");
            sb.Append("  CreateResultPdf: ").Append(CreateResultPdf).Append("\n");
            sb.Append("  AddOcrResult: ").Append(AddOcrResult).Append("\n");
            sb.Append("  AddDocumentText: ").Append(AddDocumentText).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectInvoiceRequest);
        }

        /// <summary>
        /// Returns true if DetectInvoiceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectInvoiceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectInvoiceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filter == input.Filter ||
                    this.Filter.Equals(input.Filter)
                ) && 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.PropertyStore == input.PropertyStore ||
                    this.PropertyStore != null &&
                    input.PropertyStore != null &&
                    this.PropertyStore.SequenceEqual(input.PropertyStore)
                ) && 
                (
                    this.CreateResultPdf == input.CreateResultPdf ||
                    this.CreateResultPdf.Equals(input.CreateResultPdf)
                ) && 
                (
                    this.AddOcrResult == input.AddOcrResult ||
                    this.AddOcrResult.Equals(input.AddOcrResult)
                ) && 
                (
                    this.AddDocumentText == input.AddDocumentText ||
                    this.AddDocumentText.Equals(input.AddDocumentText)
                ) && 
                (
                    this.Languages == input.Languages ||
                    (this.Languages != null &&
                    this.Languages.Equals(input.Languages))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.PropertyStore != null)
                    hashCode = hashCode * 59 + this.PropertyStore.GetHashCode();
                hashCode = hashCode * 59 + this.CreateResultPdf.GetHashCode();
                hashCode = hashCode * 59 + this.AddOcrResult.GetHashCode();
                hashCode = hashCode * 59 + this.AddDocumentText.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
