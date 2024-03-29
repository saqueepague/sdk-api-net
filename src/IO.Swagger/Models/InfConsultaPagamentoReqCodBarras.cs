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
    /// 
    /// </summary>
    [DataContract]
    public partial class InfConsultaPagamentoReqCodBarras : IEquatable<InfConsultaPagamentoReqCodBarras>
    { 
        /// <summary>
        /// Código de barras do documento.
        /// </summary>
        /// <value>Código de barras do documento.</value>
        [DataMember(Name="codigo")]
        public string Codigo { get; set; }

        /// <summary>
        /// Forma de entrada do código de barras (0 = escaneado, 1 = digitado).
        /// </summary>
        /// <value>Forma de entrada do código de barras (0 = escaneado, 1 = digitado).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ModoEntradaEnum
        {
            
            /// <summary>
            /// Enum _0Enum for 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0Enum = 1,
            
            /// <summary>
            /// Enum _1Enum for 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1Enum = 2
        }

        /// <summary>
        /// Forma de entrada do código de barras (0 &#x3D; escaneado, 1 &#x3D; digitado).
        /// </summary>
        /// <value>Forma de entrada do código de barras (0 &#x3D; escaneado, 1 &#x3D; digitado).</value>
        [DataMember(Name="modoEntrada")]
        public ModoEntradaEnum? ModoEntrada { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaPagamentoReqCodBarras {\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  ModoEntrada: ").Append(ModoEntrada).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaPagamentoReqCodBarras)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaPagamentoReqCodBarras instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaPagamentoReqCodBarras to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaPagamentoReqCodBarras other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Codigo == other.Codigo ||
                    Codigo != null &&
                    Codigo.Equals(other.Codigo)
                ) && 
                (
                    ModoEntrada == other.ModoEntrada ||
                    ModoEntrada != null &&
                    ModoEntrada.Equals(other.ModoEntrada)
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
                    if (Codigo != null)
                    hashCode = hashCode * 59 + Codigo.GetHashCode();
                    if (ModoEntrada != null)
                    hashCode = hashCode * 59 + ModoEntrada.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaPagamentoReqCodBarras left, InfConsultaPagamentoReqCodBarras right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaPagamentoReqCodBarras left, InfConsultaPagamentoReqCodBarras right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
