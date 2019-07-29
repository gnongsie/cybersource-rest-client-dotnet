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
    /// TssV2TransactionsGet200ResponsePaymentInformationPaymentType
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationPaymentType :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationPaymentType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationPaymentType" /> class.
        /// </summary>
        /// <param name="Name">A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. .</param>
        /// <param name="SubTypeName">SubType Name is detail information about Payment Type. Examples: For Card, if Credit or Debit or PrePaid. For Bank Transfer, if Online Bank Transfer or Wire Transfers. .</param>
        /// <param name="FundingSource">FundingSource.</param>
        /// <param name="Method">A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal.</param>
        /// <param name="AuthenticationMethod">A Payment Type Authentication Method is the means used to verify that the presenter of the Payment Type credential is an authorized user of the Payment Instrument. Examples: 3DSecure – Verified by Visa, 3DSecure – MasteCard Secure Code .</param>
        public TssV2TransactionsGet200ResponsePaymentInformationPaymentType(string Name = default(string), string SubTypeName = default(string), TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeFundingSource FundingSource = default(TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeFundingSource), string Method = default(string), string AuthenticationMethod = default(string))
        {
            this.Name = Name;
            this.SubTypeName = SubTypeName;
            this.FundingSource = FundingSource;
            this.Method = Method;
            this.AuthenticationMethod = AuthenticationMethod;
        }
        
        /// <summary>
        /// A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. 
        /// </summary>
        /// <value>A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// SubType Name is detail information about Payment Type. Examples: For Card, if Credit or Debit or PrePaid. For Bank Transfer, if Online Bank Transfer or Wire Transfers. 
        /// </summary>
        /// <value>SubType Name is detail information about Payment Type. Examples: For Card, if Credit or Debit or PrePaid. For Bank Transfer, if Online Bank Transfer or Wire Transfers. </value>
        [DataMember(Name="subTypeName", EmitDefaultValue=false)]
        public string SubTypeName { get; set; }

        /// <summary>
        /// Gets or Sets FundingSource
        /// </summary>
        [DataMember(Name="fundingSource", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeFundingSource FundingSource { get; set; }

        /// <summary>
        /// A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal
        /// </summary>
        /// <value>A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// A Payment Type Authentication Method is the means used to verify that the presenter of the Payment Type credential is an authorized user of the Payment Instrument. Examples: 3DSecure – Verified by Visa, 3DSecure – MasteCard Secure Code 
        /// </summary>
        /// <value>A Payment Type Authentication Method is the means used to verify that the presenter of the Payment Type credential is an authorized user of the Payment Instrument. Examples: 3DSecure – Verified by Visa, 3DSecure – MasteCard Secure Code </value>
        [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
        public string AuthenticationMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationPaymentType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubTypeName: ").Append(SubTypeName).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationPaymentType);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationPaymentType instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationPaymentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationPaymentType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SubTypeName == other.SubTypeName ||
                    this.SubTypeName != null &&
                    this.SubTypeName.Equals(other.SubTypeName)
                ) && 
                (
                    this.FundingSource == other.FundingSource ||
                    this.FundingSource != null &&
                    this.FundingSource.Equals(other.FundingSource)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.AuthenticationMethod == other.AuthenticationMethod ||
                    this.AuthenticationMethod != null &&
                    this.AuthenticationMethod.Equals(other.AuthenticationMethod)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SubTypeName != null)
                    hash = hash * 59 + this.SubTypeName.GetHashCode();
                if (this.FundingSource != null)
                    hash = hash * 59 + this.FundingSource.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.AuthenticationMethod != null)
                    hash = hash * 59 + this.AuthenticationMethod.GetHashCode();
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
