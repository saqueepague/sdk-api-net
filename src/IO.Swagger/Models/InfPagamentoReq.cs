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
    public partial class InfPagamentoReq : IEquatable<InfPagamentoReq>
    { 
        /// <summary>
        /// Gets or Sets CodBarras
        /// </summary>
        [DataMember(Name="codBarras")]
        public CodBarras1 CodBarras { get; set; }

        /// <summary>
        /// Gets or Sets Darf
        /// </summary>
        [DataMember(Name="darf")]
        public Darf1 Darf { get; set; }

        /// <summary>
        /// Gets or Sets Gps
        /// </summary>
        [DataMember(Name="gps")]
        public Gps1 Gps { get; set; }

        /// <summary>
        /// Gets or Sets Troco
        /// </summary>
        [DataMember(Name="troco")]
        public Troco Troco { get; set; }

        /// <summary>
        /// Gets or Sets DepositoTroco
        /// </summary>
        [DataMember(Name="depositoTroco")]
        public DepositoTroco DepositoTroco { get; set; }

        /// <summary>
        /// Número ID DDA.
        /// </summary>
        /// <value>Número ID DDA.</value>
        [DataMember(Name="numDDA")]
        public string NumDDA { get; set; }

        /// <summary>
        /// Identificação da Consulta Pagamento.
        /// </summary>
        /// <value>Identificação da Consulta Pagamento.</value>
        [DataMember(Name="numConsultaPagamento")]
        public string NumConsultaPagamento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfPagamentoReq {\n");
            sb.Append("  CodBarras: ").Append(CodBarras).Append("\n");
            sb.Append("  Darf: ").Append(Darf).Append("\n");
            sb.Append("  Gps: ").Append(Gps).Append("\n");
            sb.Append("  Troco: ").Append(Troco).Append("\n");
            sb.Append("  DepositoTroco: ").Append(DepositoTroco).Append("\n");
            sb.Append("  NumDDA: ").Append(NumDDA).Append("\n");
            sb.Append("  NumConsultaPagamento: ").Append(NumConsultaPagamento).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfPagamentoReq)obj);
        }

        /// <summary>
        /// Returns true if InfPagamentoReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfPagamentoReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfPagamentoReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CodBarras == other.CodBarras ||
                    CodBarras != null &&
                    CodBarras.Equals(other.CodBarras)
                ) && 
                (
                    Darf == other.Darf ||
                    Darf != null &&
                    Darf.Equals(other.Darf)
                ) && 
                (
                    Gps == other.Gps ||
                    Gps != null &&
                    Gps.Equals(other.Gps)
                ) && 
                (
                    Troco == other.Troco ||
                    Troco != null &&
                    Troco.Equals(other.Troco)
                ) && 
                (
                    DepositoTroco == other.DepositoTroco ||
                    DepositoTroco != null &&
                    DepositoTroco.Equals(other.DepositoTroco)
                ) && 
                (
                    NumDDA == other.NumDDA ||
                    NumDDA != null &&
                    NumDDA.Equals(other.NumDDA)
                ) && 
                (
                    NumConsultaPagamento == other.NumConsultaPagamento ||
                    NumConsultaPagamento != null &&
                    NumConsultaPagamento.Equals(other.NumConsultaPagamento)
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
                    if (CodBarras != null)
                    hashCode = hashCode * 59 + CodBarras.GetHashCode();
                    if (Darf != null)
                    hashCode = hashCode * 59 + Darf.GetHashCode();
                    if (Gps != null)
                    hashCode = hashCode * 59 + Gps.GetHashCode();
                    if (Troco != null)
                    hashCode = hashCode * 59 + Troco.GetHashCode();
                    if (DepositoTroco != null)
                    hashCode = hashCode * 59 + DepositoTroco.GetHashCode();
                    if (NumDDA != null)
                    hashCode = hashCode * 59 + NumDDA.GetHashCode();
                    if (NumConsultaPagamento != null)
                    hashCode = hashCode * 59 + NumConsultaPagamento.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfPagamentoReq left, InfPagamentoReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfPagamentoReq left, InfPagamentoReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
