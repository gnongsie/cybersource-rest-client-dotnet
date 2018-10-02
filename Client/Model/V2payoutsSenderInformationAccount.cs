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
    /// V2payoutsSenderInformationAccount
    /// </summary>
    [DataContract]
    public partial class V2payoutsSenderInformationAccount :  IEquatable<V2payoutsSenderInformationAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2payoutsSenderInformationAccount" /> class.
        /// </summary>
        /// <param name="FundsSource">Source of funds. Possible values:    Paymentech, CTV, FDC Compass:  - 01: Credit card  - 02: Debit card  - 03: Prepaid card    Paymentech, CTV -  - 04: Cash  - 05: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings        accounts, and proprietary debit or ATM cards.  - 06: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines        of credit.    FDCCompass -   - 04: Deposit Account  **Funds Disbursement**  This value is most likely 05 to identify that the originator used a deposit account to fund the disbursement.  **Credit Card Bill Payment**  This value must be 02, 03, 04, or 05. .</param>
        /// <param name="Number">The account number of the entity funding the transaction. It is the senderâ€™s account number. It can be a debit/credit card account number or bank account number.  **Funds disbursements**  This field is optional.  **All other transactions**  This field is required when the sender funds the transaction with a financial instrument, for example debit card. Length: * FDCCompass (&lt;&#x3D; 19) * Paymentech (&lt;&#x3D; 16) .</param>
        public V2payoutsSenderInformationAccount(string FundsSource = default(string), string Number = default(string))
        {
            this.FundsSource = FundsSource;
            this.Number = Number;
        }
        
        /// <summary>
        /// Source of funds. Possible values:    Paymentech, CTV, FDC Compass:  - 01: Credit card  - 02: Debit card  - 03: Prepaid card    Paymentech, CTV -  - 04: Cash  - 05: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings        accounts, and proprietary debit or ATM cards.  - 06: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines        of credit.    FDCCompass -   - 04: Deposit Account  **Funds Disbursement**  This value is most likely 05 to identify that the originator used a deposit account to fund the disbursement.  **Credit Card Bill Payment**  This value must be 02, 03, 04, or 05. 
        /// </summary>
        /// <value>Source of funds. Possible values:    Paymentech, CTV, FDC Compass:  - 01: Credit card  - 02: Debit card  - 03: Prepaid card    Paymentech, CTV -  - 04: Cash  - 05: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings        accounts, and proprietary debit or ATM cards.  - 06: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines        of credit.    FDCCompass -   - 04: Deposit Account  **Funds Disbursement**  This value is most likely 05 to identify that the originator used a deposit account to fund the disbursement.  **Credit Card Bill Payment**  This value must be 02, 03, 04, or 05. </value>
        [DataMember(Name="fundsSource", EmitDefaultValue=false)]
        public string FundsSource { get; set; }

        /// <summary>
        /// The account number of the entity funding the transaction. It is the senderâ€™s account number. It can be a debit/credit card account number or bank account number.  **Funds disbursements**  This field is optional.  **All other transactions**  This field is required when the sender funds the transaction with a financial instrument, for example debit card. Length: * FDCCompass (&lt;&#x3D; 19) * Paymentech (&lt;&#x3D; 16) 
        /// </summary>
        /// <value>The account number of the entity funding the transaction. It is the senderâ€™s account number. It can be a debit/credit card account number or bank account number.  **Funds disbursements**  This field is optional.  **All other transactions**  This field is required when the sender funds the transaction with a financial instrument, for example debit card. Length: * FDCCompass (&lt;&#x3D; 19) * Paymentech (&lt;&#x3D; 16) </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2payoutsSenderInformationAccount {\n");
            sb.Append("  FundsSource: ").Append(FundsSource).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(obj as V2payoutsSenderInformationAccount);
        }

        /// <summary>
        /// Returns true if V2payoutsSenderInformationAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of V2payoutsSenderInformationAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2payoutsSenderInformationAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FundsSource == other.FundsSource ||
                    this.FundsSource != null &&
                    this.FundsSource.Equals(other.FundsSource)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
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
                if (this.FundsSource != null)
                    hash = hash * 59 + this.FundsSource.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
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
            // FundsSource (string) maxLength
            if(this.FundsSource != null && this.FundsSource.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FundsSource, length must be less than 2.", new [] { "FundsSource" });
            }

            // FundsSource (string) minLength
            if(this.FundsSource != null && this.FundsSource.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FundsSource, length must be greater than 2.", new [] { "FundsSource" });
            }

            // Number (string) maxLength
            if(this.Number != null && this.Number.Length > 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be less than 34.", new [] { "Number" });
            }

            yield break;
        }
    }

}
