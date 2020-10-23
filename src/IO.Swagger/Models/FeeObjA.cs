/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.11
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
    public partial class FeeObjA : IEquatable<FeeObjA>
    { 
        /// <summary>
        /// Taxa da recarga para a faixa de valor determinada.
        /// </summary>
        /// <value>Taxa da recarga para a faixa de valor determinada.</value>
        [Required]
        [DataMember(Name="fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Número identificador do produto.
        /// </summary>
        /// <value>Número identificador do produto.</value>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Limite superior de valor de recarga para aplicação desta taxa (fee).
        /// </summary>
        /// <value>Limite superior de valor de recarga para aplicação desta taxa (fee).</value>
        [Required]
        [DataMember(Name="max_value")]
        public string MaxValue { get; set; }

        /// <summary>
        /// Limite inferior de valor de recarga para aplicação desta taxa (fee).
        /// </summary>
        /// <value>Limite inferior de valor de recarga para aplicação desta taxa (fee).</value>
        [Required]
        [DataMember(Name="min_value")]
        public string MinValue { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        /// <value>Nome do produto.</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values")]
        public List<FeeObjB> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeObjA {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FeeObjA)obj);
        }

        /// <summary>
        /// Returns true if FeeObjA instances are equal
        /// </summary>
        /// <param name="other">Instance of FeeObjA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeObjA other)
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
                    MaxValue == other.MaxValue ||
                    MaxValue != null &&
                    MaxValue.Equals(other.MaxValue)
                ) && 
                (
                    MinValue == other.MinValue ||
                    MinValue != null &&
                    MinValue.Equals(other.MinValue)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Values == other.Values ||
                    Values != null &&
                    Values.SequenceEqual(other.Values)
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
                    if (MaxValue != null)
                    hashCode = hashCode * 59 + MaxValue.GetHashCode();
                    if (MinValue != null)
                    hashCode = hashCode * 59 + MinValue.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FeeObjA left, FeeObjA right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FeeObjA left, FeeObjA right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
