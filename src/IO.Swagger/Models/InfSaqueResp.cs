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
    /// Informações da resposta de saque.
    /// </summary>
    [DataContract]
    public partial class InfSaqueResp : IEquatable<InfSaqueResp>
    { 
        /// <summary>
        /// Recibo da operação de saque efetuada. Linhas com 48 posições separadas por \&quot;@\&quot;. Substituir os valores do recibo pela tag %VALOR%. A Saque e Pague substituirá essa tag no comprovante pelo valor realmente sacado pelo cliente.
        /// </summary>
        /// <value>Recibo da operação de saque efetuada. Linhas com 48 posições separadas por \&quot;@\&quot;. Substituir os valores do recibo pela tag %VALOR%. A Saque e Pague substituirá essa tag no comprovante pelo valor realmente sacado pelo cliente.</value>
        [Required]
        [DataMember(Name="recibo")]
        public string Recibo { get; set; }

        /// <summary>
        /// Código da Intituição registrada no Sistema Brasileiro de Pagamentos. Campo obrigatório, para transações de Saque QR Code, afim de identificar a instituição parceira da transação.
        /// </summary>
        /// <value>Código da Intituição registrada no Sistema Brasileiro de Pagamentos. Campo obrigatório, para transações de Saque QR Code, afim de identificar a instituição parceira da transação.</value>
        [DataMember(Name="ispb")]
        public string Ispb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfSaqueResp {\n");
            sb.Append("  Recibo: ").Append(Recibo).Append("\n");
            sb.Append("  Ispb: ").Append(Ispb).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfSaqueResp)obj);
        }

        /// <summary>
        /// Returns true if InfSaqueResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfSaqueResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfSaqueResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Recibo == other.Recibo ||
                    Recibo != null &&
                    Recibo.Equals(other.Recibo)
                ) && 
                (
                    Ispb == other.Ispb ||
                    Ispb != null &&
                    Ispb.Equals(other.Ispb)
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
                    if (Recibo != null)
                    hashCode = hashCode * 59 + Recibo.GetHashCode();
                    if (Ispb != null)
                    hashCode = hashCode * 59 + Ispb.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfSaqueResp left, InfSaqueResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfSaqueResp left, InfSaqueResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
