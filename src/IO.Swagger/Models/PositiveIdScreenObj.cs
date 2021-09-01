/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.6
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
    /// Lista de conjuntos de letras/sílabas para o usuário selecionar, antes de uma transação. Cada posição é análoga a um botão mostrado, em posição aleatória, nesta tela. Contudo a resposta mandada na transação manterá a posição original retornada por este objeto.
    /// </summary>
    [DataContract]
    public partial class PositiveIdScreenObj : IEquatable<PositiveIdScreenObj>
    { 
        /// <summary>
        /// Identificador da tela.
        /// </summary>
        /// <value>Identificador da tela.</value>
        [Required]
        [DataMember(Name="idTela")]
        public string IdTela { get; set; }

        /// <summary>
        /// Gets or Sets Pos1
        /// </summary>
        [Required]
        [DataMember(Name="pos1")]
        public string Pos1 { get; set; }

        /// <summary>
        /// Gets or Sets Pos2
        /// </summary>
        [Required]
        [DataMember(Name="pos2")]
        public string Pos2 { get; set; }

        /// <summary>
        /// Gets or Sets Pos3
        /// </summary>
        [Required]
        [DataMember(Name="pos3")]
        public string Pos3 { get; set; }

        /// <summary>
        /// Gets or Sets Pos4
        /// </summary>
        [Required]
        [DataMember(Name="pos4")]
        public string Pos4 { get; set; }

        /// <summary>
        /// Gets or Sets Pos5
        /// </summary>
        [DataMember(Name="pos5")]
        public string Pos5 { get; set; }

        /// <summary>
        /// Gets or Sets Pos6
        /// </summary>
        [DataMember(Name="pos6")]
        public string Pos6 { get; set; }

        /// <summary>
        /// Gets or Sets Pos7
        /// </summary>
        [DataMember(Name="pos7")]
        public string Pos7 { get; set; }

        /// <summary>
        /// Gets or Sets Pos8
        /// </summary>
        [DataMember(Name="pos8")]
        public string Pos8 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PositiveIdScreenObj {\n");
            sb.Append("  IdTela: ").Append(IdTela).Append("\n");
            sb.Append("  Pos1: ").Append(Pos1).Append("\n");
            sb.Append("  Pos2: ").Append(Pos2).Append("\n");
            sb.Append("  Pos3: ").Append(Pos3).Append("\n");
            sb.Append("  Pos4: ").Append(Pos4).Append("\n");
            sb.Append("  Pos5: ").Append(Pos5).Append("\n");
            sb.Append("  Pos6: ").Append(Pos6).Append("\n");
            sb.Append("  Pos7: ").Append(Pos7).Append("\n");
            sb.Append("  Pos8: ").Append(Pos8).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PositiveIdScreenObj)obj);
        }

        /// <summary>
        /// Returns true if PositiveIdScreenObj instances are equal
        /// </summary>
        /// <param name="other">Instance of PositiveIdScreenObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PositiveIdScreenObj other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdTela == other.IdTela ||
                    IdTela != null &&
                    IdTela.Equals(other.IdTela)
                ) && 
                (
                    Pos1 == other.Pos1 ||
                    Pos1 != null &&
                    Pos1.Equals(other.Pos1)
                ) && 
                (
                    Pos2 == other.Pos2 ||
                    Pos2 != null &&
                    Pos2.Equals(other.Pos2)
                ) && 
                (
                    Pos3 == other.Pos3 ||
                    Pos3 != null &&
                    Pos3.Equals(other.Pos3)
                ) && 
                (
                    Pos4 == other.Pos4 ||
                    Pos4 != null &&
                    Pos4.Equals(other.Pos4)
                ) && 
                (
                    Pos5 == other.Pos5 ||
                    Pos5 != null &&
                    Pos5.Equals(other.Pos5)
                ) && 
                (
                    Pos6 == other.Pos6 ||
                    Pos6 != null &&
                    Pos6.Equals(other.Pos6)
                ) && 
                (
                    Pos7 == other.Pos7 ||
                    Pos7 != null &&
                    Pos7.Equals(other.Pos7)
                ) && 
                (
                    Pos8 == other.Pos8 ||
                    Pos8 != null &&
                    Pos8.Equals(other.Pos8)
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
                    if (IdTela != null)
                    hashCode = hashCode * 59 + IdTela.GetHashCode();
                    if (Pos1 != null)
                    hashCode = hashCode * 59 + Pos1.GetHashCode();
                    if (Pos2 != null)
                    hashCode = hashCode * 59 + Pos2.GetHashCode();
                    if (Pos3 != null)
                    hashCode = hashCode * 59 + Pos3.GetHashCode();
                    if (Pos4 != null)
                    hashCode = hashCode * 59 + Pos4.GetHashCode();
                    if (Pos5 != null)
                    hashCode = hashCode * 59 + Pos5.GetHashCode();
                    if (Pos6 != null)
                    hashCode = hashCode * 59 + Pos6.GetHashCode();
                    if (Pos7 != null)
                    hashCode = hashCode * 59 + Pos7.GetHashCode();
                    if (Pos8 != null)
                    hashCode = hashCode * 59 + Pos8.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PositiveIdScreenObj left, PositiveIdScreenObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PositiveIdScreenObj left, PositiveIdScreenObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
