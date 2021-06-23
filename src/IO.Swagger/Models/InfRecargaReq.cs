/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.24.2
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
    /// Informações sobre a requisição de recarga de cartão pré-pago de transporte.
    /// </summary>
    [DataContract]
    public partial class InfRecargaReq : IEquatable<InfRecargaReq>
    { 
        /// <summary>
        /// Operadora de bilhetagem utilizada na operação.
        /// </summary>
        /// <value>Operadora de bilhetagem utilizada na operação.</value>
        [Required]
        [DataMember(Name="idOperadora")]
        public string IdOperadora { get; set; }

        /// <summary>
        /// Produto utilizado na operação.
        /// </summary>
        /// <value>Produto utilizado na operação.</value>
        [Required]
        [DataMember(Name="idProduto")]
        public string IdProduto { get; set; }

        /// <summary>
        /// Número do cartão utilizado na operação.
        /// </summary>
        /// <value>Número do cartão utilizado na operação.</value>
        [Required]
        [DataMember(Name="numCartao")]
        public string NumCartao { get; set; }

        /// <summary>
        /// Número do telefone utilizado na operação (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).
        /// </summary>
        /// <value>Número do telefone utilizado na operação (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).</value>
        [DataMember(Name="telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfRecargaReq {\n");
            sb.Append("  IdOperadora: ").Append(IdOperadora).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NumCartao: ").Append(NumCartao).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfRecargaReq)obj);
        }

        /// <summary>
        /// Returns true if InfRecargaReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfRecargaReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfRecargaReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdOperadora == other.IdOperadora ||
                    IdOperadora != null &&
                    IdOperadora.Equals(other.IdOperadora)
                ) && 
                (
                    IdProduto == other.IdProduto ||
                    IdProduto != null &&
                    IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    NumCartao == other.NumCartao ||
                    NumCartao != null &&
                    NumCartao.Equals(other.NumCartao)
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
                    if (IdOperadora != null)
                    hashCode = hashCode * 59 + IdOperadora.GetHashCode();
                    if (IdProduto != null)
                    hashCode = hashCode * 59 + IdProduto.GetHashCode();
                    if (NumCartao != null)
                    hashCode = hashCode * 59 + NumCartao.GetHashCode();
                    if (Telefone != null)
                    hashCode = hashCode * 59 + Telefone.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfRecargaReq left, InfRecargaReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfRecargaReq left, InfRecargaReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
