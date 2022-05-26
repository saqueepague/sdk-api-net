/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.27.3
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
    public partial class Cartao : IEquatable<Cartao>
    { 
        /// <summary>
        /// Modo de entrada de leitura do cartão. (000 = sem cartão, 050 = chip, 800 = chip, se falhar realiza leitura da trilha, 900 = trilha completa).
        /// </summary>
        /// <value>Modo de entrada de leitura do cartão. (000 = sem cartão, 050 = chip, 800 = chip, se falhar realiza leitura da trilha, 900 = trilha completa).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ModoEntradaEnum
        {
            
            /// <summary>
            /// Enum _000Enum for 000
            /// </summary>
            [EnumMember(Value = "000")]
            _000Enum = 1,
            
            /// <summary>
            /// Enum _050Enum for 050
            /// </summary>
            [EnumMember(Value = "050")]
            _050Enum = 2,
            
            /// <summary>
            /// Enum _800Enum for 800
            /// </summary>
            [EnumMember(Value = "800")]
            _800Enum = 3,
            
            /// <summary>
            /// Enum _900Enum for 900
            /// </summary>
            [EnumMember(Value = "900")]
            _900Enum = 4
        }

        /// <summary>
        /// Modo de entrada de leitura do cartão. (000 &#x3D; sem cartão, 050 &#x3D; chip, 800 &#x3D; chip, se falhar realiza leitura da trilha, 900 &#x3D; trilha completa).
        /// </summary>
        /// <value>Modo de entrada de leitura do cartão. (000 &#x3D; sem cartão, 050 &#x3D; chip, 800 &#x3D; chip, se falhar realiza leitura da trilha, 900 &#x3D; trilha completa).</value>
        [DataMember(Name="modoEntrada")]
        public ModoEntradaEnum? ModoEntrada { get; set; }

        /// <summary>
        /// PAN/Número do cartão utilizado (dado criptografado).
        /// </summary>
        /// <value>PAN/Número do cartão utilizado (dado criptografado).</value>
        [DataMember(Name="pan")]
        public string Pan { get; set; }

        /// <summary>
        /// Trilha 2 do cartão utilizado (dado criptografado).
        /// </summary>
        /// <value>Trilha 2 do cartão utilizado (dado criptografado).</value>
        [DataMember(Name="trilha2")]
        public string Trilha2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cartao {\n");
            sb.Append("  ModoEntrada: ").Append(ModoEntrada).Append("\n");
            sb.Append("  Pan: ").Append(Pan).Append("\n");
            sb.Append("  Trilha2: ").Append(Trilha2).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Cartao)obj);
        }

        /// <summary>
        /// Returns true if Cartao instances are equal
        /// </summary>
        /// <param name="other">Instance of Cartao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cartao other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ModoEntrada == other.ModoEntrada ||
                    ModoEntrada != null &&
                    ModoEntrada.Equals(other.ModoEntrada)
                ) && 
                (
                    Pan == other.Pan ||
                    Pan != null &&
                    Pan.Equals(other.Pan)
                ) && 
                (
                    Trilha2 == other.Trilha2 ||
                    Trilha2 != null &&
                    Trilha2.Equals(other.Trilha2)
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
                    if (ModoEntrada != null)
                    hashCode = hashCode * 59 + ModoEntrada.GetHashCode();
                    if (Pan != null)
                    hashCode = hashCode * 59 + Pan.GetHashCode();
                    if (Trilha2 != null)
                    hashCode = hashCode * 59 + Trilha2.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Cartao left, Cartao right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Cartao left, Cartao right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
