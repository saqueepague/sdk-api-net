/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.6
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
    public partial class ConsultaPagamentoResp : IEquatable<ConsultaPagamentoResp>
    { 
        /// <summary>
        /// Gets or Sets InfTransacao
        /// </summary>
        [Required]
        [DataMember(Name="InfTransacao")]
        public InfTransacaoResp InfTransacao { get; set; }

        /// <summary>
        /// Gets or Sets Terminal
        /// </summary>
        [Required]
        [DataMember(Name="Terminal")]
        public Terminal Terminal { get; set; }

        /// <summary>
        /// Gets or Sets Cripto
        /// </summary>
        [DataMember(Name="Cripto")]
        public CriptoResp Cripto { get; set; }

        /// <summary>
        /// Gets or Sets InfConsultaPagamento
        /// </summary>
        [Required]
        [DataMember(Name="InfConsultaPagamento")]
        public InfConsultaPagamentoResp InfConsultaPagamento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultaPagamentoResp {\n");
            sb.Append("  InfTransacao: ").Append(InfTransacao).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  Cripto: ").Append(Cripto).Append("\n");
            sb.Append("  InfConsultaPagamento: ").Append(InfConsultaPagamento).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConsultaPagamentoResp)obj);
        }

        /// <summary>
        /// Returns true if ConsultaPagamentoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultaPagamentoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultaPagamentoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InfTransacao == other.InfTransacao ||
                    InfTransacao != null &&
                    InfTransacao.Equals(other.InfTransacao)
                ) && 
                (
                    Terminal == other.Terminal ||
                    Terminal != null &&
                    Terminal.Equals(other.Terminal)
                ) && 
                (
                    Cripto == other.Cripto ||
                    Cripto != null &&
                    Cripto.Equals(other.Cripto)
                ) && 
                (
                    InfConsultaPagamento == other.InfConsultaPagamento ||
                    InfConsultaPagamento != null &&
                    InfConsultaPagamento.Equals(other.InfConsultaPagamento)
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
                    if (InfTransacao != null)
                    hashCode = hashCode * 59 + InfTransacao.GetHashCode();
                    if (Terminal != null)
                    hashCode = hashCode * 59 + Terminal.GetHashCode();
                    if (Cripto != null)
                    hashCode = hashCode * 59 + Cripto.GetHashCode();
                    if (InfConsultaPagamento != null)
                    hashCode = hashCode * 59 + InfConsultaPagamento.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConsultaPagamentoResp left, ConsultaPagamentoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConsultaPagamentoResp left, ConsultaPagamentoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
