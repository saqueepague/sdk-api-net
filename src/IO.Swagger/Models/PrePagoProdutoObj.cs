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
    /// 
    /// </summary>
    [DataContract]
    public partial class PrePagoProdutoObj : IEquatable<PrePagoProdutoObj>
    { 
        /// <summary>
        /// Nome da operadora de telefonia.
        /// </summary>
        /// <value>Nome da operadora de telefonia.</value>
        [DataMember(Name="nomeOperadora")]
        public string NomeOperadora { get; set; }

        /// <summary>
        /// Valor mínimo de recarga para este produto, expresso em centavos.
        /// </summary>
        /// <value>Valor mínimo de recarga para este produto, expresso em centavos.</value>
        [DataMember(Name="valorMinimo")]
        public string ValorMinimo { get; set; }

        /// <summary>
        /// Valor máximo de recarga para este produto, expresso em centavos.
        /// </summary>
        /// <value>Valor máximo de recarga para este produto, expresso em centavos.</value>
        [DataMember(Name="valorMaximo")]
        public string ValorMaximo { get; set; }

        /// <summary>
        /// Código que identifica o produto de recarga da operadora de telefonia.
        /// </summary>
        /// <value>Código que identifica o produto de recarga da operadora de telefonia.</value>
        [DataMember(Name="idProduto")]
        public string IdProduto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePagoProdutoObj {\n");
            sb.Append("  NomeOperadora: ").Append(NomeOperadora).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("  ValorMaximo: ").Append(ValorMaximo).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PrePagoProdutoObj)obj);
        }

        /// <summary>
        /// Returns true if PrePagoProdutoObj instances are equal
        /// </summary>
        /// <param name="other">Instance of PrePagoProdutoObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrePagoProdutoObj other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NomeOperadora == other.NomeOperadora ||
                    NomeOperadora != null &&
                    NomeOperadora.Equals(other.NomeOperadora)
                ) && 
                (
                    ValorMinimo == other.ValorMinimo ||
                    ValorMinimo != null &&
                    ValorMinimo.Equals(other.ValorMinimo)
                ) && 
                (
                    ValorMaximo == other.ValorMaximo ||
                    ValorMaximo != null &&
                    ValorMaximo.Equals(other.ValorMaximo)
                ) && 
                (
                    IdProduto == other.IdProduto ||
                    IdProduto != null &&
                    IdProduto.Equals(other.IdProduto)
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
                    if (NomeOperadora != null)
                    hashCode = hashCode * 59 + NomeOperadora.GetHashCode();
                    if (ValorMinimo != null)
                    hashCode = hashCode * 59 + ValorMinimo.GetHashCode();
                    if (ValorMaximo != null)
                    hashCode = hashCode * 59 + ValorMaximo.GetHashCode();
                    if (IdProduto != null)
                    hashCode = hashCode * 59 + IdProduto.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PrePagoProdutoObj left, PrePagoProdutoObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PrePagoProdutoObj left, PrePagoProdutoObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
