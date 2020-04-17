/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.18.3
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
    /// Informações da resposta da requisição de consulta de conta do favorecido.
    /// </summary>
    [DataContract]
    public partial class InfConsultaContaResp : IEquatable<InfConsultaContaResp>
    { 
        /// <summary>
        /// Indica a operação de depósito deve ser identificada (00 = Não / 01 = Sim).
        /// </summary>
        /// <value>Indica a operação de depósito deve ser identificada (00 = Não / 01 = Sim).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DepositoIdentificadoEnum
        {
            
            /// <summary>
            /// Enum _00Enum for 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00Enum = 1,
            
            /// <summary>
            /// Enum _01Enum for 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01Enum = 2
        }

        /// <summary>
        /// Indica a operação de depósito deve ser identificada (00 &#x3D; Não / 01 &#x3D; Sim).
        /// </summary>
        /// <value>Indica a operação de depósito deve ser identificada (00 &#x3D; Não / 01 &#x3D; Sim).</value>
        [Required]
        [DataMember(Name="depositoIdentificado")]
        public DepositoIdentificadoEnum? DepositoIdentificado { get; set; }

        /// <summary>
        /// Indica é permitido fazer depósito nessa conta (00 = Não / 01 = Sim).
        /// </summary>
        /// <value>Indica é permitido fazer depósito nessa conta (00 = Não / 01 = Sim).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HabilitaDepositoEnum
        {
            
            /// <summary>
            /// Enum _00Enum for 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00Enum = 1,
            
            /// <summary>
            /// Enum _01Enum for 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01Enum = 2
        }

        /// <summary>
        /// Indica é permitido fazer depósito nessa conta (00 &#x3D; Não / 01 &#x3D; Sim).
        /// </summary>
        /// <value>Indica é permitido fazer depósito nessa conta (00 &#x3D; Não / 01 &#x3D; Sim).</value>
        [Required]
        [DataMember(Name="habilitaDeposito")]
        public HabilitaDepositoEnum? HabilitaDeposito { get; set; }

        /// <summary>
        /// Igual à requisição.
        /// </summary>
        /// <value>Igual à requisição.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ModalidadeDepositoEnum
        {
            
            /// <summary>
            /// Enum _00Enum for 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00Enum = 1,
            
            /// <summary>
            /// Enum _01Enum for 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01Enum = 2
        }

        /// <summary>
        /// Igual à requisição.
        /// </summary>
        /// <value>Igual à requisição.</value>
        [Required]
        [DataMember(Name="modalidadeDeposito")]
        public ModalidadeDepositoEnum? ModalidadeDeposito { get; set; }

        /// <summary>
        /// Nome do cliente titular da conta.
        /// </summary>
        /// <value>Nome do cliente titular da conta.</value>
        [Required]
        [DataMember(Name="nomeCliente")]
        public string NomeCliente { get; set; }

        /// <summary>
        /// Indica se deve ser solicitado o CPF/CNPJ do depositante (00 = Não / 01 = Sim).
        /// </summary>
        /// <value>Indica se deve ser solicitado o CPF/CNPJ do depositante (00 = Não / 01 = Sim).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SolicDocEnum
        {
            
            /// <summary>
            /// Enum _00Enum for 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00Enum = 1,
            
            /// <summary>
            /// Enum _01Enum for 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01Enum = 2
        }

        /// <summary>
        /// Indica se deve ser solicitado o CPF/CNPJ do depositante (00 &#x3D; Não / 01 &#x3D; Sim).
        /// </summary>
        /// <value>Indica se deve ser solicitado o CPF/CNPJ do depositante (00 &#x3D; Não / 01 &#x3D; Sim).</value>
        [Required]
        [DataMember(Name="solicDoc")]
        public SolicDocEnum? SolicDoc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaContaResp {\n");
            sb.Append("  DepositoIdentificado: ").Append(DepositoIdentificado).Append("\n");
            sb.Append("  HabilitaDeposito: ").Append(HabilitaDeposito).Append("\n");
            sb.Append("  ModalidadeDeposito: ").Append(ModalidadeDeposito).Append("\n");
            sb.Append("  NomeCliente: ").Append(NomeCliente).Append("\n");
            sb.Append("  SolicDoc: ").Append(SolicDoc).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaContaResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaContaResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaContaResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaContaResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DepositoIdentificado == other.DepositoIdentificado ||
                    DepositoIdentificado != null &&
                    DepositoIdentificado.Equals(other.DepositoIdentificado)
                ) && 
                (
                    HabilitaDeposito == other.HabilitaDeposito ||
                    HabilitaDeposito != null &&
                    HabilitaDeposito.Equals(other.HabilitaDeposito)
                ) && 
                (
                    ModalidadeDeposito == other.ModalidadeDeposito ||
                    ModalidadeDeposito != null &&
                    ModalidadeDeposito.Equals(other.ModalidadeDeposito)
                ) && 
                (
                    NomeCliente == other.NomeCliente ||
                    NomeCliente != null &&
                    NomeCliente.Equals(other.NomeCliente)
                ) && 
                (
                    SolicDoc == other.SolicDoc ||
                    SolicDoc != null &&
                    SolicDoc.Equals(other.SolicDoc)
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
                    if (DepositoIdentificado != null)
                    hashCode = hashCode * 59 + DepositoIdentificado.GetHashCode();
                    if (HabilitaDeposito != null)
                    hashCode = hashCode * 59 + HabilitaDeposito.GetHashCode();
                    if (ModalidadeDeposito != null)
                    hashCode = hashCode * 59 + ModalidadeDeposito.GetHashCode();
                    if (NomeCliente != null)
                    hashCode = hashCode * 59 + NomeCliente.GetHashCode();
                    if (SolicDoc != null)
                    hashCode = hashCode * 59 + SolicDoc.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaContaResp left, InfConsultaContaResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaContaResp left, InfConsultaContaResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
