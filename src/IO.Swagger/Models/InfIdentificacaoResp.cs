/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.2
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
    /// Informações da resposta da requisição de identificação. Contém informações de como o usuário deve se identificar durante alguma futura transação. Usuário pode usar uma pergunta, token ou senha de sílabas.
    /// </summary>
    [DataContract]
    public partial class InfIdentificacaoResp : IEquatable<InfIdentificacaoResp>
    { 
        /// <summary>
        /// Frase a ser mostrada para o cliente na tela de coleta do token ou identificacao positiva.(máximo 28 caracteres)
        /// </summary>
        /// <value>Frase a ser mostrada para o cliente na tela de coleta do token ou identificacao positiva.(máximo 28 caracteres)</value>
        [DataMember(Name="frase")]
        public string Frase { get; set; }

        /// <summary>
        /// Opções de letras/sílabas a serem mostradas para o cliente, caso ele use identificação positiva.
        /// </summary>
        /// <value>Opções de letras/sílabas a serem mostradas para o cliente, caso ele use identificação positiva.</value>
        [DataMember(Name="idPositiva")]
        public List<PositiveIdScreenObj> IdPositiva { get; set; }

        /// <summary>
        /// Número da agência identificada (usado em operações em própria conta para o usuário não precisar preencher os dados).  *Este campo é obrigatório apenas para bancos.
        /// </summary>
        /// <value>Número da agência identificada (usado em operações em própria conta para o usuário não precisar preencher os dados).  *Este campo é obrigatório apenas para bancos.</value>
        [DataMember(Name="numAgencia")]
        public string NumAgencia { get; set; }

        /// <summary>
        /// Número da conta identificada (usado em operações em própria conta para o usuário não precisar preencher os dados).  *Este campo é obrigatório apenas para bancos.
        /// </summary>
        /// <value>Número da conta identificada (usado em operações em própria conta para o usuário não precisar preencher os dados).  *Este campo é obrigatório apenas para bancos.</value>
        [DataMember(Name="numConta")]
        public string NumConta { get; set; }

        /// <summary>
        /// Informa se o cliente deve se autenticar utilizando token (00 = não, 01 = sim).
        /// </summary>
        /// <value>Informa se o cliente deve se autenticar utilizando token (00 = não, 01 = sim).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PedirTokenEnum
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
        /// Informa se o cliente deve se autenticar utilizando token (00 &#x3D; não, 01 &#x3D; sim).
        /// </summary>
        /// <value>Informa se o cliente deve se autenticar utilizando token (00 &#x3D; não, 01 &#x3D; sim).</value>
        [Required]
        [DataMember(Name="pedirToken")]
        public PedirTokenEnum? PedirToken { get; set; }

        /// <summary>
        /// Lista de possíveis perguntas a serem mostradas para o usuário para autenticá-lo.
        /// </summary>
        /// <value>Lista de possíveis perguntas a serem mostradas para o usuário para autenticá-lo.</value>
        [DataMember(Name="perguntas")]
        public List<PositiveIdQuestionsObj> Perguntas { get; set; }

        /// <summary>
        /// Saldo do cliente a ser mostrado na tela (12 dígitos).
        /// </summary>
        /// <value>Saldo do cliente a ser mostrado na tela (12 dígitos).</value>
        [DataMember(Name="saldo")]
        public string Saldo { get; set; }

        /// <summary>
        /// Códigos de processamento das transações habilitadas para o cliente concatenados (6 dígitos cada código).
        /// </summary>
        /// <value>Códigos de processamento das transações habilitadas para o cliente concatenados (6 dígitos cada código).</value>
        [Required]
        [DataMember(Name="transacValidas")]
        public string TransacValidas { get; set; }

        /// <summary>
        /// Valor de limite para a TED (12 dígitos, incluindo centavos). Quando ultrapassar esse valor retornado pelo parceiro, devemos enviar a transação /consultaFavorecido.
        /// </summary>
        /// <value>Valor de limite para a TED (12 dígitos, incluindo centavos). Quando ultrapassar esse valor retornado pelo parceiro, devemos enviar a transação /consultaFavorecido.</value>
        [DataMember(Name="valorLimiteFavorecido")]
        public string ValorLimiteFavorecido { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfIdentificacaoResp {\n");
            sb.Append("  Frase: ").Append(Frase).Append("\n");
            sb.Append("  IdPositiva: ").Append(IdPositiva).Append("\n");
            sb.Append("  NumAgencia: ").Append(NumAgencia).Append("\n");
            sb.Append("  NumConta: ").Append(NumConta).Append("\n");
            sb.Append("  PedirToken: ").Append(PedirToken).Append("\n");
            sb.Append("  Perguntas: ").Append(Perguntas).Append("\n");
            sb.Append("  Saldo: ").Append(Saldo).Append("\n");
            sb.Append("  TransacValidas: ").Append(TransacValidas).Append("\n");
            sb.Append("  ValorLimiteFavorecido: ").Append(ValorLimiteFavorecido).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfIdentificacaoResp)obj);
        }

        /// <summary>
        /// Returns true if InfIdentificacaoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfIdentificacaoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfIdentificacaoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Frase == other.Frase ||
                    Frase != null &&
                    Frase.Equals(other.Frase)
                ) && 
                (
                    IdPositiva == other.IdPositiva ||
                    IdPositiva != null &&
                    IdPositiva.SequenceEqual(other.IdPositiva)
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
                    PedirToken == other.PedirToken ||
                    PedirToken != null &&
                    PedirToken.Equals(other.PedirToken)
                ) && 
                (
                    Perguntas == other.Perguntas ||
                    Perguntas != null &&
                    Perguntas.SequenceEqual(other.Perguntas)
                ) && 
                (
                    Saldo == other.Saldo ||
                    Saldo != null &&
                    Saldo.Equals(other.Saldo)
                ) && 
                (
                    TransacValidas == other.TransacValidas ||
                    TransacValidas != null &&
                    TransacValidas.Equals(other.TransacValidas)
                ) && 
                (
                    ValorLimiteFavorecido == other.ValorLimiteFavorecido ||
                    ValorLimiteFavorecido != null &&
                    ValorLimiteFavorecido.Equals(other.ValorLimiteFavorecido)
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
                    if (Frase != null)
                    hashCode = hashCode * 59 + Frase.GetHashCode();
                    if (IdPositiva != null)
                    hashCode = hashCode * 59 + IdPositiva.GetHashCode();
                    if (NumAgencia != null)
                    hashCode = hashCode * 59 + NumAgencia.GetHashCode();
                    if (NumConta != null)
                    hashCode = hashCode * 59 + NumConta.GetHashCode();
                    if (PedirToken != null)
                    hashCode = hashCode * 59 + PedirToken.GetHashCode();
                    if (Perguntas != null)
                    hashCode = hashCode * 59 + Perguntas.GetHashCode();
                    if (Saldo != null)
                    hashCode = hashCode * 59 + Saldo.GetHashCode();
                    if (TransacValidas != null)
                    hashCode = hashCode * 59 + TransacValidas.GetHashCode();
                    if (ValorLimiteFavorecido != null)
                    hashCode = hashCode * 59 + ValorLimiteFavorecido.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfIdentificacaoResp left, InfIdentificacaoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfIdentificacaoResp left, InfIdentificacaoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
