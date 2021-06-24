/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.3
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
    /// Pergunta mostrada ao usuário para se identificar antes do saque. Esta pergunta é selecionada aleatoriamente através da lista mandada na requisição de identificação.
    /// </summary>
    [DataContract]
    public partial class WithdrawConsultQuestionObj : IEquatable<WithdrawConsultQuestionObj>
    { 
        /// <summary>
        /// Identificador da pergunta.
        /// </summary>
        /// <value>Identificador da pergunta.</value>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Pergunta de identificação.
        /// </summary>
        /// <value>Pergunta de identificação.</value>
        [Required]
        [DataMember(Name="pergunta")]
        public string Pergunta { get; set; }

        /// <summary>
        /// Tamanho da resposta da pergunta.
        /// </summary>
        /// <value>Tamanho da resposta da pergunta.</value>
        [Required]
        [DataMember(Name="tamResposta")]
        public string TamResposta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WithdrawConsultQuestionObj {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Pergunta: ").Append(Pergunta).Append("\n");
            sb.Append("  TamResposta: ").Append(TamResposta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((WithdrawConsultQuestionObj)obj);
        }

        /// <summary>
        /// Returns true if WithdrawConsultQuestionObj instances are equal
        /// </summary>
        /// <param name="other">Instance of WithdrawConsultQuestionObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithdrawConsultQuestionObj other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Pergunta == other.Pergunta ||
                    Pergunta != null &&
                    Pergunta.Equals(other.Pergunta)
                ) && 
                (
                    TamResposta == other.TamResposta ||
                    TamResposta != null &&
                    TamResposta.Equals(other.TamResposta)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Pergunta != null)
                    hashCode = hashCode * 59 + Pergunta.GetHashCode();
                    if (TamResposta != null)
                    hashCode = hashCode * 59 + TamResposta.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(WithdrawConsultQuestionObj left, WithdrawConsultQuestionObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WithdrawConsultQuestionObj left, WithdrawConsultQuestionObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
