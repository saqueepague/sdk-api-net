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
    /// Informações da requisição de consulta de condições de parcelamento de empréstimo.
    /// </summary>
    [DataContract]
    public partial class InfConsultaParcelasEmprestimoReq : IEquatable<InfConsultaParcelasEmprestimoReq>
    { 
        /// <summary>
        /// Quantidade de parcelas informadas pelo cliente.
        /// </summary>
        /// <value>Quantidade de parcelas informadas pelo cliente.</value>
        [DataMember(Name="qtdParcelas")]
        public string QtdParcelas { get; set; }

        /// <summary>
        /// Número da agência utilizada na operação.
        /// </summary>
        /// <value>Número da agência utilizada na operação.</value>
        [DataMember(Name="numAgencia")]
        public string NumAgencia { get; set; }

        /// <summary>
        /// Número da conta utilizada na operação.
        /// </summary>
        /// <value>Número da conta utilizada na operação.</value>
        [DataMember(Name="numConta")]
        public string NumConta { get; set; }

        /// <summary>
        /// Número do CPF do cliente (11 dígitos).
        /// </summary>
        /// <value>Número do CPF do cliente (11 dígitos).</value>
        [DataMember(Name="cpfFavorecido")]
        public string CpfFavorecido { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaParcelasEmprestimoReq {\n");
            sb.Append("  QtdParcelas: ").Append(QtdParcelas).Append("\n");
            sb.Append("  NumAgencia: ").Append(NumAgencia).Append("\n");
            sb.Append("  NumConta: ").Append(NumConta).Append("\n");
            sb.Append("  CpfFavorecido: ").Append(CpfFavorecido).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaParcelasEmprestimoReq)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaParcelasEmprestimoReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaParcelasEmprestimoReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaParcelasEmprestimoReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    QtdParcelas == other.QtdParcelas ||
                    QtdParcelas != null &&
                    QtdParcelas.Equals(other.QtdParcelas)
                ) && 
                (
                    NumAgencia == other.NumAgencia ||
                    NumAgencia != null &&
                    NumAgencia.Equals(other.NumAgencia)
                ) && 
                (
                    NumConta == other.NumConta ||
                    NumConta != null &&
                    NumConta.Equals(other.NumConta)
                ) && 
                (
                    CpfFavorecido == other.CpfFavorecido ||
                    CpfFavorecido != null &&
                    CpfFavorecido.Equals(other.CpfFavorecido)
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
                    if (QtdParcelas != null)
                    hashCode = hashCode * 59 + QtdParcelas.GetHashCode();
                    if (NumAgencia != null)
                    hashCode = hashCode * 59 + NumAgencia.GetHashCode();
                    if (NumConta != null)
                    hashCode = hashCode * 59 + NumConta.GetHashCode();
                    if (CpfFavorecido != null)
                    hashCode = hashCode * 59 + CpfFavorecido.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaParcelasEmprestimoReq left, InfConsultaParcelasEmprestimoReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaParcelasEmprestimoReq left, InfConsultaParcelasEmprestimoReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
