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
    /// InlineResponse2013Links
    /// </summary>
    [DataContract]
    public partial class InlineResponse2013Links :  IEquatable<InlineResponse2013Links>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2013Links" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="_Void">_Void.</param>
        public InlineResponse2013Links(InlineResponse201LinksSelf Self = default(InlineResponse201LinksSelf), InlineResponse201LinksSelf _Void = default(InlineResponse201LinksSelf))
        {
            this.Self = Self;
            this._Void = _Void;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public InlineResponse201LinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets _Void
        /// </summary>
        [DataMember(Name="void", EmitDefaultValue=false)]
        public InlineResponse201LinksSelf _Void { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2013Links {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  _Void: ").Append(_Void).Append("\n");
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
            return this.Equals(obj as InlineResponse2013Links);
        }

        /// <summary>
        /// Returns true if InlineResponse2013Links instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2013Links to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2013Links other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this._Void == other._Void ||
                    this._Void != null &&
                    this._Void.Equals(other._Void)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this._Void != null)
                    hash = hash * 59 + this._Void.GetHashCode();
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
