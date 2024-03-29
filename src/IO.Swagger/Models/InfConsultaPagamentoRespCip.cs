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
    /// Informações sobre o boleto da CIP.
    /// </summary>
    [DataContract]
    public partial class InfConsultaPagamentoRespCip : IEquatable<InfConsultaPagamentoRespCip>
    { 
        /// <summary>
        /// Valor dos juros calculados (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor dos juros calculados (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="valorJurosCalculado")]
        public string ValorJurosCalculado { get; set; }

        /// <summary>
        /// Valor da multa calculada (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor da multa calculada (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="valorMultaCalculadada")]
        public string ValorMultaCalculadada { get; set; }

        /// <summary>
        /// Valor em abatimentos calculado (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor em abatimentos calculado (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="valorAbatimento")]
        public string ValorAbatimento { get; set; }

        /// <summary>
        /// Tipo de valor aceito: 1 - Qualquer valor, 2 - Entre mínimo e máximo, 3 - Somente valor a pagar calculado e 4 - A partir do valor mínimo.
        /// </summary>
        /// <value>Tipo de valor aceito: 1 - Qualquer valor, 2 - Entre mínimo e máximo, 3 - Somente valor a pagar calculado e 4 - A partir do valor mínimo.</value>
        [DataMember(Name="tipoValorAceito")]
        public string TipoValorAceito { get; set; }

        /// <summary>
        /// Valor mínimo permitido de pagamento (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor mínimo permitido de pagamento (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorMinimoPermitidoPagamento")]
        public string ValorMinimoPermitidoPagamento { get; set; }

        /// <summary>
        /// Valor máximo permitido de pagamento (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor máximo permitido de pagamento (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorMaximoPermitidoPagamento")]
        public string ValorMaximoPermitidoPagamento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaPagamentoRespCip {\n");
            sb.Append("  ValorJurosCalculado: ").Append(ValorJurosCalculado).Append("\n");
            sb.Append("  ValorMultaCalculadada: ").Append(ValorMultaCalculadada).Append("\n");
            sb.Append("  ValorAbatimento: ").Append(ValorAbatimento).Append("\n");
            sb.Append("  TipoValorAceito: ").Append(TipoValorAceito).Append("\n");
            sb.Append("  ValorMinimoPermitidoPagamento: ").Append(ValorMinimoPermitidoPagamento).Append("\n");
            sb.Append("  ValorMaximoPermitidoPagamento: ").Append(ValorMaximoPermitidoPagamento).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaPagamentoRespCip)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaPagamentoRespCip instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaPagamentoRespCip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaPagamentoRespCip other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ValorJurosCalculado == other.ValorJurosCalculado ||
                    ValorJurosCalculado != null &&
                    ValorJurosCalculado.Equals(other.ValorJurosCalculado)
                ) && 
                (
                    ValorMultaCalculadada == other.ValorMultaCalculadada ||
                    ValorMultaCalculadada != null &&
                    ValorMultaCalculadada.Equals(other.ValorMultaCalculadada)
                ) && 
                (
                    ValorAbatimento == other.ValorAbatimento ||
                    ValorAbatimento != null &&
                    ValorAbatimento.Equals(other.ValorAbatimento)
                ) && 
                (
                    TipoValorAceito == other.TipoValorAceito ||
                    TipoValorAceito != null &&
                    TipoValorAceito.Equals(other.TipoValorAceito)
                ) && 
                (
                    ValorMinimoPermitidoPagamento == other.ValorMinimoPermitidoPagamento ||
                    ValorMinimoPermitidoPagamento != null &&
                    ValorMinimoPermitidoPagamento.Equals(other.ValorMinimoPermitidoPagamento)
                ) && 
                (
                    ValorMaximoPermitidoPagamento == other.ValorMaximoPermitidoPagamento ||
                    ValorMaximoPermitidoPagamento != null &&
                    ValorMaximoPermitidoPagamento.Equals(other.ValorMaximoPermitidoPagamento)
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
                    if (ValorJurosCalculado != null)
                    hashCode = hashCode * 59 + ValorJurosCalculado.GetHashCode();
                    if (ValorMultaCalculadada != null)
                    hashCode = hashCode * 59 + ValorMultaCalculadada.GetHashCode();
                    if (ValorAbatimento != null)
                    hashCode = hashCode * 59 + ValorAbatimento.GetHashCode();
                    if (TipoValorAceito != null)
                    hashCode = hashCode * 59 + TipoValorAceito.GetHashCode();
                    if (ValorMinimoPermitidoPagamento != null)
                    hashCode = hashCode * 59 + ValorMinimoPermitidoPagamento.GetHashCode();
                    if (ValorMaximoPermitidoPagamento != null)
                    hashCode = hashCode * 59 + ValorMaximoPermitidoPagamento.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaPagamentoRespCip left, InfConsultaPagamentoRespCip right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaPagamentoRespCip left, InfConsultaPagamentoRespCip right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
