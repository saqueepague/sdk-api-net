/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.28.2
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
    public partial class InstallmentsOptionObj : IEquatable<InstallmentsOptionObj>
    { 
        /// <summary>
        /// Quantidade de parcelas do empréstimo.
        /// </summary>
        /// <value>Quantidade de parcelas do empréstimo.</value>
        [Required]
        [DataMember(Name="qntParcelas")]
        public string QntParcelas { get; set; }

        /// <summary>
        /// Valor de cada parcela do empréstimo (12 dígitos).
        /// </summary>
        /// <value>Valor de cada parcela do empréstimo (12 dígitos).</value>
        [Required]
        [DataMember(Name="valorParcela")]
        public string ValorParcela { get; set; }

        /// <summary>
        /// Gets or Sets Tributos
        /// </summary>
        [Required]
        [DataMember(Name="tributos")]
        public InstallmentsOptionObjTributos Tributos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallmentsOptionObj {\n");
            sb.Append("  QntParcelas: ").Append(QntParcelas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  Tributos: ").Append(Tributos).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstallmentsOptionObj)obj);
        }

        /// <summary>
        /// Returns true if InstallmentsOptionObj instances are equal
        /// </summary>
        /// <param name="other">Instance of InstallmentsOptionObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentsOptionObj other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    QntParcelas == other.QntParcelas ||
                    QntParcelas != null &&
                    QntParcelas.Equals(other.QntParcelas)
                ) && 
                (
                    ValorParcela == other.ValorParcela ||
                    ValorParcela != null &&
                    ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    Tributos == other.Tributos ||
                    Tributos != null &&
                    Tributos.Equals(other.Tributos)
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
                    if (QntParcelas != null)
                    hashCode = hashCode * 59 + QntParcelas.GetHashCode();
                    if (ValorParcela != null)
                    hashCode = hashCode * 59 + ValorParcela.GetHashCode();
                    if (Tributos != null)
                    hashCode = hashCode * 59 + Tributos.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstallmentsOptionObj left, InstallmentsOptionObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstallmentsOptionObj left, InstallmentsOptionObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
