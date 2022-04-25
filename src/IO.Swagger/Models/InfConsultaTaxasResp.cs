/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.27.1
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
    /// Informações da resposta de consulta de taxas dinâmicas para depósito e saque de carteira digital.
    /// </summary>
    [DataContract]
    public partial class InfConsultaTaxasResp : IEquatable<InfConsultaTaxasResp>
    { 
        /// <summary>
        /// Gets or Sets TransactionsFees
        /// </summary>
        [Required]
        [DataMember(Name="transactions_fees")]
        public List<TransactionFeeListObj> TransactionsFees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaTaxasResp {\n");
            sb.Append("  TransactionsFees: ").Append(TransactionsFees).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaTaxasResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaTaxasResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaTaxasResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaTaxasResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TransactionsFees == other.TransactionsFees ||
                    TransactionsFees != null &&
                    TransactionsFees.SequenceEqual(other.TransactionsFees)
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
                    if (TransactionsFees != null)
                    hashCode = hashCode * 59 + TransactionsFees.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaTaxasResp left, InfConsultaTaxasResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaTaxasResp left, InfConsultaTaxasResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
