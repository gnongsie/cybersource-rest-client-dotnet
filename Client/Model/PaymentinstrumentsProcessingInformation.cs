/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// PaymentinstrumentsProcessingInformation
    /// </summary>
    [DataContract]
    public partial class PaymentinstrumentsProcessingInformation :  IEquatable<PaymentinstrumentsProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentinstrumentsProcessingInformation" /> class.
        /// </summary>
        /// <param name="BillPaymentProgramEnabled">Bill Payment Program Enabled..</param>
        /// <param name="BankTransferOptions">BankTransferOptions.</param>
        public PaymentinstrumentsProcessingInformation(bool? BillPaymentProgramEnabled = default(bool?), PaymentinstrumentsProcessingInformationBankTransferOptions BankTransferOptions = default(PaymentinstrumentsProcessingInformationBankTransferOptions))
        {
            this.BillPaymentProgramEnabled = BillPaymentProgramEnabled;
            this.BankTransferOptions = BankTransferOptions;
        }
        
        /// <summary>
        /// Bill Payment Program Enabled.
        /// </summary>
        /// <value>Bill Payment Program Enabled.</value>
        [DataMember(Name="billPaymentProgramEnabled", EmitDefaultValue=false)]
        public bool? BillPaymentProgramEnabled { get; set; }

        /// <summary>
        /// Gets or Sets BankTransferOptions
        /// </summary>
        [DataMember(Name="bankTransferOptions", EmitDefaultValue=false)]
        public PaymentinstrumentsProcessingInformationBankTransferOptions BankTransferOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentinstrumentsProcessingInformation {\n");
            sb.Append("  BillPaymentProgramEnabled: ").Append(BillPaymentProgramEnabled).Append("\n");
            sb.Append("  BankTransferOptions: ").Append(BankTransferOptions).Append("\n");
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
            return this.Equals(obj as PaymentinstrumentsProcessingInformation);
        }

        /// <summary>
        /// Returns true if PaymentinstrumentsProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentinstrumentsProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentinstrumentsProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillPaymentProgramEnabled == other.BillPaymentProgramEnabled ||
                    this.BillPaymentProgramEnabled != null &&
                    this.BillPaymentProgramEnabled.Equals(other.BillPaymentProgramEnabled)
                ) && 
                (
                    this.BankTransferOptions == other.BankTransferOptions ||
                    this.BankTransferOptions != null &&
                    this.BankTransferOptions.Equals(other.BankTransferOptions)
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
                if (this.BillPaymentProgramEnabled != null)
                    hash = hash * 59 + this.BillPaymentProgramEnabled.GetHashCode();
                if (this.BankTransferOptions != null)
                    hash = hash * 59 + this.BankTransferOptions.GetHashCode();
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
            yield break;
        }
    }

}
