/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.2
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
    /// Informações da resposta de transferência.
    /// </summary>
    [DataContract]
    public partial class InfTransferenciaResp : IEquatable<InfTransferenciaResp>
    { 
        /// <summary>
        /// Gets or Sets Origem
        /// </summary>
        [DataMember(Name="origem")]
        public InfTransferenciaRespOrigem Origem { get; set; }

        /// <summary>
        /// Gets or Sets Destino
        /// </summary>
        [DataMember(Name="destino")]
        public InfTransferenciaRespDestino Destino { get; set; }

        /// <summary>
        /// Recibo da operação de transferência efetuada. Linhas com 48 posições separadas por \&quot;@\&quot;.
        /// </summary>
        /// <value>Recibo da operação de transferência efetuada. Linhas com 48 posições separadas por \&quot;@\&quot;.</value>
        [Required]
        [DataMember(Name="recibo")]
        public string Recibo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfTransferenciaResp {\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  Destino: ").Append(Destino).Append("\n");
            sb.Append("  Recibo: ").Append(Recibo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfTransferenciaResp)obj);
        }

        /// <summary>
        /// Returns true if InfTransferenciaResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfTransferenciaResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfTransferenciaResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Origem == other.Origem ||
                    Origem != null &&
                    Origem.Equals(other.Origem)
                ) && 
                (
                    Destino == other.Destino ||
                    Destino != null &&
                    Destino.Equals(other.Destino)
                ) && 
                (
                    Recibo == other.Recibo ||
                    Recibo != null &&
                    Recibo.Equals(other.Recibo)
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
                    if (Origem != null)
                    hashCode = hashCode * 59 + Origem.GetHashCode();
                    if (Destino != null)
                    hashCode = hashCode * 59 + Destino.GetHashCode();
                    if (Recibo != null)
                    hashCode = hashCode * 59 + Recibo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfTransferenciaResp left, InfTransferenciaResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfTransferenciaResp left, InfTransferenciaResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
