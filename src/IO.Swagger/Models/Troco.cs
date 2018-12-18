/*
 * Saque e Pague Transaction
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.17.0
 * Contact: captura_atm@saqueepague.com.br
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
    public partial class Troco : IEquatable<Troco>
    { 
        /// <summary>
        /// Valor do troco creditado em conta (pagamento em dinheiro, 12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do troco creditado em conta (pagamento em dinheiro, 12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorCreditoConta")]
        public string ValorCreditoConta { get; set; }

        /// <summary>
        /// Valor do troco entregue em espécie (pagamento em dinheiro, 12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do troco entregue em espécie (pagamento em dinheiro, 12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorEspecie")]
        public string ValorEspecie { get; set; }

        /// <summary>
        /// Valor do troco doado à instituição de caridade (pagamento em dinheiro, 12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do troco doado à instituição de caridade (pagamento em dinheiro, 12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorDoacao")]
        public string ValorDoacao { get; set; }

        /// <summary>
        /// CNPJ da instituição favorecida para doação (pagamento em dinheiro, 14 dígitos).
        /// </summary>
        /// <value>CNPJ da instituição favorecida para doação (pagamento em dinheiro, 14 dígitos).</value>
        [DataMember(Name="cnpjInstituicao")]
        public string CnpjInstituicao { get; set; }

        /// <summary>
        /// Valor do troco a ser entregue em cupom (pagamento em dinheiro, 12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do troco a ser entregue em cupom (pagamento em dinheiro, 12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorCupom")]
        public string ValorCupom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Troco {\n");
            sb.Append("  ValorCreditoConta: ").Append(ValorCreditoConta).Append("\n");
            sb.Append("  ValorEspecie: ").Append(ValorEspecie).Append("\n");
            sb.Append("  ValorDoacao: ").Append(ValorDoacao).Append("\n");
            sb.Append("  CnpjInstituicao: ").Append(CnpjInstituicao).Append("\n");
            sb.Append("  ValorCupom: ").Append(ValorCupom).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Troco)obj);
        }

        /// <summary>
        /// Returns true if Troco instances are equal
        /// </summary>
        /// <param name="other">Instance of Troco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Troco other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ValorCreditoConta == other.ValorCreditoConta ||
                    ValorCreditoConta != null &&
                    ValorCreditoConta.Equals(other.ValorCreditoConta)
                ) && 
                (
                    ValorEspecie == other.ValorEspecie ||
                    ValorEspecie != null &&
                    ValorEspecie.Equals(other.ValorEspecie)
                ) && 
                (
                    ValorDoacao == other.ValorDoacao ||
                    ValorDoacao != null &&
                    ValorDoacao.Equals(other.ValorDoacao)
                ) && 
                (
                    CnpjInstituicao == other.CnpjInstituicao ||
                    CnpjInstituicao != null &&
                    CnpjInstituicao.Equals(other.CnpjInstituicao)
                ) && 
                (
                    ValorCupom == other.ValorCupom ||
                    ValorCupom != null &&
                    ValorCupom.Equals(other.ValorCupom)
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
                    if (ValorCreditoConta != null)
                    hashCode = hashCode * 59 + ValorCreditoConta.GetHashCode();
                    if (ValorEspecie != null)
                    hashCode = hashCode * 59 + ValorEspecie.GetHashCode();
                    if (ValorDoacao != null)
                    hashCode = hashCode * 59 + ValorDoacao.GetHashCode();
                    if (CnpjInstituicao != null)
                    hashCode = hashCode * 59 + CnpjInstituicao.GetHashCode();
                    if (ValorCupom != null)
                    hashCode = hashCode * 59 + ValorCupom.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Troco left, Troco right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Troco left, Troco right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
