/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.6
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
    public partial class CapitalizationBondObj : IEquatable<CapitalizationBondObj>
    { 
        /// <summary>
        /// Data final da vigência do produto (AAAAMMDD).
        /// </summary>
        /// <value>Data final da vigência do produto (AAAAMMDD).</value>
        [DataMember(Name="dataFimVigencia")]
        public string DataFimVigencia { get; set; }

        /// <summary>
        /// Data inicial da vigência do produto (AAAAMMDD).
        /// </summary>
        /// <value>Data inicial da vigência do produto (AAAAMMDD).</value>
        [DataMember(Name="dataInicioVigencia")]
        public string DataInicioVigencia { get; set; }

        /// <summary>
        /// Descrição do produto.
        /// </summary>
        /// <value>Descrição do produto.</value>
        [DataMember(Name="descricao")]
        public string Descricao { get; set; }

        /// <summary>
        /// Informações complementares sobre o produto (até 60 caracteres).
        /// </summary>
        /// <value>Informações complementares sobre o produto (até 60 caracteres).</value>
        [DataMember(Name="detalhes")]
        public string Detalhes { get; set; }

        /// <summary>
        /// Identificador do produto.
        /// </summary>
        /// <value>Identificador do produto.</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Limite máximo de compras por usuário.
        /// </summary>
        /// <value>Limite máximo de compras por usuário.</value>
        [DataMember(Name="limiteMaximoCompra")]
        public string LimiteMaximoCompra { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        /// <value>Nome do produto.</value>
        [DataMember(Name="nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or Sets Tema
        /// </summary>
        [DataMember(Name="tema")]
        public CapitalizationBondObjTema Tema { get; set; }

        /// <summary>
        /// Valor por produto (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor por produto (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapitalizationBondObj {\n");
            sb.Append("  DataFimVigencia: ").Append(DataFimVigencia).Append("\n");
            sb.Append("  DataInicioVigencia: ").Append(DataInicioVigencia).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LimiteMaximoCompra: ").Append(LimiteMaximoCompra).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Tema: ").Append(Tema).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CapitalizationBondObj)obj);
        }

        /// <summary>
        /// Returns true if CapitalizationBondObj instances are equal
        /// </summary>
        /// <param name="other">Instance of CapitalizationBondObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapitalizationBondObj other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DataFimVigencia == other.DataFimVigencia ||
                    DataFimVigencia != null &&
                    DataFimVigencia.Equals(other.DataFimVigencia)
                ) && 
                (
                    DataInicioVigencia == other.DataInicioVigencia ||
                    DataInicioVigencia != null &&
                    DataInicioVigencia.Equals(other.DataInicioVigencia)
                ) && 
                (
                    Descricao == other.Descricao ||
                    Descricao != null &&
                    Descricao.Equals(other.Descricao)
                ) && 
                (
                    Detalhes == other.Detalhes ||
                    Detalhes != null &&
                    Detalhes.Equals(other.Detalhes)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    LimiteMaximoCompra == other.LimiteMaximoCompra ||
                    LimiteMaximoCompra != null &&
                    LimiteMaximoCompra.Equals(other.LimiteMaximoCompra)
                ) && 
                (
                    Nome == other.Nome ||
                    Nome != null &&
                    Nome.Equals(other.Nome)
                ) && 
                (
                    Tema == other.Tema ||
                    Tema != null &&
                    Tema.Equals(other.Tema)
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
                    if (DataFimVigencia != null)
                    hashCode = hashCode * 59 + DataFimVigencia.GetHashCode();
                    if (DataInicioVigencia != null)
                    hashCode = hashCode * 59 + DataInicioVigencia.GetHashCode();
                    if (Descricao != null)
                    hashCode = hashCode * 59 + Descricao.GetHashCode();
                    if (Detalhes != null)
                    hashCode = hashCode * 59 + Detalhes.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (LimiteMaximoCompra != null)
                    hashCode = hashCode * 59 + LimiteMaximoCompra.GetHashCode();
                    if (Nome != null)
                    hashCode = hashCode * 59 + Nome.GetHashCode();
                    if (Tema != null)
                    hashCode = hashCode * 59 + Tema.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CapitalizationBondObj left, CapitalizationBondObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CapitalizationBondObj left, CapitalizationBondObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
