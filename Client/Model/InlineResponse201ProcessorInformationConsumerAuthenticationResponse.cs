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
    /// InlineResponse201ProcessorInformationConsumerAuthenticationResponse
    /// </summary>
    [DataContract]
    public partial class InlineResponse201ProcessorInformationConsumerAuthenticationResponse :  IEquatable<InlineResponse201ProcessorInformationConsumerAuthenticationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201ProcessorInformationConsumerAuthenticationResponse" /> class.
        /// </summary>
        /// <param name="Code">Mapped response code for Verified by Visa and American Express SafeKey: .</param>
        /// <param name="CodeRaw">Raw response code sent directly from the processor for Verified by Visa and American Express SafeKey: .</param>
        public InlineResponse201ProcessorInformationConsumerAuthenticationResponse(string Code = default(string), string CodeRaw = default(string))
        {
            this.Code = Code;
            this.CodeRaw = CodeRaw;
        }
        
        /// <summary>
        /// Mapped response code for Verified by Visa and American Express SafeKey: 
        /// </summary>
        /// <value>Mapped response code for Verified by Visa and American Express SafeKey: </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Raw response code sent directly from the processor for Verified by Visa and American Express SafeKey: 
        /// </summary>
        /// <value>Raw response code sent directly from the processor for Verified by Visa and American Express SafeKey: </value>
        [DataMember(Name="codeRaw", EmitDefaultValue=false)]
        public string CodeRaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201ProcessorInformationConsumerAuthenticationResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CodeRaw: ").Append(CodeRaw).Append("\n");
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
            return this.Equals(obj as InlineResponse201ProcessorInformationConsumerAuthenticationResponse);
        }

        /// <summary>
        /// Returns true if InlineResponse201ProcessorInformationConsumerAuthenticationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse201ProcessorInformationConsumerAuthenticationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201ProcessorInformationConsumerAuthenticationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CodeRaw == other.CodeRaw ||
                    this.CodeRaw != null &&
                    this.CodeRaw.Equals(other.CodeRaw)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.CodeRaw != null)
                    hash = hash * 59 + this.CodeRaw.GetHashCode();
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
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 3.", new [] { "Code" });
            }

            // CodeRaw (string) maxLength
            if(this.CodeRaw != null && this.CodeRaw.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeRaw, length must be less than 3.", new [] { "CodeRaw" });
            }

            yield break;
        }
    }

}
