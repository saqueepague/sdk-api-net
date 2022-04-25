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
    /// Informações de retorno da compra de cartão presente.
    /// </summary>
    [DataContract]
    public partial class InfEfetuarCompraCartaoPresenteResp : IEquatable<InfEfetuarCompraCartaoPresenteResp>
    { 
        /// <summary>
        /// Código de identificação compra de cartão presente, em caso de sucesso.
        /// </summary>
        /// <value>Código de identificação compra de cartão presente, em caso de sucesso.</value>
        [Required]
        [DataMember(Name="idCompra")]
        public string IdCompra { get; set; }

        /// <summary>
        /// Número PIN para resgate do cartão presente, em caso de sucesso.
        /// </summary>
        /// <value>Número PIN para resgate do cartão presente, em caso de sucesso.</value>
        [Required]
        [DataMember(Name="chaveResgate")]
        public string ChaveResgate { get; set; }

        /// <summary>
        /// Validade do número PIN, em caso de sucesso.
        /// </summary>
        /// <value>Validade do número PIN, em caso de sucesso.</value>
        [Required]
        [DataMember(Name="validadeChave")]
        public string ValidadeChave { get; set; }

        /// <summary>
        /// Número serial para suporte, em caso de sucesso.
        /// </summary>
        /// <value>Número serial para suporte, em caso de sucesso.</value>
        [Required]
        [DataMember(Name="chaveSerial")]
        public string ChaveSerial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfEfetuarCompraCartaoPresenteResp {\n");
            sb.Append("  IdCompra: ").Append(IdCompra).Append("\n");
            sb.Append("  ChaveResgate: ").Append(ChaveResgate).Append("\n");
            sb.Append("  ValidadeChave: ").Append(ValidadeChave).Append("\n");
            sb.Append("  ChaveSerial: ").Append(ChaveSerial).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfEfetuarCompraCartaoPresenteResp)obj);
        }

        /// <summary>
        /// Returns true if InfEfetuarCompraCartaoPresenteResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfEfetuarCompraCartaoPresenteResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfEfetuarCompraCartaoPresenteResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdCompra == other.IdCompra ||
                    IdCompra != null &&
                    IdCompra.Equals(other.IdCompra)
                ) && 
                (
                    ChaveResgate == other.ChaveResgate ||
                    ChaveResgate != null &&
                    ChaveResgate.Equals(other.ChaveResgate)
                ) && 
                (
                    ValidadeChave == other.ValidadeChave ||
                    ValidadeChave != null &&
                    ValidadeChave.Equals(other.ValidadeChave)
                ) && 
                (
                    ChaveSerial == other.ChaveSerial ||
                    ChaveSerial != null &&
                    ChaveSerial.Equals(other.ChaveSerial)
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
                    if (IdCompra != null)
                    hashCode = hashCode * 59 + IdCompra.GetHashCode();
                    if (ChaveResgate != null)
                    hashCode = hashCode * 59 + ChaveResgate.GetHashCode();
                    if (ValidadeChave != null)
                    hashCode = hashCode * 59 + ValidadeChave.GetHashCode();
                    if (ChaveSerial != null)
                    hashCode = hashCode * 59 + ChaveSerial.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfEfetuarCompraCartaoPresenteResp left, InfEfetuarCompraCartaoPresenteResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfEfetuarCompraCartaoPresenteResp left, InfEfetuarCompraCartaoPresenteResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
