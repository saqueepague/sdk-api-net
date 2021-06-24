/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.3
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
    /// Informações sobre o terminal vigente.
    /// </summary>
    [DataContract]
    public partial class Terminal : IEquatable<Terminal>
    { 
        /// <summary>
        /// Código do estabelecimento onde está localizado o terminal gerado pela Saque e Pague (15 dígitos).
        /// </summary>
        /// <value>Código do estabelecimento onde está localizado o terminal gerado pela Saque e Pague (15 dígitos).</value>
        [Required]
        [DataMember(Name="codEstab")]
        public string CodEstab { get; set; }

        /// <summary>
        /// Identificador do terminal gerado pela Saque e Pague (8 dígitos).
        /// </summary>
        /// <value>Identificador do terminal gerado pela Saque e Pague (8 dígitos).</value>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Tipo de terminal o qual a operação é gerada (3 dígitos, 008 &#x3D; ATM).
        /// </summary>
        /// <value>Tipo de terminal o qual a operação é gerada (3 dígitos, 008 &#x3D; ATM).</value>
        [DataMember(Name="tipo")]
        public string Tipo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Terminal {\n");
            sb.Append("  CodEstab: ").Append(CodEstab).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Terminal)obj);
        }

        /// <summary>
        /// Returns true if Terminal instances are equal
        /// </summary>
        /// <param name="other">Instance of Terminal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Terminal other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CodEstab == other.CodEstab ||
                    CodEstab != null &&
                    CodEstab.Equals(other.CodEstab)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Tipo == other.Tipo ||
                    Tipo != null &&
                    Tipo.Equals(other.Tipo)
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
                    if (CodEstab != null)
                    hashCode = hashCode * 59 + CodEstab.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Tipo != null)
                    hashCode = hashCode * 59 + Tipo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Terminal left, Terminal right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Terminal left, Terminal right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
