/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.8
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
    public partial class InfPagamentoResp : IEquatable<InfPagamentoResp>
    { 
        /// <summary>
        /// Valor atualizado pelo parceiro (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor atualizado pelo parceiro (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Cedente (beneficiário).
        /// </summary>
        /// <value>Cedente (beneficiário).</value>
        [Required]
        [DataMember(Name="cedente")]
        public string Cedente { get; set; }

        /// <summary>
        /// Data de pagamento atualizada pelo parceiro (AAAAMMDD).
        /// </summary>
        /// <value>Data de pagamento atualizada pelo parceiro (AAAAMMDD).</value>
        [Required]
        [DataMember(Name="dataPagamento")]
        public string DataPagamento { get; set; }

        /// <summary>
        /// Mensagem informativa quanto à alteração de valores e/ou data de pagamento pelo paceiro.
        /// </summary>
        /// <value>Mensagem informativa quanto à alteração de valores e/ou data de pagamento pelo paceiro.</value>
        [DataMember(Name="mensagem")]
        public string Mensagem { get; set; }

        /// <summary>
        /// Quantidade de vias para impressão do Comprovante.
        /// </summary>
        /// <value>Quantidade de vias para impressão do Comprovante.</value>
        [Required]
        [DataMember(Name="qtdeViasComprovante")]
        public string QtdeViasComprovante { get; set; }

        /// <summary>
        /// Valor do desconto (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do desconto (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="desconto")]
        public string Desconto { get; set; }

        /// <summary>
        /// Recibo da transação de pagamento. Linhas com 48 posições separadas por \&quot;@\&quot;.
        /// </summary>
        /// <value>Recibo da transação de pagamento. Linhas com 48 posições separadas por \&quot;@\&quot;.</value>
        [Required]
        [DataMember(Name="recibo")]
        public string Recibo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfPagamentoResp {\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Cedente: ").Append(Cedente).Append("\n");
            sb.Append("  DataPagamento: ").Append(DataPagamento).Append("\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  QtdeViasComprovante: ").Append(QtdeViasComprovante).Append("\n");
            sb.Append("  Desconto: ").Append(Desconto).Append("\n");
            sb.Append("  Recibo: ").Append(Recibo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfPagamentoResp)obj);
        }

        /// <summary>
        /// Returns true if InfPagamentoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfPagamentoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfPagamentoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Valor == other.Valor ||
                    Valor != null &&
                    Valor.Equals(other.Valor)
                ) && 
                (
                    Cedente == other.Cedente ||
                    Cedente != null &&
                    Cedente.Equals(other.Cedente)
                ) && 
                (
                    DataPagamento == other.DataPagamento ||
                    DataPagamento != null &&
                    DataPagamento.Equals(other.DataPagamento)
                ) && 
                (
                    Mensagem == other.Mensagem ||
                    Mensagem != null &&
                    Mensagem.Equals(other.Mensagem)
                ) && 
                (
                    QtdeViasComprovante == other.QtdeViasComprovante ||
                    QtdeViasComprovante != null &&
                    QtdeViasComprovante.Equals(other.QtdeViasComprovante)
                ) && 
                (
                    Desconto == other.Desconto ||
                    Desconto != null &&
                    Desconto.Equals(other.Desconto)
                ) && 
                (
                    Recibo == other.Recibo ||
                    Recibo != null &&
                    Recibo.Equals(other.Recibo)
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
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                    if (Cedente != null)
                    hashCode = hashCode * 59 + Cedente.GetHashCode();
                    if (DataPagamento != null)
                    hashCode = hashCode * 59 + DataPagamento.GetHashCode();
                    if (Mensagem != null)
                    hashCode = hashCode * 59 + Mensagem.GetHashCode();
                    if (QtdeViasComprovante != null)
                    hashCode = hashCode * 59 + QtdeViasComprovante.GetHashCode();
                    if (Desconto != null)
                    hashCode = hashCode * 59 + Desconto.GetHashCode();
                    if (Recibo != null)
                    hashCode = hashCode * 59 + Recibo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfPagamentoResp left, InfPagamentoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfPagamentoResp left, InfPagamentoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
