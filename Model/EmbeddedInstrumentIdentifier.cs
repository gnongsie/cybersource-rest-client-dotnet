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
    /// EmbeddedInstrumentIdentifier
    /// </summary>
    [DataContract]
    public partial class EmbeddedInstrumentIdentifier :  IEquatable<EmbeddedInstrumentIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedInstrumentIdentifier" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">The ID of the existing instrument identifier to be linked to the newly created payment instrument..</param>
        /// <param name="Card">Card.</param>
        /// <param name="BankAccount">BankAccount.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="Metadata">Metadata.</param>
        public EmbeddedInstrumentIdentifier(TmsV1InstrumentIdentifiersPost200ResponseLinks Links = default(TmsV1InstrumentIdentifiersPost200ResponseLinks), string Id = default(string), TmsV1InstrumentIdentifiersPost200ResponseCard Card = default(TmsV1InstrumentIdentifiersPost200ResponseCard), TmsV1InstrumentIdentifiersPost200ResponseBankAccount BankAccount = default(TmsV1InstrumentIdentifiersPost200ResponseBankAccount), TmsV1InstrumentIdentifiersPost200ResponseProcessingInformation ProcessingInformation = default(TmsV1InstrumentIdentifiersPost200ResponseProcessingInformation), TmsV1InstrumentIdentifiersPost200ResponseMetadata Metadata = default(TmsV1InstrumentIdentifiersPost200ResponseMetadata))
        {
            this.Links = Links;
            this.Id = Id;
            this.Card = Card;
            this.BankAccount = BankAccount;
            this.ProcessingInformation = ProcessingInformation;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public TmsV1InstrumentIdentifiersPost200ResponseLinks Links { get; set; }

        /// <summary>
        /// &#39;Describes type of token.&#39;  Valid values: - instrumentIdentifier 
        /// </summary>
        /// <value>&#39;Describes type of token.&#39;  Valid values: - instrumentIdentifier </value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; private set; }

        /// <summary>
        /// &#39;Current state of the token.&#39;              Valid values: - ACTIVE - CLOSED 
        /// </summary>
        /// <value>&#39;Current state of the token.&#39;              Valid values: - ACTIVE - CLOSED </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; private set; }

        /// <summary>
        /// The ID of the existing instrument identifier to be linked to the newly created payment instrument.
        /// </summary>
        /// <value>The ID of the existing instrument identifier to be linked to the newly created payment instrument.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public TmsV1InstrumentIdentifiersPost200ResponseCard Card { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bankAccount", EmitDefaultValue=false)]
        public TmsV1InstrumentIdentifiersPost200ResponseBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public TmsV1InstrumentIdentifiersPost200ResponseProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public TmsV1InstrumentIdentifiersPost200ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedInstrumentIdentifier {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as EmbeddedInstrumentIdentifier);
        }

        /// <summary>
        /// Returns true if EmbeddedInstrumentIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of EmbeddedInstrumentIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedInstrumentIdentifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.BankAccount == other.BankAccount ||
                    this.BankAccount != null &&
                    this.BankAccount.Equals(other.BankAccount)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.BankAccount != null)
                    hash = hash * 59 + this.BankAccount.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length >= 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than or equal to 32.", new [] { "Id" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length <= 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than or equal to 16.", new [] { "Id" });
            }

            yield break;
        }
    }

}
