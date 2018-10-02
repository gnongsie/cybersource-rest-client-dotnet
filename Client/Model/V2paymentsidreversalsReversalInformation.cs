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
    /// V2paymentsidreversalsReversalInformation
    /// </summary>
    [DataContract]
    public partial class V2paymentsidreversalsReversalInformation :  IEquatable<V2paymentsidreversalsReversalInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2paymentsidreversalsReversalInformation" /> class.
        /// </summary>
        /// <param name="AmountDetails">AmountDetails.</param>
        /// <param name="Reason">Reason for the authorization reversal. Possible value:   - 34: Suspected fraud  CyberSource ignores this field for processors that do not support this value. .</param>
        public V2paymentsidreversalsReversalInformation(V2paymentsidreversalsReversalInformationAmountDetails AmountDetails = default(V2paymentsidreversalsReversalInformationAmountDetails), string Reason = default(string))
        {
            this.AmountDetails = AmountDetails;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// Gets or Sets AmountDetails
        /// </summary>
        [DataMember(Name="amountDetails", EmitDefaultValue=false)]
        public V2paymentsidreversalsReversalInformationAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Reason for the authorization reversal. Possible value:   - 34: Suspected fraud  CyberSource ignores this field for processors that do not support this value. 
        /// </summary>
        /// <value>Reason for the authorization reversal. Possible value:   - 34: Suspected fraud  CyberSource ignores this field for processors that do not support this value. </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2paymentsidreversalsReversalInformation {\n");
            sb.Append("  AmountDetails: ").Append(AmountDetails).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as V2paymentsidreversalsReversalInformation);
        }

        /// <summary>
        /// Returns true if V2paymentsidreversalsReversalInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of V2paymentsidreversalsReversalInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2paymentsidreversalsReversalInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountDetails == other.AmountDetails ||
                    this.AmountDetails != null &&
                    this.AmountDetails.Equals(other.AmountDetails)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.AmountDetails != null)
                    hash = hash * 59 + this.AmountDetails.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
            // Reason (string) maxLength
            if(this.Reason != null && this.Reason.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reason, length must be less than 3.", new [] { "Reason" });
            }

            yield break;
        }
    }

}
