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
    /// Ptsv2paymentsPaymentInformationFluidData
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPaymentInformationFluidData :  IEquatable<Ptsv2paymentsPaymentInformationFluidData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPaymentInformationFluidData" /> class.
        /// </summary>
        /// <param name="Key">The encoded or encrypted value that a payment solution returns for an authorization request. For details about the valid values for a key, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) .</param>
        /// <param name="Descriptor">The identifier for a payment solution, which is sending the encrypted payment data to CyberSource for decryption. Valid values: - Samsung Pay: &#x60;RklEPUNPTU1PTi5TQU1TVU5HLklOQVBQLlBBWU1FTlQ&#x3D;&#x60; **NOTE**: For other payment solutions, the value may be specific to the customer&#39;s mobile device. For example, the descriptor for a Bluefin payment encryption would be a device-generated descriptor.  For details about the list of payment solution identifiers, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html).  For details about the encrypted payment data, see the &#x60;encrypted_payment_descriptor&#x60; field description in the [Card-Present Processing Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm). .</param>
        /// <param name="Value">Represents the encrypted payment data BLOB. The entry for this field is dependent on the payment solution a merchant uses.  For details, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) for the specific payment- solution entry. .</param>
        /// <param name="Encoding">Encoding method used to encrypt the payment data.  Valid value: Base64 .</param>
        public Ptsv2paymentsPaymentInformationFluidData(string Key = default(string), string Descriptor = default(string), string Value = default(string), string Encoding = default(string))
        {
            this.Key = Key;
            this.Descriptor = Descriptor;
            this.Value = Value;
            this.Encoding = Encoding;
        }
        
        /// <summary>
        /// The encoded or encrypted value that a payment solution returns for an authorization request. For details about the valid values for a key, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) 
        /// </summary>
        /// <value>The encoded or encrypted value that a payment solution returns for an authorization request. For details about the valid values for a key, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) </value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The identifier for a payment solution, which is sending the encrypted payment data to CyberSource for decryption. Valid values: - Samsung Pay: &#x60;RklEPUNPTU1PTi5TQU1TVU5HLklOQVBQLlBBWU1FTlQ&#x3D;&#x60; **NOTE**: For other payment solutions, the value may be specific to the customer&#39;s mobile device. For example, the descriptor for a Bluefin payment encryption would be a device-generated descriptor.  For details about the list of payment solution identifiers, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html).  For details about the encrypted payment data, see the &#x60;encrypted_payment_descriptor&#x60; field description in the [Card-Present Processing Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm). 
        /// </summary>
        /// <value>The identifier for a payment solution, which is sending the encrypted payment data to CyberSource for decryption. Valid values: - Samsung Pay: &#x60;RklEPUNPTU1PTi5TQU1TVU5HLklOQVBQLlBBWU1FTlQ&#x3D;&#x60; **NOTE**: For other payment solutions, the value may be specific to the customer&#39;s mobile device. For example, the descriptor for a Bluefin payment encryption would be a device-generated descriptor.  For details about the list of payment solution identifiers, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html).  For details about the encrypted payment data, see the &#x60;encrypted_payment_descriptor&#x60; field description in the [Card-Present Processing Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm). </value>
        [DataMember(Name="descriptor", EmitDefaultValue=false)]
        public string Descriptor { get; set; }

        /// <summary>
        /// Represents the encrypted payment data BLOB. The entry for this field is dependent on the payment solution a merchant uses.  For details, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) for the specific payment- solution entry. 
        /// </summary>
        /// <value>Represents the encrypted payment data BLOB. The entry for this field is dependent on the payment solution a merchant uses.  For details, see [Creating an Online Authorization](https://developer.cybersource.com/api/developer-guides/dita-payments/CreatingOnlineAuth.html) for the specific payment- solution entry. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Encoding method used to encrypt the payment data.  Valid value: Base64 
        /// </summary>
        /// <value>Encoding method used to encrypt the payment data.  Valid value: Base64 </value>
        [DataMember(Name="encoding", EmitDefaultValue=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPaymentInformationFluidData {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPaymentInformationFluidData);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPaymentInformationFluidData instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPaymentInformationFluidData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPaymentInformationFluidData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Descriptor == other.Descriptor ||
                    this.Descriptor != null &&
                    this.Descriptor.Equals(other.Descriptor)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Encoding == other.Encoding ||
                    this.Encoding != null &&
                    this.Encoding.Equals(other.Encoding)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Descriptor != null)
                    hash = hash * 59 + this.Descriptor.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Encoding != null)
                    hash = hash * 59 + this.Encoding.GetHashCode();
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
            // Descriptor (string) maxLength
            if(this.Descriptor != null && this.Descriptor.Length >= 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Descriptor, length must be less than or equal to 128.", new [] { "Descriptor" });
            }

            // Value (string) maxLength
            if(this.Value != null && this.Value.Length >= 3072)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than or equal to 3072.", new [] { "Value" });
            }

            // Encoding (string) maxLength
            if(this.Encoding != null && this.Encoding.Length >= 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Encoding, length must be less than or equal to 6.", new [] { "Encoding" });
            }

            yield break;
        }
    }

}
