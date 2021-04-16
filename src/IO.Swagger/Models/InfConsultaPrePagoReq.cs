/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.23.0
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
    /// Informações da requisição de consulta de produtos de recarga de celular pré-pago.
    /// </summary>
    [DataContract]
    public partial class InfConsultaPrePagoReq : IEquatable<InfConsultaPrePagoReq>
    { 
        /// <summary>
        /// Código da área do número de celular.
        /// </summary>
        /// <value>Código da área do número de celular.</value>
        [Required]
        [DataMember(Name="ddd")]
        public string Ddd { get; set; }

        /// <summary>
        /// Número do telefone sem DDD.
        /// </summary>
        /// <value>Número do telefone sem DDD.</value>
        [Required]
        [DataMember(Name="telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaPrePagoReq {\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaPrePagoReq)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaPrePagoReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaPrePagoReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaPrePagoReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Ddd == other.Ddd ||
                    Ddd != null &&
                    Ddd.Equals(other.Ddd)
                ) && 
                (
                    Telefone == other.Telefone ||
                    Telefone != null &&
                    Telefone.Equals(other.Telefone)
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
                    if (Ddd != null)
                    hashCode = hashCode * 59 + Ddd.GetHashCode();
                    if (Telefone != null)
                    hashCode = hashCode * 59 + Telefone.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaPrePagoReq left, InfConsultaPrePagoReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaPrePagoReq left, InfConsultaPrePagoReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
