/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.3
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
    /// Tema que sará utilizado para montar o layout do usuário.
    /// </summary>
    [DataContract]
    public partial class CapitalizationBondObjTema : IEquatable<CapitalizationBondObjTema>
    { 
        /// <summary>
        /// Gets or Sets Estilos
        /// </summary>
        [DataMember(Name="estilos")]
        public List<LayoutObj> Estilos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapitalizationBondObjTema {\n");
            sb.Append("  Estilos: ").Append(Estilos).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CapitalizationBondObjTema)obj);
        }

        /// <summary>
        /// Returns true if CapitalizationBondObjTema instances are equal
        /// </summary>
        /// <param name="other">Instance of CapitalizationBondObjTema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapitalizationBondObjTema other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Estilos == other.Estilos ||
                    Estilos != null &&
                    Estilos.SequenceEqual(other.Estilos)
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
                    if (Estilos != null)
                    hashCode = hashCode * 59 + Estilos.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CapitalizationBondObjTema left, CapitalizationBondObjTema right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CapitalizationBondObjTema left, CapitalizationBondObjTema right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
