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
    /// LineItemTableResponse
    /// </summary>
    [DataContract(Name = "LineItemTableResponse")]
    public partial class LineItemTableResponse : IEquatable<LineItemTableResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemTableResponse" /> class.
        /// </summary>
        /// <param name="lineItems">List of predicted line items.</param>
        public LineItemTableResponse(List<LineItemResponse> lineItems = default(List<LineItemResponse>))
        {
            this.LineItems = lineItems;
        }

        /// <summary>
        /// List of predicted line items
        /// </summary>
        /// <value>List of predicted line items</value>
        [DataMember(Name = "LineItems", EmitDefaultValue = false)]
        public List<LineItemResponse> LineItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemTableResponse {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
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
            return this.Equals(input as LineItemTableResponse);
        }

        /// <summary>
        /// Returns true if LineItemTableResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemTableResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemTableResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
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
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
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
