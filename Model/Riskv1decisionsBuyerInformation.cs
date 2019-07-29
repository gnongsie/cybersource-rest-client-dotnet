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
    /// Contains information about the buyer.
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsBuyerInformation :  IEquatable<Riskv1decisionsBuyerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsBuyerInformation" /> class.
        /// </summary>
        /// <param name="Username">Specifies the customer account user name..</param>
        /// <param name="HashedPassword">The merchant&#39;s password that CyberSource hashes and stores as a hashed password.  For details about this field, see the &#x60;customer_password&#x60; field description in [Decision Manager Developer Guide Using the SCMP API.](https://www.cybersource.com/developers/documentation/fraud_management/) .</param>
        /// <param name="DateOfBirth">Recipient’s date of birth. **Format**: &#x60;YYYYMMDD&#x60;.  This field is a &#x60;pass-through&#x60;, which means that CyberSource ensures that the value is eight numeric characters but otherwise does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see &#x60;recipient_date_of_birth&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="PersonalIdentification">PersonalIdentification.</param>
        public Riskv1decisionsBuyerInformation(string Username = default(string), string HashedPassword = default(string), string DateOfBirth = default(string), List<Ptsv2paymentsBuyerInformationPersonalIdentification> PersonalIdentification = default(List<Ptsv2paymentsBuyerInformationPersonalIdentification>))
        {
            this.Username = Username;
            this.HashedPassword = HashedPassword;
            this.DateOfBirth = DateOfBirth;
            this.PersonalIdentification = PersonalIdentification;
        }
        
        /// <summary>
        /// Specifies the customer account user name.
        /// </summary>
        /// <value>Specifies the customer account user name.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The merchant&#39;s password that CyberSource hashes and stores as a hashed password.  For details about this field, see the &#x60;customer_password&#x60; field description in [Decision Manager Developer Guide Using the SCMP API.](https://www.cybersource.com/developers/documentation/fraud_management/) 
        /// </summary>
        /// <value>The merchant&#39;s password that CyberSource hashes and stores as a hashed password.  For details about this field, see the &#x60;customer_password&#x60; field description in [Decision Manager Developer Guide Using the SCMP API.](https://www.cybersource.com/developers/documentation/fraud_management/) </value>
        [DataMember(Name="hashedPassword", EmitDefaultValue=false)]
        public string HashedPassword { get; set; }

        /// <summary>
        /// Recipient’s date of birth. **Format**: &#x60;YYYYMMDD&#x60;.  This field is a &#x60;pass-through&#x60;, which means that CyberSource ensures that the value is eight numeric characters but otherwise does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see &#x60;recipient_date_of_birth&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Recipient’s date of birth. **Format**: &#x60;YYYYMMDD&#x60;.  This field is a &#x60;pass-through&#x60;, which means that CyberSource ensures that the value is eight numeric characters but otherwise does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see &#x60;recipient_date_of_birth&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets PersonalIdentification
        /// </summary>
        [DataMember(Name="personalIdentification", EmitDefaultValue=false)]
        public List<Ptsv2paymentsBuyerInformationPersonalIdentification> PersonalIdentification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsBuyerInformation {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  HashedPassword: ").Append(HashedPassword).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  PersonalIdentification: ").Append(PersonalIdentification).Append("\n");
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
            return this.Equals(obj as Riskv1decisionsBuyerInformation);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsBuyerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsBuyerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsBuyerInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.HashedPassword == other.HashedPassword ||
                    this.HashedPassword != null &&
                    this.HashedPassword.Equals(other.HashedPassword)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.PersonalIdentification == other.PersonalIdentification ||
                    this.PersonalIdentification != null &&
                    this.PersonalIdentification.SequenceEqual(other.PersonalIdentification)
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
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.HashedPassword != null)
                    hash = hash * 59 + this.HashedPassword.GetHashCode();
                if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                if (this.PersonalIdentification != null)
                    hash = hash * 59 + this.PersonalIdentification.GetHashCode();
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
            // Username (string) maxLength
            if(this.Username != null && this.Username.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than or equal to 255.", new [] { "Username" });
            }

            // HashedPassword (string) maxLength
            if(this.HashedPassword != null && this.HashedPassword.Length >= 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HashedPassword, length must be less than or equal to 100.", new [] { "HashedPassword" });
            }

            // DateOfBirth (string) maxLength
            if(this.DateOfBirth != null && this.DateOfBirth.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DateOfBirth, length must be less than or equal to 8.", new [] { "DateOfBirth" });
            }

            yield break;
        }
    }

}
