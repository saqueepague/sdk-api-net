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
    /// Informações adicionais como termo de uso e como utilizar.
    /// </summary>
    [DataContract]
    public partial class CartaoPresenteProdutoObjInformacoes : IEquatable<CartaoPresenteProdutoObjInformacoes>
    { 
        /// <summary>
        /// Termo de uso do produto.
        /// </summary>
        /// <value>Termo de uso do produto.</value>
        [DataMember(Name="termoDeUso")]
        public string TermoDeUso { get; set; }

        /// <summary>
        /// Descrição de como resgatar o produto.
        /// </summary>
        /// <value>Descrição de como resgatar o produto.</value>
        [DataMember(Name="descricaoResgate")]
        public string DescricaoResgate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoPresenteProdutoObjInformacoes {\n");
            sb.Append("  TermoDeUso: ").Append(TermoDeUso).Append("\n");
            sb.Append("  DescricaoResgate: ").Append(DescricaoResgate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CartaoPresenteProdutoObjInformacoes)obj);
        }

        /// <summary>
        /// Returns true if CartaoPresenteProdutoObjInformacoes instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoPresenteProdutoObjInformacoes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoPresenteProdutoObjInformacoes other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TermoDeUso == other.TermoDeUso ||
                    TermoDeUso != null &&
                    TermoDeUso.Equals(other.TermoDeUso)
                ) && 
                (
                    DescricaoResgate == other.DescricaoResgate ||
                    DescricaoResgate != null &&
                    DescricaoResgate.Equals(other.DescricaoResgate)
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
                    if (TermoDeUso != null)
                    hashCode = hashCode * 59 + TermoDeUso.GetHashCode();
                    if (DescricaoResgate != null)
                    hashCode = hashCode * 59 + DescricaoResgate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CartaoPresenteProdutoObjInformacoes left, CartaoPresenteProdutoObjInformacoes right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CartaoPresenteProdutoObjInformacoes left, CartaoPresenteProdutoObjInformacoes right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
