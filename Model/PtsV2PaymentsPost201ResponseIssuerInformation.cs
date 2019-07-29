/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsPost201ResponseIssuerInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseIssuerInformation :  IEquatable<PtsV2PaymentsPost201ResponseIssuerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseIssuerInformation" /> class.
        /// </summary>
        /// <param name="Country">Country in which the card was issued. This information enables you to determine whether the card was issued domestically or internationally. Use the two-character ISO Standard Country Codes.  This field is supported for Visa, Mastercard, Discover, Diners Club, JCB, and Maestro (International) on Chase Paymentech Solutions.  For details, see &#x60;auth_card_issuer_country&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="DiscretionaryData">Data defined by the issuer.  The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **Visa Platform Connect**.  For details, see &#x60;issuer_additional_data&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="ResponseCode">Additional authorization code that must be printed on the receipt when returned by the processor.  This value is generated by the processor and is returned only for a successful transaction.  This field is supported only on FDC Nashville Global and SIX. .</param>
        public PtsV2PaymentsPost201ResponseIssuerInformation(string Country = default(string), string DiscretionaryData = default(string), string ResponseCode = default(string))
        {
            this.Country = Country;
            this.DiscretionaryData = DiscretionaryData;
            this.ResponseCode = ResponseCode;
        }
        
        /// <summary>
        /// Country in which the card was issued. This information enables you to determine whether the card was issued domestically or internationally. Use the two-character ISO Standard Country Codes.  This field is supported for Visa, Mastercard, Discover, Diners Club, JCB, and Maestro (International) on Chase Paymentech Solutions.  For details, see &#x60;auth_card_issuer_country&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Country in which the card was issued. This information enables you to determine whether the card was issued domestically or internationally. Use the two-character ISO Standard Country Codes.  This field is supported for Visa, Mastercard, Discover, Diners Club, JCB, and Maestro (International) on Chase Paymentech Solutions.  For details, see &#x60;auth_card_issuer_country&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Data defined by the issuer.  The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **Visa Platform Connect**.  For details, see &#x60;issuer_additional_data&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Data defined by the issuer.  The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **Visa Platform Connect**.  For details, see &#x60;issuer_additional_data&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="discretionaryData", EmitDefaultValue=false)]
        public string DiscretionaryData { get; set; }

        /// <summary>
        /// Additional authorization code that must be printed on the receipt when returned by the processor.  This value is generated by the processor and is returned only for a successful transaction.  This field is supported only on FDC Nashville Global and SIX. 
        /// </summary>
        /// <value>Additional authorization code that must be printed on the receipt when returned by the processor.  This value is generated by the processor and is returned only for a successful transaction.  This field is supported only on FDC Nashville Global and SIX. </value>
        [DataMember(Name="responseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseIssuerInformation {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DiscretionaryData: ").Append(DiscretionaryData).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PtsV2PaymentsPost201ResponseIssuerInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseIssuerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseIssuerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseIssuerInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.DiscretionaryData == other.DiscretionaryData ||
                    this.DiscretionaryData != null &&
                    this.DiscretionaryData.Equals(other.DiscretionaryData)
                ) && 
                (
                    this.ResponseCode == other.ResponseCode ||
                    this.ResponseCode != null &&
                    this.ResponseCode.Equals(other.ResponseCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.DiscretionaryData != null)
                    hash = hash * 59 + this.DiscretionaryData.GetHashCode();
                if (this.ResponseCode != null)
                    hash = hash * 59 + this.ResponseCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Country (string) maxLength
            if(this.Country != null && this.Country.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than or equal to 3.", new [] { "Country" });
            }

            // DiscretionaryData (string) maxLength
            if(this.DiscretionaryData != null && this.DiscretionaryData.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscretionaryData, length must be less than or equal to 255.", new [] { "DiscretionaryData" });
            }

            // ResponseCode (string) maxLength
            if(this.ResponseCode != null && this.ResponseCode.Length >= 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseCode, length must be less than or equal to 6.", new [] { "ResponseCode" });
            }

            yield break;
        }
    }

}
