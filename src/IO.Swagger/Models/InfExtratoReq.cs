/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.18.1
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
    /// Informações da requisição de extrato.
    /// </summary>
    [DataContract]
    public partial class InfExtratoReq : IEquatable<InfExtratoReq>
    { 
        /// <summary>
        /// Código do banco utilizado na operação (3 dígitos).
        /// </summary>
        /// <value>Código do banco utilizado na operação (3 dígitos).</value>
        [DataMember(Name="codBanco")]
        public string CodBanco { get; set; }

        /// <summary>
        /// Número do CPF do cliente realizando a operação (11 dígitos).
        /// </summary>
        /// <value>Número do CPF do cliente realizando a operação (11 dígitos).</value>
        [DataMember(Name="cpf")]
        public string Cpf { get; set; }

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
        /// Telefone do cliente realizando a operação (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).
        /// </summary>
        /// <value>Telefone do cliente realizando a operação (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).</value>
        [DataMember(Name="telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// Tipo de conta do extrato (CC = conta corrente, CP = conta poupança, CS = conta salário).
        /// </summary>
        /// <value>Tipo de conta do extrato (CC = conta corrente, CP = conta poupança, CS = conta salário).</value>
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
            CPEnum = 2,
            
            /// <summary>
            /// Enum CSEnum for CS
            /// </summary>
            [EnumMember(Value = "CS")]
            CSEnum = 3
        }

        /// <summary>
        /// Tipo de conta do extrato (CC &#x3D; conta corrente, CP &#x3D; conta poupança, CS &#x3D; conta salário).
        /// </summary>
        /// <value>Tipo de conta do extrato (CC &#x3D; conta corrente, CP &#x3D; conta poupança, CS &#x3D; conta salário).</value>
        [DataMember(Name="tipoConta")]
        public TipoContaEnum? TipoConta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfExtratoReq {\n");
            sb.Append("  CodBanco: ").Append(CodBanco).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  NumAgencia: ").Append(NumAgencia).Append("\n");
            sb.Append("  NumConta: ").Append(NumConta).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  TipoConta: ").Append(TipoConta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfExtratoReq)obj);
        }

        /// <summary>
        /// Returns true if InfExtratoReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfExtratoReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfExtratoReq other)
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
                    Cpf == other.Cpf ||
                    Cpf != null &&
                    Cpf.Equals(other.Cpf)
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
                    Telefone == other.Telefone ||
                    Telefone != null &&
                    Telefone.Equals(other.Telefone)
                ) && 
                (
                    TipoConta == other.TipoConta ||
                    TipoConta != null &&
                    TipoConta.Equals(other.TipoConta)
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
                    if (Cpf != null)
                    hashCode = hashCode * 59 + Cpf.GetHashCode();
                    if (NumAgencia != null)
                    hashCode = hashCode * 59 + NumAgencia.GetHashCode();
                    if (NumConta != null)
                    hashCode = hashCode * 59 + NumConta.GetHashCode();
                    if (Telefone != null)
                    hashCode = hashCode * 59 + Telefone.GetHashCode();
                    if (TipoConta != null)
                    hashCode = hashCode * 59 + TipoConta.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfExtratoReq left, InfExtratoReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfExtratoReq left, InfExtratoReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
