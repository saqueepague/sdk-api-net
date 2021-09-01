/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.5
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
    /// Informações sobre cada favorecido. (Manter o campo VAZIO, por compatibilidade, caso não exista informação).
    /// </summary>
    [DataContract]
    public partial class FavorecidoListaObj : IEquatable<FavorecidoListaObj>
    { 
        /// <summary>
        /// Código do banco do Favorecido Cadastrado (3 dígitos).
        /// </summary>
        /// <value>Código do banco do Favorecido Cadastrado (3 dígitos).</value>
        [DataMember(Name="codBanco")]
        public string CodBanco { get; set; }

        /// <summary>
        /// Nome do Banco Favorecido Cadastrado (sem acento).
        /// </summary>
        /// <value>Nome do Banco Favorecido Cadastrado (sem acento).</value>
        [DataMember(Name="nomeBanco")]
        public string NomeBanco { get; set; }

        /// <summary>
        /// Número da agência do Favorecido Cadastrado.
        /// </summary>
        /// <value>Número da agência do Favorecido Cadastrado.</value>
        [DataMember(Name="numAgencia")]
        public string NumAgencia { get; set; }

        /// <summary>
        /// Número da conta do Favorecido Cadastrado.
        /// </summary>
        /// <value>Número da conta do Favorecido Cadastrado.</value>
        [DataMember(Name="numConta")]
        public string NumConta { get; set; }

        /// <summary>
        /// Tipo de conta do extrato do Favorecido Cadastrado (CC = conta corrente, CP = conta poupança).
        /// </summary>
        /// <value>Tipo de conta do extrato do Favorecido Cadastrado (CC = conta corrente, CP = conta poupança).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TipoContaEnum
        {
            
            /// <summary>
            /// Enum CCEnum for CC
            /// </summary>
            [EnumMember(Value = "CC")]
            CCEnum = 1,
            
            /// <summary>
            /// Enum CPEnum for CP
            /// </summary>
            [EnumMember(Value = "CP")]
            CPEnum = 2
        }

        /// <summary>
        /// Tipo de conta do extrato do Favorecido Cadastrado (CC &#x3D; conta corrente, CP &#x3D; conta poupança).
        /// </summary>
        /// <value>Tipo de conta do extrato do Favorecido Cadastrado (CC &#x3D; conta corrente, CP &#x3D; conta poupança).</value>
        [DataMember(Name="tipoConta")]
        public TipoContaEnum? TipoConta { get; set; }

        /// <summary>
        /// Nome do titular da conta.
        /// </summary>
        /// <value>Nome do titular da conta.</value>
        [DataMember(Name="nomeTitularConta")]
        public string NomeTitularConta { get; set; }

        /// <summary>
        /// Número do CPF ou CNPJ do Favorecido Cadastrado (11 dígitos ou 14 dígitos, respectivamente).
        /// </summary>
        /// <value>Número do CPF ou CNPJ do Favorecido Cadastrado (11 dígitos ou 14 dígitos, respectivamente).</value>
        [DataMember(Name="cpf")]
        public string Cpf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavorecidoListaObj {\n");
            sb.Append("  CodBanco: ").Append(CodBanco).Append("\n");
            sb.Append("  NomeBanco: ").Append(NomeBanco).Append("\n");
            sb.Append("  NumAgencia: ").Append(NumAgencia).Append("\n");
            sb.Append("  NumConta: ").Append(NumConta).Append("\n");
            sb.Append("  TipoConta: ").Append(TipoConta).Append("\n");
            sb.Append("  NomeTitularConta: ").Append(NomeTitularConta).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FavorecidoListaObj)obj);
        }

        /// <summary>
        /// Returns true if FavorecidoListaObj instances are equal
        /// </summary>
        /// <param name="other">Instance of FavorecidoListaObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavorecidoListaObj other)
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
                    NomeBanco == other.NomeBanco ||
                    NomeBanco != null &&
                    NomeBanco.Equals(other.NomeBanco)
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
                    TipoConta == other.TipoConta ||
                    TipoConta != null &&
                    TipoConta.Equals(other.TipoConta)
                ) && 
                (
                    NomeTitularConta == other.NomeTitularConta ||
                    NomeTitularConta != null &&
                    NomeTitularConta.Equals(other.NomeTitularConta)
                ) && 
                (
                    Cpf == other.Cpf ||
                    Cpf != null &&
                    Cpf.Equals(other.Cpf)
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
                    if (NomeBanco != null)
                    hashCode = hashCode * 59 + NomeBanco.GetHashCode();
                    if (NumAgencia != null)
                    hashCode = hashCode * 59 + NumAgencia.GetHashCode();
                    if (NumConta != null)
                    hashCode = hashCode * 59 + NumConta.GetHashCode();
                    if (TipoConta != null)
                    hashCode = hashCode * 59 + TipoConta.GetHashCode();
                    if (NomeTitularConta != null)
                    hashCode = hashCode * 59 + NomeTitularConta.GetHashCode();
                    if (Cpf != null)
                    hashCode = hashCode * 59 + Cpf.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FavorecidoListaObj left, FavorecidoListaObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FavorecidoListaObj left, FavorecidoListaObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
