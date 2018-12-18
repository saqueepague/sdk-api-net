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
    /// Informações da resposta da requisição de identificação.
    /// </summary>
    [DataContract]
    public partial class InfIdentificacaoResp : IEquatable<InfIdentificacaoResp>
    { 
        /// <summary>
        /// Transações habilitadas para o cartão utilizado. Enviar os cdProcs concatenados (6 dígitos cada).
        /// </summary>
        /// <value>Transações habilitadas para o cartão utilizado. Enviar os cdProcs concatenados (6 dígitos cada).</value>
        [DataMember(Name="transacValidas")]
        public string TransacValidas { get; set; }

        /// <summary>
        /// Opções de letra/sílabas a serem mostradas para o cliente, caso ele use identificação positiva.
        /// </summary>
        /// <value>Opções de letra/sílabas a serem mostradas para o cliente, caso ele use identificação positiva.</value>
        [DataMember(Name="idPositiva")]
        public List<IdPositiva> IdPositiva { get; set; }
        /// <summary>
        /// Gets or Sets PedirToken
        /// </summary>
        public enum ePedirToken
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
        /// Gets or Sets PedirToken
        /// </summary>
        [DataMember(Name="pedirToken")]
        public ePedirToken? PedirToken { get; set; }

        /// <summary>
        /// Frase a ser mostrada para o cliente quando pedir o token ou identificacao positiva (máx. 28 caracteres).
        /// </summary>
        /// <value>Frase a ser mostrada para o cliente quando pedir o token ou identificacao positiva (máx. 28 caracteres).</value>
        [DataMember(Name="frase")]
        public string Frase { get; set; }

        /// <summary>
        /// Saldo do cliente a ser mostrado na tela (12 dígitos).
        /// </summary>
        /// <value>Saldo do cliente a ser mostrado na tela (12 dígitos).</value>
        [DataMember(Name="saldo")]
        public string Saldo { get; set; }

        /// <summary>
        /// Lista de possíveis perguntas a serem mostradas para o usuário para autenticá-lo.
        /// </summary>
        /// <value>Lista de possíveis perguntas a serem mostradas para o usuário para autenticá-lo.</value>
        [DataMember(Name="perguntas")]
        public List<Pergunta1> Perguntas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfIdentificacaoResp {\n");
            sb.Append("  TransacValidas: ").Append(TransacValidas).Append("\n");
            sb.Append("  IdPositiva: ").Append(IdPositiva).Append("\n");
            sb.Append("  PedirToken: ").Append(PedirToken).Append("\n");
            sb.Append("  Frase: ").Append(Frase).Append("\n");
            sb.Append("  Saldo: ").Append(Saldo).Append("\n");
            sb.Append("  Perguntas: ").Append(Perguntas).Append("\n");
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
                    TransacValidas == other.TransacValidas ||
                    TransacValidas != null &&
                    TransacValidas.Equals(other.TransacValidas)
                ) && 
                (
                    IdPositiva == other.IdPositiva ||
                    IdPositiva != null &&
                    IdPositiva.SequenceEqual(other.IdPositiva)
                ) && 
                (
                    PedirToken == other.PedirToken ||
                    PedirToken != null &&
                    PedirToken.Equals(other.PedirToken)
                ) && 
                (
                    Frase == other.Frase ||
                    Frase != null &&
                    Frase.Equals(other.Frase)
                ) && 
                (
                    Saldo == other.Saldo ||
                    Saldo != null &&
                    Saldo.Equals(other.Saldo)
                ) && 
                (
                    Perguntas == other.Perguntas ||
                    Perguntas != null &&
                    Perguntas.SequenceEqual(other.Perguntas)
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
                    if (TransacValidas != null)
                    hashCode = hashCode * 59 + TransacValidas.GetHashCode();
                    if (IdPositiva != null)
                    hashCode = hashCode * 59 + IdPositiva.GetHashCode();
                    if (PedirToken != null)
                    hashCode = hashCode * 59 + PedirToken.GetHashCode();
                    if (Frase != null)
                    hashCode = hashCode * 59 + Frase.GetHashCode();
                    if (Saldo != null)
                    hashCode = hashCode * 59 + Saldo.GetHashCode();
                    if (Perguntas != null)
                    hashCode = hashCode * 59 + Perguntas.GetHashCode();
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
