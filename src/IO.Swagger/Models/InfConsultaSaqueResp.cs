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
    /// Informações da resposta de requisiçãoi de consulta de saque.
    /// </summary>
    [DataContract]
    public partial class InfConsultaSaqueResp : IEquatable<InfConsultaSaqueResp>
    { 
        /// <summary>
        /// Nome do cliente titular da conta.
        /// </summary>
        /// <value>Nome do cliente titular da conta.</value>
        [DataMember(Name="nomeCliente")]
        public string NomeCliente { get; set; }

        /// <summary>
        /// Lista de possíveis perguntas a serem mostradas para o usuário para autorizar o saque.
        /// </summary>
        /// <value>Lista de possíveis perguntas a serem mostradas para o usuário para autorizar o saque.</value>
        [DataMember(Name="perguntas")]
        public List<InfConsultaSaqueRespPerguntas> Perguntas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaSaqueResp {\n");
            sb.Append("  NomeCliente: ").Append(NomeCliente).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaSaqueResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaSaqueResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaSaqueResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaSaqueResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NomeCliente == other.NomeCliente ||
                    NomeCliente != null &&
                    NomeCliente.Equals(other.NomeCliente)
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
                    if (NomeCliente != null)
                    hashCode = hashCode * 59 + NomeCliente.GetHashCode();
                    if (Perguntas != null)
                    hashCode = hashCode * 59 + Perguntas.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaSaqueResp left, InfConsultaSaqueResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaSaqueResp left, InfConsultaSaqueResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
