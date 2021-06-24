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
    /// Informações da resposta da requisição de consulta de limite de empréstimos.
    /// </summary>
    [DataContract]
    public partial class InfConsultaLimitesEmprestimoResp : IEquatable<InfConsultaLimitesEmprestimoResp>
    { 
        /// <summary>
        /// Nome do titular da conta.
        /// </summary>
        /// <value>Nome do titular da conta.</value>
        [Required]
        [DataMember(Name="nomeTitularConta")]
        public string NomeTitularConta { get; set; }

        /// <summary>
        /// Nome da agencia bancária.
        /// </summary>
        /// <value>Nome da agencia bancária.</value>
        [Required]
        [DataMember(Name="nomeAgenciaBancaria")]
        public string NomeAgenciaBancaria { get; set; }

        /// <summary>
        /// Valor mínimo permitido de empréstimo (12 caracteres, incluindo centavos).
        /// </summary>
        /// <value>Valor mínimo permitido de empréstimo (12 caracteres, incluindo centavos).</value>
        [Required]
        [DataMember(Name="limiteMinimoEmprestimo")]
        public string LimiteMinimoEmprestimo { get; set; }

        /// <summary>
        /// Valor máximo permitido de empréstimo (12 caracteres, incluindo centavos).
        /// </summary>
        /// <value>Valor máximo permitido de empréstimo (12 caracteres, incluindo centavos).</value>
        [Required]
        [DataMember(Name="limiteMaximoEmprestimo")]
        public string LimiteMaximoEmprestimo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaLimitesEmprestimoResp {\n");
            sb.Append("  NomeTitularConta: ").Append(NomeTitularConta).Append("\n");
            sb.Append("  NomeAgenciaBancaria: ").Append(NomeAgenciaBancaria).Append("\n");
            sb.Append("  LimiteMinimoEmprestimo: ").Append(LimiteMinimoEmprestimo).Append("\n");
            sb.Append("  LimiteMaximoEmprestimo: ").Append(LimiteMaximoEmprestimo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaLimitesEmprestimoResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaLimitesEmprestimoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaLimitesEmprestimoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaLimitesEmprestimoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NomeTitularConta == other.NomeTitularConta ||
                    NomeTitularConta != null &&
                    NomeTitularConta.Equals(other.NomeTitularConta)
                ) && 
                (
                    NomeAgenciaBancaria == other.NomeAgenciaBancaria ||
                    NomeAgenciaBancaria != null &&
                    NomeAgenciaBancaria.Equals(other.NomeAgenciaBancaria)
                ) && 
                (
                    LimiteMinimoEmprestimo == other.LimiteMinimoEmprestimo ||
                    LimiteMinimoEmprestimo != null &&
                    LimiteMinimoEmprestimo.Equals(other.LimiteMinimoEmprestimo)
                ) && 
                (
                    LimiteMaximoEmprestimo == other.LimiteMaximoEmprestimo ||
                    LimiteMaximoEmprestimo != null &&
                    LimiteMaximoEmprestimo.Equals(other.LimiteMaximoEmprestimo)
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
                    if (NomeTitularConta != null)
                    hashCode = hashCode * 59 + NomeTitularConta.GetHashCode();
                    if (NomeAgenciaBancaria != null)
                    hashCode = hashCode * 59 + NomeAgenciaBancaria.GetHashCode();
                    if (LimiteMinimoEmprestimo != null)
                    hashCode = hashCode * 59 + LimiteMinimoEmprestimo.GetHashCode();
                    if (LimiteMaximoEmprestimo != null)
                    hashCode = hashCode * 59 + LimiteMaximoEmprestimo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaLimitesEmprestimoResp left, InfConsultaLimitesEmprestimoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaLimitesEmprestimoResp left, InfConsultaLimitesEmprestimoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
