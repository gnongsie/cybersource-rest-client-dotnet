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
    /// InlineResponse201PointOfSaleInformation
    /// </summary>
    [DataContract]
    public partial class InlineResponse201PointOfSaleInformation :  IEquatable<InlineResponse201PointOfSaleInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201PointOfSaleInformation" /> class.
        /// </summary>
        /// <param name="Emv">Emv.</param>
        /// <param name="AmexCapnData">Point-of-sale details for the transaction. This value is returned only for **American Express Direct**. CyberSource generates this value, which consists of a series of codes that identify terminal capability, security data, and specific conditions present at the time the transaction occurred. To comply with the CAPN requirements, this  value must be included in all subsequent follow-on requests, such as captures and follow-on credits.  When you perform authorizations, captures, and credits through CyberSource, CyberSource passes this value from the authorization service to the subsequent services for you. However, when you perform authorizations through CyberSource and perform subsequent services through other financial institutions, you must ensure that your requests for captures and credits include this value. .</param>
        public InlineResponse201PointOfSaleInformation(InlineResponse201PointOfSaleInformationEmv Emv = default(InlineResponse201PointOfSaleInformationEmv), string AmexCapnData = default(string))
        {
            this.Emv = Emv;
            this.AmexCapnData = AmexCapnData;
        }
        
        /// <summary>
        /// Gets or Sets Emv
        /// </summary>
        [DataMember(Name="emv", EmitDefaultValue=false)]
        public InlineResponse201PointOfSaleInformationEmv Emv { get; set; }

        /// <summary>
        /// Point-of-sale details for the transaction. This value is returned only for **American Express Direct**. CyberSource generates this value, which consists of a series of codes that identify terminal capability, security data, and specific conditions present at the time the transaction occurred. To comply with the CAPN requirements, this  value must be included in all subsequent follow-on requests, such as captures and follow-on credits.  When you perform authorizations, captures, and credits through CyberSource, CyberSource passes this value from the authorization service to the subsequent services for you. However, when you perform authorizations through CyberSource and perform subsequent services through other financial institutions, you must ensure that your requests for captures and credits include this value. 
        /// </summary>
        /// <value>Point-of-sale details for the transaction. This value is returned only for **American Express Direct**. CyberSource generates this value, which consists of a series of codes that identify terminal capability, security data, and specific conditions present at the time the transaction occurred. To comply with the CAPN requirements, this  value must be included in all subsequent follow-on requests, such as captures and follow-on credits.  When you perform authorizations, captures, and credits through CyberSource, CyberSource passes this value from the authorization service to the subsequent services for you. However, when you perform authorizations through CyberSource and perform subsequent services through other financial institutions, you must ensure that your requests for captures and credits include this value. </value>
        [DataMember(Name="amexCapnData", EmitDefaultValue=false)]
        public string AmexCapnData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201PointOfSaleInformation {\n");
            sb.Append("  Emv: ").Append(Emv).Append("\n");
            sb.Append("  AmexCapnData: ").Append(AmexCapnData).Append("\n");
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
            return this.Equals(obj as InlineResponse201PointOfSaleInformation);
        }

        /// <summary>
        /// Returns true if InlineResponse201PointOfSaleInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse201PointOfSaleInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201PointOfSaleInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Emv == other.Emv ||
                    this.Emv != null &&
                    this.Emv.Equals(other.Emv)
                ) && 
                (
                    this.AmexCapnData == other.AmexCapnData ||
                    this.AmexCapnData != null &&
                    this.AmexCapnData.Equals(other.AmexCapnData)
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
                if (this.Emv != null)
                    hash = hash * 59 + this.Emv.GetHashCode();
                if (this.AmexCapnData != null)
                    hash = hash * 59 + this.AmexCapnData.GetHashCode();
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
            // AmexCapnData (string) maxLength
            if(this.AmexCapnData != null && this.AmexCapnData.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmexCapnData, length must be less than 12.", new [] { "AmexCapnData" });
            }

            yield break;
        }
    }

}
