/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.28.2
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
    /// Informações da resposta de consulta dos produtos de recarga de cartão pré-pago de transporte disponíveis.
    /// </summary>
    [DataContract]
    public partial class InfConsultaValoresRecargaResp : IEquatable<InfConsultaValoresRecargaResp>
    { 
        /// <summary>
        /// Gets or Sets Valores
        /// </summary>
        [Required]
        [DataMember(Name="valores")]
        public InfConsultaValoresRecargaRespValores Valores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaValoresRecargaResp {\n");
            sb.Append("  Valores: ").Append(Valores).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaValoresRecargaResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaValoresRecargaResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaValoresRecargaResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaValoresRecargaResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Valores == other.Valores ||
                    Valores != null &&
                    Valores.Equals(other.Valores)
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
                    if (Valores != null)
                    hashCode = hashCode * 59 + Valores.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaValoresRecargaResp left, InfConsultaValoresRecargaResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaValoresRecargaResp left, InfConsultaValoresRecargaResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
