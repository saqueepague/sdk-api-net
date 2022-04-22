/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.27.0
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
    /// Informações de retorno da consulta de produtos para recarga de pré-pago.
    /// </summary>
    [DataContract]
    public partial class InfConsultaPrePagoResp : IEquatable<InfConsultaPrePagoResp>
    { 
        /// <summary>
        /// Lista de produtos de recarga pré-pago disponíveis para a área/DDD.
        /// </summary>
        /// <value>Lista de produtos de recarga pré-pago disponíveis para a área/DDD.</value>
        [DataMember(Name="produtos")]
        public List<PrePagoProdutoObj> Produtos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaPrePagoResp {\n");
            sb.Append("  Produtos: ").Append(Produtos).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaPrePagoResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaPrePagoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaPrePagoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaPrePagoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Produtos == other.Produtos ||
                    Produtos != null &&
                    Produtos.SequenceEqual(other.Produtos)
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
                    if (Produtos != null)
                    hashCode = hashCode * 59 + Produtos.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaPrePagoResp left, InfConsultaPrePagoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaPrePagoResp left, InfConsultaPrePagoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
