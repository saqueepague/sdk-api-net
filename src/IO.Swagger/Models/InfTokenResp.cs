/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.8
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
    /// Informações da requisição de consulta de Token.
    /// </summary>
    [DataContract]
    public partial class InfTokenResp : IEquatable<InfTokenResp>
    { 
        /// <summary>
        /// Token retornado.
        /// </summary>
        /// <value>Token retornado.</value>
        [DataMember(Name="access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Tipo do token.
        /// </summary>
        /// <value>Tipo do token.</value>
        [DataMember(Name="token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfTokenResp {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfTokenResp)obj);
        }

        /// <summary>
        /// Returns true if InfTokenResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfTokenResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfTokenResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AccessToken == other.AccessToken ||
                    AccessToken != null &&
                    AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    TokenType == other.TokenType ||
                    TokenType != null &&
                    TokenType.Equals(other.TokenType)
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
                    if (AccessToken != null)
                    hashCode = hashCode * 59 + AccessToken.GetHashCode();
                    if (TokenType != null)
                    hashCode = hashCode * 59 + TokenType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfTokenResp left, InfTokenResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfTokenResp left, InfTokenResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
