/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.17.1-sw2
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
    /// Informações genéricas sobre a requisição de transação.
    /// </summary>
    [DataContract]
    public partial class InfTransacaoReq : IEquatable<InfTransacaoReq>
    { 
        /// <summary>
        /// Código de processamento da transação, gerado pela Saque e Pague. Verificar código específico de cada transação com a Saque e Pague (6 dígitos).
        /// </summary>
        /// <value>Código de processamento da transação, gerado pela Saque e Pague. Verificar código específico de cada transação com a Saque e Pague (6 dígitos).</value>
        [Required]
        [DataMember(Name="cdProc")]
        public string CdProc { get; set; }

        /// <summary>
        /// Código na tabela de moedas do Banco Central (986 &#x3D; real, 3 dígitos).
        /// </summary>
        /// <value>Código na tabela de moedas do Banco Central (986 &#x3D; real, 3 dígitos).</value>
        [DataMember(Name="codMoeda")]
        public string CodMoeda { get; set; }

        /// <summary>
        /// Código definido pela Saque e Pague que identifica o autorizador (11 dígitos).
        /// </summary>
        /// <value>Código definido pela Saque e Pague que identifica o autorizador (11 dígitos).</value>
        [Required]
        [DataMember(Name="codOperadora")]
        public string CodOperadora { get; set; }

        /// <summary>
        /// Data contábil da transação (MMDD).
        /// </summary>
        /// <value>Data contábil da transação (MMDD).</value>
        [DataMember(Name="dataContabil")]
        public string DataContabil { get; set; }

        /// <summary>
        /// Data local (MMDDhhmmss).
        /// </summary>
        /// <value>Data local (MMDDhhmmss).</value>
        [Required]
        [DataMember(Name="dataHora")]
        public string DataHora { get; set; }

        /// <summary>
        /// Data local (MMDD).
        /// </summary>
        /// <value>Data local (MMDD).</value>
        [Required]
        [DataMember(Name="dataLocal")]
        public string DataLocal { get; set; }

        /// <summary>
        /// Hora local (hhmmss).
        /// </summary>
        /// <value>Hora local (hhmmss).</value>
        [Required]
        [DataMember(Name="horaLocal")]
        public string HoraLocal { get; set; }

        /// <summary>
        /// Identificador da transação gerado pela Saque e Pague (12 dígitos).
        /// </summary>
        /// <value>Identificador da transação gerado pela Saque e Pague (12 dígitos).</value>
        [Required]
        [DataMember(Name="nsu")]
        public string Nsu { get; set; }

        /// <summary>
        /// Valor da transação (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor da transação (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfTransacaoReq {\n");
            sb.Append("  CdProc: ").Append(CdProc).Append("\n");
            sb.Append("  CodMoeda: ").Append(CodMoeda).Append("\n");
            sb.Append("  CodOperadora: ").Append(CodOperadora).Append("\n");
            sb.Append("  DataContabil: ").Append(DataContabil).Append("\n");
            sb.Append("  DataHora: ").Append(DataHora).Append("\n");
            sb.Append("  DataLocal: ").Append(DataLocal).Append("\n");
            sb.Append("  HoraLocal: ").Append(HoraLocal).Append("\n");
            sb.Append("  Nsu: ").Append(Nsu).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfTransacaoReq)obj);
        }

        /// <summary>
        /// Returns true if InfTransacaoReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfTransacaoReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfTransacaoReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CdProc == other.CdProc ||
                    CdProc != null &&
                    CdProc.Equals(other.CdProc)
                ) && 
                (
                    CodMoeda == other.CodMoeda ||
                    CodMoeda != null &&
                    CodMoeda.Equals(other.CodMoeda)
                ) && 
                (
                    CodOperadora == other.CodOperadora ||
                    CodOperadora != null &&
                    CodOperadora.Equals(other.CodOperadora)
                ) && 
                (
                    DataContabil == other.DataContabil ||
                    DataContabil != null &&
                    DataContabil.Equals(other.DataContabil)
                ) && 
                (
                    DataHora == other.DataHora ||
                    DataHora != null &&
                    DataHora.Equals(other.DataHora)
                ) && 
                (
                    DataLocal == other.DataLocal ||
                    DataLocal != null &&
                    DataLocal.Equals(other.DataLocal)
                ) && 
                (
                    HoraLocal == other.HoraLocal ||
                    HoraLocal != null &&
                    HoraLocal.Equals(other.HoraLocal)
                ) && 
                (
                    Nsu == other.Nsu ||
                    Nsu != null &&
                    Nsu.Equals(other.Nsu)
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
                    if (CdProc != null)
                    hashCode = hashCode * 59 + CdProc.GetHashCode();
                    if (CodMoeda != null)
                    hashCode = hashCode * 59 + CodMoeda.GetHashCode();
                    if (CodOperadora != null)
                    hashCode = hashCode * 59 + CodOperadora.GetHashCode();
                    if (DataContabil != null)
                    hashCode = hashCode * 59 + DataContabil.GetHashCode();
                    if (DataHora != null)
                    hashCode = hashCode * 59 + DataHora.GetHashCode();
                    if (DataLocal != null)
                    hashCode = hashCode * 59 + DataLocal.GetHashCode();
                    if (HoraLocal != null)
                    hashCode = hashCode * 59 + HoraLocal.GetHashCode();
                    if (Nsu != null)
                    hashCode = hashCode * 59 + Nsu.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfTransacaoReq left, InfTransacaoReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfTransacaoReq left, InfTransacaoReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
