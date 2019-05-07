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
    /// TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount :  IEquatable<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Checking account type. Possible values:   * C: checking   * S: savings (USD only)   * X: corporate checking (USD only)   * G: general ledger 
        /// </summary>
        /// <value>Checking account type. Possible values:   * C: checking   * S: savings (USD only)   * X: corporate checking (USD only)   * G: general ledger </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Checking for "checking"
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking,
            
            /// <summary>
            /// Enum Savings for "savings"
            /// </summary>
            [EnumMember(Value = "savings")]
            Savings,
            
            /// <summary>
            /// Enum Corporatechecking for "corporate checking"
            /// </summary>
            [EnumMember(Value = "corporate checking")]
            Corporatechecking,
            
            /// <summary>
            /// Enum Generalledger for "general ledger"
            /// </summary>
            [EnumMember(Value = "general ledger")]
            Generalledger
        }

        /// <summary>
        /// Checking account type. Possible values:   * C: checking   * S: savings (USD only)   * X: corporate checking (USD only)   * G: general ledger 
        /// </summary>
        /// <value>Checking account type. Possible values:   * C: checking   * S: savings (USD only)   * X: corporate checking (USD only)   * G: general ledger </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount" /> class.
        /// </summary>
        /// <param name="Type">Checking account type. Possible values:   * C: checking   * S: savings (USD only)   * X: corporate checking (USD only)   * G: general ledger .</param>
        public TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount(TypeEnum? Type = default(TypeEnum?))
        {
            this.Type = Type;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
