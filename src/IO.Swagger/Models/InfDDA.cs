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
    /// Informações de retorno para consultas de DDA.
    /// </summary>
    [DataContract]
    public partial class InfDDA : IEquatable<InfDDA>
    { 
        /// <summary>
        /// Número ID DDA.
        /// </summary>
        /// <value>Número ID DDA.</value>
        [DataMember(Name="numDDA")]
        public string NumDDA { get; set; }

        /// <summary>
        /// Cedente (até 40 caracteres).
        /// </summary>
        /// <value>Cedente (até 40 caracteres).</value>
        [DataMember(Name="cedente")]
        public string Cedente { get; set; }

        /// <summary>
        /// Sacado.
        /// </summary>
        /// <value>Sacado.</value>
        [DataMember(Name="sacado")]
        public string Sacado { get; set; }

        /// <summary>
        /// Data de vencimento (AAAAMMDD).
        /// </summary>
        /// <value>Data de vencimento (AAAAMMDD).</value>
        [DataMember(Name="dataVencimento")]
        public string DataVencimento { get; set; }

        /// <summary>
        /// Valor do DDA (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do DDA (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Tipo da DDA.
        /// </summary>
        /// <value>Tipo da DDA.</value>
        [DataMember(Name="tipo")]
        public string Tipo { get; set; }
        /// <summary>
        /// Gets or Sets Modificado
        /// </summary>
        public enum eModificado
        { 
            /// <summary>
            /// Enum _00Enum for 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00Enum = 1,
            
            /// <summary>
            /// Enum _01Enum for 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01Enum = 2
        }

        /// <summary>
        /// Gets or Sets Modificado
        /// </summary>
        [DataMember(Name="modificado")]
        public eModificado? Modificado { get; set; }

        /// <summary>
        /// Alegação.
        /// </summary>
        /// <value>Alegação.</value>
        [DataMember(Name="alegacao")]
        public string Alegacao { get; set; }
        /// <summary>
        /// Gets or Sets AceitaPagamentoParcial
        /// </summary>
        public enum eAceitaPagamentoParcial1
        { 
            /// <summary>
            /// Enum _00Enum for 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00Enum = 1,
            
            /// <summary>
            /// Enum _01Enum for 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01Enum = 2
        }

        /// <summary>
        /// Gets or Sets AceitaPagamentoParcial
        /// </summary>
        [DataMember(Name="aceitaPagamentoParcial")]
        public eAceitaPagamentoParcial1? AceitaPagamentoParcial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfDDA {\n");
            sb.Append("  NumDDA: ").Append(NumDDA).Append("\n");
            sb.Append("  Cedente: ").Append(Cedente).Append("\n");
            sb.Append("  Sacado: ").Append(Sacado).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Modificado: ").Append(Modificado).Append("\n");
            sb.Append("  Alegacao: ").Append(Alegacao).Append("\n");
            sb.Append("  AceitaPagamentoParcial: ").Append(AceitaPagamentoParcial).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfDDA)obj);
        }

        /// <summary>
        /// Returns true if InfDDA instances are equal
        /// </summary>
        /// <param name="other">Instance of InfDDA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfDDA other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NumDDA == other.NumDDA ||
                    NumDDA != null &&
                    NumDDA.Equals(other.NumDDA)
                ) && 
                (
                    Cedente == other.Cedente ||
                    Cedente != null &&
                    Cedente.Equals(other.Cedente)
                ) && 
                (
                    Sacado == other.Sacado ||
                    Sacado != null &&
                    Sacado.Equals(other.Sacado)
                ) && 
                (
                    DataVencimento == other.DataVencimento ||
                    DataVencimento != null &&
                    DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    Valor == other.Valor ||
                    Valor != null &&
                    Valor.Equals(other.Valor)
                ) && 
                (
                    Tipo == other.Tipo ||
                    Tipo != null &&
                    Tipo.Equals(other.Tipo)
                ) && 
                (
                    Modificado == other.Modificado ||
                    Modificado != null &&
                    Modificado.Equals(other.Modificado)
                ) && 
                (
                    Alegacao == other.Alegacao ||
                    Alegacao != null &&
                    Alegacao.Equals(other.Alegacao)
                ) && 
                (
                    AceitaPagamentoParcial == other.AceitaPagamentoParcial ||
                    AceitaPagamentoParcial != null &&
                    AceitaPagamentoParcial.Equals(other.AceitaPagamentoParcial)
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
                    if (NumDDA != null)
                    hashCode = hashCode * 59 + NumDDA.GetHashCode();
                    if (Cedente != null)
                    hashCode = hashCode * 59 + Cedente.GetHashCode();
                    if (Sacado != null)
                    hashCode = hashCode * 59 + Sacado.GetHashCode();
                    if (DataVencimento != null)
                    hashCode = hashCode * 59 + DataVencimento.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                    if (Tipo != null)
                    hashCode = hashCode * 59 + Tipo.GetHashCode();
                    if (Modificado != null)
                    hashCode = hashCode * 59 + Modificado.GetHashCode();
                    if (Alegacao != null)
                    hashCode = hashCode * 59 + Alegacao.GetHashCode();
                    if (AceitaPagamentoParcial != null)
                    hashCode = hashCode * 59 + AceitaPagamentoParcial.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfDDA left, InfDDA right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfDDA left, InfDDA right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
