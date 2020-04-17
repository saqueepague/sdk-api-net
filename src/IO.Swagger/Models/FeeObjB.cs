/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.18.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FeeObjB : IEquatable<FeeObjB>
    { 
        /// <summary>
        /// Taxa para o valor de recarga.
        /// </summary>
        /// <value>Taxa para o valor de recarga.</value>
        [Required]
        [DataMember(Name="fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Identificador do valor fixo para recarga.
        /// </summary>
        /// <value>Identificador do valor fixo para recarga.</value>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Valor de recarga.
        /// </summary>
        /// <value>Valor de recarga.</value>
        [Required]
        [DataMember(Name="value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeObjB {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((FeeObjB)obj);
        }

        /// <summary>
        /// Returns true if FeeObjB instances are equal
        /// </summary>
        /// <param name="other">Instance of FeeObjB to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeObjB other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fee == other.Fee ||
                    Fee != null &&
                    Fee.Equals(other.Fee)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Fee != null)
                    hashCode = hashCode * 59 + Fee.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FeeObjB left, FeeObjB right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FeeObjB left, FeeObjB right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
