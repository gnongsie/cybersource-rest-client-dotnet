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
    /// Ptsv2paymentsidcapturesAggregatorInformationSubMerchant
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesAggregatorInformationSubMerchant :  IEquatable<Ptsv2paymentsidcapturesAggregatorInformationSubMerchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesAggregatorInformationSubMerchant" /> class.
        /// </summary>
        /// <param name="Name">Sub-merchant’s business name.  #### American Express Direct The maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters.  #### Visa Platform Connect With American Express, the maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters.  #### FDC Nashville Global With Mastercard, the maximum length of the sub-merchant name depends on the length of the aggregator name: - If aggregator name length is 1 through 3, maximum sub-merchant name length is 21. - If aggregator name length is 4 through 7, maximum sub-merchant name length is 17. - If aggregator name length is 8 through 12, maximum sub-merchant name length is 12. .</param>
        /// <param name="Address1">First line of the sub-merchant’s street address.  For processor-specific details, see &#x60;submerchant_street&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. .</param>
        /// <param name="Locality">Sub-merchant’s city.  For processor-specific details, see &#x60;submerchant_city&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. .</param>
        /// <param name="AdministrativeArea">Sub-merchant’s state or province.  For possible values and also aggregator support, see &#x60;submerchant_state&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. .</param>
        /// <param name="PostalCode">Partial postal code for the sub-merchant’s address.  For processor-specific details, see &#x60;submerchant_postal_code&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. .</param>
        /// <param name="Country">Sub-merchant’s country. Use the two-character ISO Standard Country Codes.  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file.  #### FDC Compass This value must consist of uppercase characters.  See \&quot;Aggregator Support,\&quot; page 101. .</param>
        /// <param name="Email">Sub-merchant’s email address.  **Maximum length for processors**   - American Express Direct: 40  - Visa Platform Connect: 40  - FDC Compass: 40  - FDC Nashville Global: 19  #### Visa Platform Connect With American Express, the value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCRB - Position: 25-64 - Field: American Express Seller E-mail Address  **Note** The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. Visa Platform Connect creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies. .</param>
        /// <param name="PhoneNumber">Sub-merchant’s telephone number.  **Maximum length for procesors**   - American Express Direct: 20  - Visa Platform Connect: 20  - FDC Compass: 13  - FDC Nashville Global: 10  #### Visa Platform Connect With American Express, the value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCRB - Position: 5-24 - Field: American Express Seller Telephone Number  **FDC Compass**\\ This value must consist of uppercase characters. Use one of these recommended formats:\\ &#x60;NNN-NNN-NNNN&#x60;\\ &#x60;NNN-AAAAAAA&#x60; .</param>
        public Ptsv2paymentsidcapturesAggregatorInformationSubMerchant(string Name = default(string), string Address1 = default(string), string Locality = default(string), string AdministrativeArea = default(string), string PostalCode = default(string), string Country = default(string), string Email = default(string), string PhoneNumber = default(string))
        {
            this.Name = Name;
            this.Address1 = Address1;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
        
        /// <summary>
        /// Sub-merchant’s business name.  #### American Express Direct The maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters.  #### Visa Platform Connect With American Express, the maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters.  #### FDC Nashville Global With Mastercard, the maximum length of the sub-merchant name depends on the length of the aggregator name: - If aggregator name length is 1 through 3, maximum sub-merchant name length is 21. - If aggregator name length is 4 through 7, maximum sub-merchant name length is 17. - If aggregator name length is 8 through 12, maximum sub-merchant name length is 12. 
        /// </summary>
        /// <value>Sub-merchant’s business name.  #### American Express Direct The maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters.  #### Visa Platform Connect With American Express, the maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters.  #### FDC Nashville Global With Mastercard, the maximum length of the sub-merchant name depends on the length of the aggregator name: - If aggregator name length is 1 through 3, maximum sub-merchant name length is 21. - If aggregator name length is 4 through 7, maximum sub-merchant name length is 17. - If aggregator name length is 8 through 12, maximum sub-merchant name length is 12. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// First line of the sub-merchant’s street address.  For processor-specific details, see &#x60;submerchant_street&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. 
        /// </summary>
        /// <value>First line of the sub-merchant’s street address.  For processor-specific details, see &#x60;submerchant_street&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Sub-merchant’s city.  For processor-specific details, see &#x60;submerchant_city&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. 
        /// </summary>
        /// <value>Sub-merchant’s city.  For processor-specific details, see &#x60;submerchant_city&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Sub-merchant’s state or province.  For possible values and also aggregator support, see &#x60;submerchant_state&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. 
        /// </summary>
        /// <value>Sub-merchant’s state or province.  For possible values and also aggregator support, see &#x60;submerchant_state&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Partial postal code for the sub-merchant’s address.  For processor-specific details, see &#x60;submerchant_postal_code&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. 
        /// </summary>
        /// <value>Partial postal code for the sub-merchant’s address.  For processor-specific details, see &#x60;submerchant_postal_code&#x60; request field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file5.  #### FDC Compass This value must consist of uppercase characters. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Sub-merchant’s country. Use the two-character ISO Standard Country Codes.  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file.  #### FDC Compass This value must consist of uppercase characters.  See \&quot;Aggregator Support,\&quot; page 101. 
        /// </summary>
        /// <value>Sub-merchant’s country. Use the two-character ISO Standard Country Codes.  #### Visa Platform Connect The value for this field does not map to the TC 33 capture file.  #### FDC Compass This value must consist of uppercase characters.  See \&quot;Aggregator Support,\&quot; page 101. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Sub-merchant’s email address.  **Maximum length for processors**   - American Express Direct: 40  - Visa Platform Connect: 40  - FDC Compass: 40  - FDC Nashville Global: 19  #### Visa Platform Connect With American Express, the value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCRB - Position: 25-64 - Field: American Express Seller E-mail Address  **Note** The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. Visa Platform Connect creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies. 
        /// </summary>
        /// <value>Sub-merchant’s email address.  **Maximum length for processors**   - American Express Direct: 40  - Visa Platform Connect: 40  - FDC Compass: 40  - FDC Nashville Global: 19  #### Visa Platform Connect With American Express, the value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCRB - Position: 25-64 - Field: American Express Seller E-mail Address  **Note** The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. Visa Platform Connect creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies. </value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Sub-merchant’s telephone number.  **Maximum length for procesors**   - American Express Direct: 20  - Visa Platform Connect: 20  - FDC Compass: 13  - FDC Nashville Global: 10  #### Visa Platform Connect With American Express, the value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCRB - Position: 5-24 - Field: American Express Seller Telephone Number  **FDC Compass**\\ This value must consist of uppercase characters. Use one of these recommended formats:\\ &#x60;NNN-NNN-NNNN&#x60;\\ &#x60;NNN-AAAAAAA&#x60; 
        /// </summary>
        /// <value>Sub-merchant’s telephone number.  **Maximum length for procesors**   - American Express Direct: 20  - Visa Platform Connect: 20  - FDC Compass: 13  - FDC Nashville Global: 10  #### Visa Platform Connect With American Express, the value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCRB - Position: 5-24 - Field: American Express Seller Telephone Number  **FDC Compass**\\ This value must consist of uppercase characters. Use one of these recommended formats:\\ &#x60;NNN-NNN-NNNN&#x60;\\ &#x60;NNN-AAAAAAA&#x60; </value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesAggregatorInformationSubMerchant {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidcapturesAggregatorInformationSubMerchant);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesAggregatorInformationSubMerchant instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesAggregatorInformationSubMerchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesAggregatorInformationSubMerchant other)
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
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length >= 37)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than or equal to 37.", new [] { "Name" });
            }

            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length >= 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than or equal to 38.", new [] { "Address1" });
            }

            // Locality (string) maxLength
            if(this.Locality != null && this.Locality.Length >= 21)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locality, length must be less than or equal to 21.", new [] { "Locality" });
            }

            // AdministrativeArea (string) maxLength
            if(this.AdministrativeArea != null && this.AdministrativeArea.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrativeArea, length must be less than or equal to 3.", new [] { "AdministrativeArea" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than or equal to 15.", new [] { "PostalCode" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than or equal to 3.", new [] { "Country" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length >= 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than or equal to 40.", new [] { "Email" });
            }

            // PhoneNumber (string) maxLength
            if(this.PhoneNumber != null && this.PhoneNumber.Length >= 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than or equal to 20.", new [] { "PhoneNumber" });
            }

            yield break;
        }
    }

}
