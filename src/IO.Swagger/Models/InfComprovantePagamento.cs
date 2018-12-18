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
    /// Informações da requisição de comprovante de pagamento.
    /// </summary>
    [DataContract]
    public partial class InfComprovantePagamento : IEquatable<InfComprovantePagamento>
    { 
        /// <summary>
        /// Identificação do comprovante de pagamento.
        /// </summary>
        /// <value>Identificação do comprovante de pagamento.</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Cedente (até 40 caracteres).
        /// </summary>
        /// <value>Cedente (até 40 caracteres).</value>
        [DataMember(Name="cedente")]
        public string Cedente { get; set; }

        /// <summary>
        /// Data de vencimento do Boleto/Título (AAAAMMDD).
        /// </summary>
        /// <value>Data de vencimento do Boleto/Título (AAAAMMDD).</value>
        [DataMember(Name="dataVencimento")]
        public string DataVencimento { get; set; }

        /// <summary>
        /// Data em que o Boleto/Título foi pago (AAAAMMDD).
        /// </summary>
        /// <value>Data em que o Boleto/Título foi pago (AAAAMMDD).</value>
        [DataMember(Name="dataPagamento")]
        public string DataPagamento { get; set; }

        /// <summary>
        /// Valor total pago (12 dpigitos, incluindo centavos).
        /// </summary>
        /// <value>Valor total pago (12 dpigitos, incluindo centavos).</value>
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfComprovantePagamento {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Cedente: ").Append(Cedente).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  DataPagamento: ").Append(DataPagamento).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfComprovantePagamento)obj);
        }

        /// <summary>
        /// Returns true if InfComprovantePagamento instances are equal
        /// </summary>
        /// <param name="other">Instance of InfComprovantePagamento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfComprovantePagamento other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Cedente == other.Cedente ||
                    Cedente != null &&
                    Cedente.Equals(other.Cedente)
                ) && 
                (
                    DataVencimento == other.DataVencimento ||
                    DataVencimento != null &&
                    DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    DataPagamento == other.DataPagamento ||
                    DataPagamento != null &&
                    DataPagamento.Equals(other.DataPagamento)
                ) && 
                (
                    Valor == other.Valor ||
                    Valor != null &&
                    Valor.Equals(other.Valor)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Cedente != null)
                    hashCode = hashCode * 59 + Cedente.GetHashCode();
                    if (DataVencimento != null)
                    hashCode = hashCode * 59 + DataVencimento.GetHashCode();
                    if (DataPagamento != null)
                    hashCode = hashCode * 59 + DataPagamento.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfComprovantePagamento left, InfComprovantePagamento right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfComprovantePagamento left, InfComprovantePagamento right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
