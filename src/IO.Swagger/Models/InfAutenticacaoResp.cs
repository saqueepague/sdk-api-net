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
    /// Informações da resposta da requisição de autenticação.
    /// </summary>
    [DataContract]
    public partial class InfAutenticacaoResp : IEquatable<InfAutenticacaoResp>
    { 
        /// <summary>
        /// Nome do cliente se autenticando (até 60 caracteres).
        /// </summary>
        /// <value>Nome do cliente se autenticando (até 60 caracteres).</value>
        [DataMember(Name="nomeCliente")]
        public string NomeCliente { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfAutenticacaoResp {\n");
            sb.Append("  NomeCliente: ").Append(NomeCliente).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfAutenticacaoResp)obj);
        }

        /// <summary>
        /// Returns true if InfAutenticacaoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfAutenticacaoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfAutenticacaoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NomeCliente == other.NomeCliente ||
                    NomeCliente != null &&
                    NomeCliente.Equals(other.NomeCliente)
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
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfAutenticacaoResp left, InfAutenticacaoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfAutenticacaoResp left, InfAutenticacaoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
