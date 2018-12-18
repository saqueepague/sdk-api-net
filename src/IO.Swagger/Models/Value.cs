/*
 * Saque e Pague Transaction
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.17.0
 * Contact: captura_atm@saqueepague.com.br
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
    public partial class Value : IEquatable<Value>
    { 
        /// <summary>
        /// Identificador do valor.
        /// </summary>
        /// <value>Identificador do valor.</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Identificador do valor.
        /// </summary>
        /// <value>Identificador do valor.</value>
        [DataMember(Name="value")]
        public string _Value { get; set; }

        /// <summary>
        /// Taxa do valor.
        /// </summary>
        /// <value>Taxa do valor.</value>
        [DataMember(Name="fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Value {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Value: ").Append(_Value).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Value)obj);
        }

        /// <summary>
        /// Returns true if Value instances are equal
        /// </summary>
        /// <param name="other">Instance of Value to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Value other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    _Value == other._Value ||
                    _Value != null &&
                    _Value.Equals(other._Value)
                ) && 
                (
                    Fee == other.Fee ||
                    Fee != null &&
                    Fee.Equals(other.Fee)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (_Value != null)
                    hashCode = hashCode * 59 + _Value.GetHashCode();
                    if (Fee != null)
                    hashCode = hashCode * 59 + Fee.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Value left, Value right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Value left, Value right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
