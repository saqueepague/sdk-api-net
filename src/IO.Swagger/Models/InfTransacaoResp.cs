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
    /// Informações sobre a resposta da requisição de transação.
    /// </summary>
    [DataContract]
    public partial class InfTransacaoResp : IEquatable<InfTransacaoResp>
    { 
        /// <summary>
        /// Igual à requisição.
        /// </summary>
        /// <value>Igual à requisição.</value>
        [Required]
        [DataMember(Name="cdProc")]
        public string CdProc { get; set; }

        /// <summary>
        /// Igual à requisição com exceção da transação de consultaSaque.
        /// </summary>
        /// <value>Igual à requisição com exceção da transação de consultaSaque.</value>
        [DataMember(Name="codMoeda")]
        public string CodMoeda { get; set; }

        /// <summary>
        /// Igual à requisição.
        /// </summary>
        /// <value>Igual à requisição.</value>
        [Required]
        [DataMember(Name="codOperadora")]
        public string CodOperadora { get; set; }

        /// <summary>
        /// Data e hora da transação (MMDDhhmmss).
        /// </summary>
        /// <value>Data e hora da transação (MMDDhhmmss).</value>
        [Required]
        [DataMember(Name="dataHora")]
        public string DataHora { get; set; }

        /// <summary>
        /// Igual à requisição.
        /// </summary>
        /// <value>Igual à requisição.</value>
        [Required]
        [DataMember(Name="dataLocal")]
        public string DataLocal { get; set; }

        /// <summary>
        /// Caso ocorra erro, este campo preenchido identifica que um erro ocorreu e seu valor.
        /// </summary>
        /// <value>Caso ocorra erro, este campo preenchido identifica que um erro ocorreu e seu valor.</value>
        [DataMember(Name="errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Igual à requisição.
        /// </summary>
        /// <value>Igual à requisição.</value>
        [Required]
        [DataMember(Name="horaLocal")]
        public string HoraLocal { get; set; }

        /// <summary>
        /// Mensagem para ser mostrada na tela para o cliente, em caso de erro (objeto errorMessage deve estar preenchido para identificação de um erro).
        /// </summary>
        /// <value>Mensagem para ser mostrada na tela para o cliente, em caso de erro (objeto errorMessage deve estar preenchido para identificação de um erro).</value>
        [DataMember(Name="mensagemCliente")]
        public string MensagemCliente { get; set; }

        /// <summary>
        /// Igual à requisição.
        /// </summary>
        /// <value>Igual à requisição.</value>
        [Required]
        [DataMember(Name="nsu")]
        public string Nsu { get; set; }

        /// <summary>
        /// Identificador da resposta da transação, gerado pelo autorizador.
        /// </summary>
        /// <value>Identificador da resposta da transação, gerado pelo autorizador.</value>
        [Required]
        [DataMember(Name="nsuResposta")]
        public string NsuResposta { get; set; }

        /// <summary>
        /// Igual à requisição com exceção da transação de consultaSaldo e consultaSaque.
        /// </summary>
        /// <value>Igual à requisição com exceção da transação de consultaSaldo e consultaSaque.</value>
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfTransacaoResp {\n");
            sb.Append("  CdProc: ").Append(CdProc).Append("\n");
            sb.Append("  CodMoeda: ").Append(CodMoeda).Append("\n");
            sb.Append("  CodOperadora: ").Append(CodOperadora).Append("\n");
            sb.Append("  DataHora: ").Append(DataHora).Append("\n");
            sb.Append("  DataLocal: ").Append(DataLocal).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HoraLocal: ").Append(HoraLocal).Append("\n");
            sb.Append("  MensagemCliente: ").Append(MensagemCliente).Append("\n");
            sb.Append("  Nsu: ").Append(Nsu).Append("\n");
            sb.Append("  NsuResposta: ").Append(NsuResposta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfTransacaoResp)obj);
        }

        /// <summary>
        /// Returns true if InfTransacaoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfTransacaoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfTransacaoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CdProc == other.CdProc ||
                    CdProc != null &&
                    CdProc.Equals(other.CdProc)
                ) && 
                (
                    CodMoeda == other.CodMoeda ||
                    CodMoeda != null &&
                    CodMoeda.Equals(other.CodMoeda)
                ) && 
                (
                    CodOperadora == other.CodOperadora ||
                    CodOperadora != null &&
                    CodOperadora.Equals(other.CodOperadora)
                ) && 
                (
                    DataHora == other.DataHora ||
                    DataHora != null &&
                    DataHora.Equals(other.DataHora)
                ) && 
                (
                    DataLocal == other.DataLocal ||
                    DataLocal != null &&
                    DataLocal.Equals(other.DataLocal)
                ) && 
                (
                    ErrorMessage == other.ErrorMessage ||
                    ErrorMessage != null &&
                    ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    HoraLocal == other.HoraLocal ||
                    HoraLocal != null &&
                    HoraLocal.Equals(other.HoraLocal)
                ) && 
                (
                    MensagemCliente == other.MensagemCliente ||
                    MensagemCliente != null &&
                    MensagemCliente.Equals(other.MensagemCliente)
                ) && 
                (
                    Nsu == other.Nsu ||
                    Nsu != null &&
                    Nsu.Equals(other.Nsu)
                ) && 
                (
                    NsuResposta == other.NsuResposta ||
                    NsuResposta != null &&
                    NsuResposta.Equals(other.NsuResposta)
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
                    if (CdProc != null)
                    hashCode = hashCode * 59 + CdProc.GetHashCode();
                    if (CodMoeda != null)
                    hashCode = hashCode * 59 + CodMoeda.GetHashCode();
                    if (CodOperadora != null)
                    hashCode = hashCode * 59 + CodOperadora.GetHashCode();
                    if (DataHora != null)
                    hashCode = hashCode * 59 + DataHora.GetHashCode();
                    if (DataLocal != null)
                    hashCode = hashCode * 59 + DataLocal.GetHashCode();
                    if (ErrorMessage != null)
                    hashCode = hashCode * 59 + ErrorMessage.GetHashCode();
                    if (HoraLocal != null)
                    hashCode = hashCode * 59 + HoraLocal.GetHashCode();
                    if (MensagemCliente != null)
                    hashCode = hashCode * 59 + MensagemCliente.GetHashCode();
                    if (Nsu != null)
                    hashCode = hashCode * 59 + Nsu.GetHashCode();
                    if (NsuResposta != null)
                    hashCode = hashCode * 59 + NsuResposta.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfTransacaoResp left, InfTransacaoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfTransacaoResp left, InfTransacaoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
