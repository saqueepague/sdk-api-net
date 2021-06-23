/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.1
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
    /// Informações da requisição de depósito.
    /// </summary>
    [DataContract]
    public partial class InfDepositoReq : IEquatable<InfDepositoReq>
    { 
        /// <summary>
        /// Código do banco utilizado na operação (3 dígitos).
        /// </summary>
        /// <value>Código do banco utilizado na operação (3 dígitos).</value>
        [DataMember(Name="codBanco")]
        public string CodBanco { get; set; }

        /// <summary>
        /// Número do CPF ou CNPJ do cliente realizando o depósito (11 dígitos ou 14 dígitos respectivamente).
        /// </summary>
        /// <value>Número do CPF ou CNPJ do cliente realizando o depósito (11 dígitos ou 14 dígitos respectivamente).</value>
        [DataMember(Name="cpfDepositante")]
        public string CpfDepositante { get; set; }

        /// <summary>
        /// Número do CPF ou CNPJ do cliente que receberá o depósito (11 dígitos ou 14 dígitos respectivamente).
        /// </summary>
        /// <value>Número do CPF ou CNPJ do cliente que receberá o depósito (11 dígitos ou 14 dígitos respectivamente).</value>
        [DataMember(Name="cpfFavorecido")]
        public string CpfFavorecido { get; set; }

        /// <summary>
        /// Número identificador do depósito (depósito identificado), caso seja informada necessidade na consulta de conta.
        /// </summary>
        /// <value>Número identificador do depósito (depósito identificado), caso seja informada necessidade na consulta de conta.</value>
        [DataMember(Name="identificacao")]
        public string Identificacao { get; set; }

        /// <summary>
        /// Nome do cliente realizando o depósito.
        /// </summary>
        /// <value>Nome do cliente realizando o depósito.</value>
        [DataMember(Name="nomeDepositante")]
        public string NomeDepositante { get; set; }

        /// <summary>
        /// Nome do cliente que receberá o depósito.
        /// </summary>
        /// <value>Nome do cliente que receberá o depósito.</value>
        [DataMember(Name="nomeFavorecido")]
        public string NomeFavorecido { get; set; }

        /// <summary>
        /// Número da agência utilizada na operação.
        /// </summary>
        /// <value>Número da agência utilizada na operação.</value>
        [DataMember(Name="numAgencia")]
        public string NumAgencia { get; set; }

        /// <summary>
        /// Número da conta utilizada na operação.
        /// </summary>
        /// <value>Número da conta utilizada na operação.</value>
        [DataMember(Name="numConta")]
        public string NumConta { get; set; }

        /// <summary>
        /// Telefone do cliente realizando o depósito (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).
        /// </summary>
        /// <value>Telefone do cliente realizando o depósito (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).</value>
        [DataMember(Name="telefoneDepositante")]
        public string TelefoneDepositante { get; set; }

        /// <summary>
        /// Telefone do cliente que receberá o depósito (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).
        /// </summary>
        /// <value>Telefone do cliente que receberá o depósito (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).</value>
        [DataMember(Name="telefoneFavorecido")]
        public string TelefoneFavorecido { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfDepositoReq {\n");
            sb.Append("  CodBanco: ").Append(CodBanco).Append("\n");
            sb.Append("  CpfDepositante: ").Append(CpfDepositante).Append("\n");
            sb.Append("  CpfFavorecido: ").Append(CpfFavorecido).Append("\n");
            sb.Append("  Identificacao: ").Append(Identificacao).Append("\n");
            sb.Append("  NomeDepositante: ").Append(NomeDepositante).Append("\n");
            sb.Append("  NomeFavorecido: ").Append(NomeFavorecido).Append("\n");
            sb.Append("  NumAgencia: ").Append(NumAgencia).Append("\n");
            sb.Append("  NumConta: ").Append(NumConta).Append("\n");
            sb.Append("  TelefoneDepositante: ").Append(TelefoneDepositante).Append("\n");
            sb.Append("  TelefoneFavorecido: ").Append(TelefoneFavorecido).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfDepositoReq)obj);
        }

        /// <summary>
        /// Returns true if InfDepositoReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfDepositoReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfDepositoReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CodBanco == other.CodBanco ||
                    CodBanco != null &&
                    CodBanco.Equals(other.CodBanco)
                ) && 
                (
                    CpfDepositante == other.CpfDepositante ||
                    CpfDepositante != null &&
                    CpfDepositante.Equals(other.CpfDepositante)
                ) && 
                (
                    CpfFavorecido == other.CpfFavorecido ||
                    CpfFavorecido != null &&
                    CpfFavorecido.Equals(other.CpfFavorecido)
                ) && 
                (
                    Identificacao == other.Identificacao ||
                    Identificacao != null &&
                    Identificacao.Equals(other.Identificacao)
                ) && 
                (
                    NomeDepositante == other.NomeDepositante ||
                    NomeDepositante != null &&
                    NomeDepositante.Equals(other.NomeDepositante)
                ) && 
                (
                    NomeFavorecido == other.NomeFavorecido ||
                    NomeFavorecido != null &&
                    NomeFavorecido.Equals(other.NomeFavorecido)
                ) && 
                (
                    NumAgencia == other.NumAgencia ||
                    NumAgencia != null &&
                    NumAgencia.Equals(other.NumAgencia)
                ) && 
                (
                    NumConta == other.NumConta ||
                    NumConta != null &&
                    NumConta.Equals(other.NumConta)
                ) && 
                (
                    TelefoneDepositante == other.TelefoneDepositante ||
                    TelefoneDepositante != null &&
                    TelefoneDepositante.Equals(other.TelefoneDepositante)
                ) && 
                (
                    TelefoneFavorecido == other.TelefoneFavorecido ||
                    TelefoneFavorecido != null &&
                    TelefoneFavorecido.Equals(other.TelefoneFavorecido)
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
                    if (CodBanco != null)
                    hashCode = hashCode * 59 + CodBanco.GetHashCode();
                    if (CpfDepositante != null)
                    hashCode = hashCode * 59 + CpfDepositante.GetHashCode();
                    if (CpfFavorecido != null)
                    hashCode = hashCode * 59 + CpfFavorecido.GetHashCode();
                    if (Identificacao != null)
                    hashCode = hashCode * 59 + Identificacao.GetHashCode();
                    if (NomeDepositante != null)
                    hashCode = hashCode * 59 + NomeDepositante.GetHashCode();
                    if (NomeFavorecido != null)
                    hashCode = hashCode * 59 + NomeFavorecido.GetHashCode();
                    if (NumAgencia != null)
                    hashCode = hashCode * 59 + NumAgencia.GetHashCode();
                    if (NumConta != null)
                    hashCode = hashCode * 59 + NumConta.GetHashCode();
                    if (TelefoneDepositante != null)
                    hashCode = hashCode * 59 + TelefoneDepositante.GetHashCode();
                    if (TelefoneFavorecido != null)
                    hashCode = hashCode * 59 + TelefoneFavorecido.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfDepositoReq left, InfDepositoReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfDepositoReq left, InfDepositoReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
