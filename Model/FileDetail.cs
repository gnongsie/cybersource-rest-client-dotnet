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
    /// FileDetail
    /// </summary>
    [DataContract]
    public partial class FileDetail :  IEquatable<FileDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDetail" /> class.
        /// </summary>
        /// <param name="FileId">Unique identifier of a file.</param>
        /// <param name="Name">Name of the file.</param>
        /// <param name="CreatedTime">Date and time for the file in PST.</param>
        /// <param name="LastModifiedTime">Date and time for the file in PST.</param>
        /// <param name="Date">Date and time for the file in PST.</param>
        /// <param name="MimeType">&#39;File extension&#39;  Valid values: - &#39;application/xml&#39; - &#39;text/csv&#39; - &#39;application/pdf&#39; - &#39;application/octet-stream&#39; .</param>
        /// <param name="Size">Size of the file in bytes.</param>
        public FileDetail(string FileId = default(string), string Name = default(string), DateTime? CreatedTime = default(DateTime?), DateTime? LastModifiedTime = default(DateTime?), DateTime? Date = default(DateTime?), string MimeType = default(string), int? Size = default(int?))
        {
            this.FileId = FileId;
            this.Name = Name;
            this.CreatedTime = CreatedTime;
            this.LastModifiedTime = LastModifiedTime;
            this.Date = Date;
            this.MimeType = MimeType;
            this.Size = Size;
        }
        
        /// <summary>
        /// Unique identifier of a file
        /// </summary>
        /// <value>Unique identifier of a file</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        /// <value>Name of the file</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Date and time for the file in PST
        /// </summary>
        /// <value>Date and time for the file in PST</value>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Date and time for the file in PST
        /// </summary>
        /// <value>Date and time for the file in PST</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Date and time for the file in PST
        /// </summary>
        /// <value>Date and time for the file in PST</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// &#39;File extension&#39;  Valid values: - &#39;application/xml&#39; - &#39;text/csv&#39; - &#39;application/pdf&#39; - &#39;application/octet-stream&#39; 
        /// </summary>
        /// <value>&#39;File extension&#39;  Valid values: - &#39;application/xml&#39; - &#39;text/csv&#39; - &#39;application/pdf&#39; - &#39;application/octet-stream&#39; </value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        /// <value>Size of the file in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDetail {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(obj as FileDetail);
        }

        /// <summary>
        /// Returns true if FileDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of FileDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FileId == other.FileId ||
                    this.FileId != null &&
                    this.FileId.Equals(other.FileId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CreatedTime == other.CreatedTime ||
                    this.CreatedTime != null &&
                    this.CreatedTime.Equals(other.CreatedTime)
                ) && 
                (
                    this.LastModifiedTime == other.LastModifiedTime ||
                    this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(other.LastModifiedTime)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
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
                if (this.FileId != null)
                    hash = hash * 59 + this.FileId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.CreatedTime != null)
                    hash = hash * 59 + this.CreatedTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hash = hash * 59 + this.LastModifiedTime.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.MimeType != null)
                    hash = hash * 59 + this.MimeType.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
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
