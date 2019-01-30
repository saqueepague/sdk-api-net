/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.17.1-sw2
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
        /// Cedente.
        /// </summary>
        /// <value>Cedente.</value>
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
        /// Valor do desconto (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do desconto (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="desconto")]
        public string Desconto { get; set; }

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
        /// Recibo do pagamento. Linhas com 48 posições separadas por \&quot;@\&quot;.
        /// </summary>
        /// <value>Recibo do pagamento. Linhas com 48 posições separadas por \&quot;@\&quot;.</value>
        [Required]
        [DataMember(Name="recibo")]
        public string Recibo { get; set; }

        /// <summary>
        /// Informa se foi usado o novo sistema de cobrança de contas (00 = não, 01 = sim).
        /// </summary>
        /// <value>Informa se foi usado o novo sistema de cobrança de contas (00 = não, 01 = sim).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SistemaCobrancaEnum
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
        /// Informa se foi usado o novo sistema de cobrança de contas (00 &#x3D; não, 01 &#x3D; sim).
        /// </summary>
        /// <value>Informa se foi usado o novo sistema de cobrança de contas (00 &#x3D; não, 01 &#x3D; sim).</value>
        [Required]
        [DataMember(Name="sistemaCobranca")]
        public SistemaCobrancaEnum? SistemaCobranca { get; set; }

        /// <summary>
        /// Valor atualizado pelo parceiro (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor atualizado pelo parceiro (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfPagamentoResp {\n");
            sb.Append("  Cedente: ").Append(Cedente).Append("\n");
            sb.Append("  DataPagamento: ").Append(DataPagamento).Append("\n");
            sb.Append("  Desconto: ").Append(Desconto).Append("\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  QtdeViasComprovante: ").Append(QtdeViasComprovante).Append("\n");
            sb.Append("  Recibo: ").Append(Recibo).Append("\n");
            sb.Append("  SistemaCobranca: ").Append(SistemaCobranca).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
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
                    Desconto == other.Desconto ||
                    Desconto != null &&
                    Desconto.Equals(other.Desconto)
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
                    Recibo == other.Recibo ||
                    Recibo != null &&
                    Recibo.Equals(other.Recibo)
                ) && 
                (
                    SistemaCobranca == other.SistemaCobranca ||
                    SistemaCobranca != null &&
                    SistemaCobranca.Equals(other.SistemaCobranca)
                ) && 
                (
                    Valor == other.Valor ||
                    Valor != null &&
                    Valor.Equals(other.Valor)
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
                    if (Cedente != null)
                    hashCode = hashCode * 59 + Cedente.GetHashCode();
                    if (DataPagamento != null)
                    hashCode = hashCode * 59 + DataPagamento.GetHashCode();
                    if (Desconto != null)
                    hashCode = hashCode * 59 + Desconto.GetHashCode();
                    if (Mensagem != null)
                    hashCode = hashCode * 59 + Mensagem.GetHashCode();
                    if (QtdeViasComprovante != null)
                    hashCode = hashCode * 59 + QtdeViasComprovante.GetHashCode();
                    if (Recibo != null)
                    hashCode = hashCode * 59 + Recibo.GetHashCode();
                    if (SistemaCobranca != null)
                    hashCode = hashCode * 59 + SistemaCobranca.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
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
