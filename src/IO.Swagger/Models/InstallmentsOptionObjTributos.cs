/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.27.2
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
    /// Informações sobre cada parcela.
    /// </summary>
    [DataContract]
    public partial class InstallmentsOptionObjTributos : IEquatable<InstallmentsOptionObjTributos>
    { 
        /// <summary>
        /// Valor dos juros calculados (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor dos juros calculados (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorSolicitado")]
        public string ValorSolicitado { get; set; }

        /// <summary>
        /// Informações do imposto sobre operações financeiras (07 dígitos, valor total &#x3D; 80,94%).
        /// </summary>
        /// <value>Informações do imposto sobre operações financeiras (07 dígitos, valor total &#x3D; 80,94%).</value>
        [DataMember(Name="iof")]
        public string Iof { get; set; }

        /// <summary>
        /// Informações do imposto sobre operações financeiras adicional (07 dígitos, valor total &#x3D; 80,94%).
        /// </summary>
        /// <value>Informações do imposto sobre operações financeiras adicional (07 dígitos, valor total &#x3D; 80,94%).</value>
        [DataMember(Name="iofAdicional")]
        public string IofAdicional { get; set; }

        /// <summary>
        /// Valor dos juros calculado em reias (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor dos juros calculado em reias (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorJuros")]
        public string ValorJuros { get; set; }

        /// <summary>
        /// Informações sobre taxas de juros anual (07 dígitos, valor total &#x3D; 80,94%).
        /// </summary>
        /// <value>Informações sobre taxas de juros anual (07 dígitos, valor total &#x3D; 80,94%).</value>
        [DataMember(Name="taxaJurosAnual")]
        public string TaxaJurosAnual { get; set; }

        /// <summary>
        /// Informações sobre taxas de juros mensal (07 dígitos, valor total &#x3D; 80,94%).
        /// </summary>
        /// <value>Informações sobre taxas de juros mensal (07 dígitos, valor total &#x3D; 80,94%).</value>
        [DataMember(Name="taxaJurosMensal")]
        public string TaxaJurosMensal { get; set; }

        /// <summary>
        /// Data de contratação do empréstimo (08 dígitos e AAAAMMDD).
        /// </summary>
        /// <value>Data de contratação do empréstimo (08 dígitos e AAAAMMDD).</value>
        [DataMember(Name="dataContratacao")]
        public string DataContratacao { get; set; }

        /// <summary>
        /// Data da primeira parcela de vencimeto (08 dígitos e AAAAMMDD).
        /// </summary>
        /// <value>Data da primeira parcela de vencimeto (08 dígitos e AAAAMMDD).</value>
        [DataMember(Name="primeiroVencimento")]
        public string PrimeiroVencimento { get; set; }

        /// <summary>
        /// Data da última parcela de vencimeto (08 dígitos e AAAAMMDD).
        /// </summary>
        /// <value>Data da última parcela de vencimeto (08 dígitos e AAAAMMDD).</value>
        [DataMember(Name="ultimoVencimento")]
        public string UltimoVencimento { get; set; }

        /// <summary>
        /// Informações sobre a soma de taxas de juros anual (07 dígitos, valor total &#x3D; 80,94%).
        /// </summary>
        /// <value>Informações sobre a soma de taxas de juros anual (07 dígitos, valor total &#x3D; 80,94%).</value>
        [DataMember(Name="cetAnual")]
        public string CetAnual { get; set; }

        /// <summary>
        /// Informações sobre a soma de taxas de juros mensal(07 dígitos, valor total &#x3D; 80,94%).
        /// </summary>
        /// <value>Informações sobre a soma de taxas de juros mensal(07 dígitos, valor total &#x3D; 80,94%).</value>
        [DataMember(Name="cetMensal")]
        public string CetMensal { get; set; }

        /// <summary>
        /// Informações sobre o valor total da soma de todas parcelas (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Informações sobre o valor total da soma de todas parcelas (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorTotalParcelas")]
        public string ValorTotalParcelas { get; set; }

        /// <summary>
        /// Representa o quanto o valor solicitado representa sobre o valor financiado. (07 digitos, valor total &#x3D; 70,00%)
        /// </summary>
        /// <value>Representa o quanto o valor solicitado representa sobre o valor financiado. (07 digitos, valor total &#x3D; 70,00%)</value>
        [DataMember(Name="taxaValorSolicitado")]
        public string TaxaValorSolicitado { get; set; }

        /// <summary>
        /// Representa o quanto o valor do iof representa sobre o valor financiado. (07 digitos, valor total &#x3D; 50,12%)
        /// </summary>
        /// <value>Representa o quanto o valor do iof representa sobre o valor financiado. (07 digitos, valor total &#x3D; 50,12%)</value>
        [DataMember(Name="taxaValorIof")]
        public string TaxaValorIof { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallmentsOptionObjTributos {\n");
            sb.Append("  ValorSolicitado: ").Append(ValorSolicitado).Append("\n");
            sb.Append("  Iof: ").Append(Iof).Append("\n");
            sb.Append("  IofAdicional: ").Append(IofAdicional).Append("\n");
            sb.Append("  ValorJuros: ").Append(ValorJuros).Append("\n");
            sb.Append("  TaxaJurosAnual: ").Append(TaxaJurosAnual).Append("\n");
            sb.Append("  TaxaJurosMensal: ").Append(TaxaJurosMensal).Append("\n");
            sb.Append("  DataContratacao: ").Append(DataContratacao).Append("\n");
            sb.Append("  PrimeiroVencimento: ").Append(PrimeiroVencimento).Append("\n");
            sb.Append("  UltimoVencimento: ").Append(UltimoVencimento).Append("\n");
            sb.Append("  CetAnual: ").Append(CetAnual).Append("\n");
            sb.Append("  CetMensal: ").Append(CetMensal).Append("\n");
            sb.Append("  ValorTotalParcelas: ").Append(ValorTotalParcelas).Append("\n");
            sb.Append("  TaxaValorSolicitado: ").Append(TaxaValorSolicitado).Append("\n");
            sb.Append("  TaxaValorIof: ").Append(TaxaValorIof).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstallmentsOptionObjTributos)obj);
        }

        /// <summary>
        /// Returns true if InstallmentsOptionObjTributos instances are equal
        /// </summary>
        /// <param name="other">Instance of InstallmentsOptionObjTributos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentsOptionObjTributos other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ValorSolicitado == other.ValorSolicitado ||
                    ValorSolicitado != null &&
                    ValorSolicitado.Equals(other.ValorSolicitado)
                ) && 
                (
                    Iof == other.Iof ||
                    Iof != null &&
                    Iof.Equals(other.Iof)
                ) && 
                (
                    IofAdicional == other.IofAdicional ||
                    IofAdicional != null &&
                    IofAdicional.Equals(other.IofAdicional)
                ) && 
                (
                    ValorJuros == other.ValorJuros ||
                    ValorJuros != null &&
                    ValorJuros.Equals(other.ValorJuros)
                ) && 
                (
                    TaxaJurosAnual == other.TaxaJurosAnual ||
                    TaxaJurosAnual != null &&
                    TaxaJurosAnual.Equals(other.TaxaJurosAnual)
                ) && 
                (
                    TaxaJurosMensal == other.TaxaJurosMensal ||
                    TaxaJurosMensal != null &&
                    TaxaJurosMensal.Equals(other.TaxaJurosMensal)
                ) && 
                (
                    DataContratacao == other.DataContratacao ||
                    DataContratacao != null &&
                    DataContratacao.Equals(other.DataContratacao)
                ) && 
                (
                    PrimeiroVencimento == other.PrimeiroVencimento ||
                    PrimeiroVencimento != null &&
                    PrimeiroVencimento.Equals(other.PrimeiroVencimento)
                ) && 
                (
                    UltimoVencimento == other.UltimoVencimento ||
                    UltimoVencimento != null &&
                    UltimoVencimento.Equals(other.UltimoVencimento)
                ) && 
                (
                    CetAnual == other.CetAnual ||
                    CetAnual != null &&
                    CetAnual.Equals(other.CetAnual)
                ) && 
                (
                    CetMensal == other.CetMensal ||
                    CetMensal != null &&
                    CetMensal.Equals(other.CetMensal)
                ) && 
                (
                    ValorTotalParcelas == other.ValorTotalParcelas ||
                    ValorTotalParcelas != null &&
                    ValorTotalParcelas.Equals(other.ValorTotalParcelas)
                ) && 
                (
                    TaxaValorSolicitado == other.TaxaValorSolicitado ||
                    TaxaValorSolicitado != null &&
                    TaxaValorSolicitado.Equals(other.TaxaValorSolicitado)
                ) && 
                (
                    TaxaValorIof == other.TaxaValorIof ||
                    TaxaValorIof != null &&
                    TaxaValorIof.Equals(other.TaxaValorIof)
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
                    if (ValorSolicitado != null)
                    hashCode = hashCode * 59 + ValorSolicitado.GetHashCode();
                    if (Iof != null)
                    hashCode = hashCode * 59 + Iof.GetHashCode();
                    if (IofAdicional != null)
                    hashCode = hashCode * 59 + IofAdicional.GetHashCode();
                    if (ValorJuros != null)
                    hashCode = hashCode * 59 + ValorJuros.GetHashCode();
                    if (TaxaJurosAnual != null)
                    hashCode = hashCode * 59 + TaxaJurosAnual.GetHashCode();
                    if (TaxaJurosMensal != null)
                    hashCode = hashCode * 59 + TaxaJurosMensal.GetHashCode();
                    if (DataContratacao != null)
                    hashCode = hashCode * 59 + DataContratacao.GetHashCode();
                    if (PrimeiroVencimento != null)
                    hashCode = hashCode * 59 + PrimeiroVencimento.GetHashCode();
                    if (UltimoVencimento != null)
                    hashCode = hashCode * 59 + UltimoVencimento.GetHashCode();
                    if (CetAnual != null)
                    hashCode = hashCode * 59 + CetAnual.GetHashCode();
                    if (CetMensal != null)
                    hashCode = hashCode * 59 + CetMensal.GetHashCode();
                    if (ValorTotalParcelas != null)
                    hashCode = hashCode * 59 + ValorTotalParcelas.GetHashCode();
                    if (TaxaValorSolicitado != null)
                    hashCode = hashCode * 59 + TaxaValorSolicitado.GetHashCode();
                    if (TaxaValorIof != null)
                    hashCode = hashCode * 59 + TaxaValorIof.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstallmentsOptionObjTributos left, InstallmentsOptionObjTributos right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstallmentsOptionObjTributos left, InstallmentsOptionObjTributos right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
