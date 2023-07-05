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
    public partial class CartaoPresenteProdutoObj : IEquatable<CartaoPresenteProdutoObj>
    { 
        /// <summary>
        /// Identificador do produto disponível com base na lista gerada na operação /consultaCatalogoCartaoPresente.
        /// </summary>
        /// <value>Identificador do produto disponível com base na lista gerada na operação /consultaCatalogoCartaoPresente.</value>
        [DataMember(Name="idProduto")]
        public string IdProduto { get; set; }

        /// <summary>
        /// Nome do produto disponível.
        /// </summary>
        /// <value>Nome do produto disponível.</value>
        [DataMember(Name="nomeProduto")]
        public string NomeProduto { get; set; }

        /// <summary>
        /// Descricao do produto.
        /// </summary>
        /// <value>Descricao do produto.</value>
        [DataMember(Name="descricaoProduto")]
        public string DescricaoProduto { get; set; }

        /// <summary>
        /// Valor do produto disponível em reais incluindo centavos exemplo (R$ 30,00).
        /// </summary>
        /// <value>Valor do produto disponível em reais incluindo centavos exemplo (R$ 30,00).</value>
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Valor mínimo para este produto, expresso em reais incluindo centavos exemplo (R$ 30,00).
        /// </summary>
        /// <value>Valor mínimo para este produto, expresso em reais incluindo centavos exemplo (R$ 30,00).</value>
        [DataMember(Name="valorMinimo")]
        public string ValorMinimo { get; set; }

        /// <summary>
        /// Valor mínimo para este produto, expresso em reais incluindo centavos exemplo (R$ 30,00).
        /// </summary>
        /// <value>Valor mínimo para este produto, expresso em reais incluindo centavos exemplo (R$ 30,00).</value>
        [DataMember(Name="valorMaximo")]
        public string ValorMaximo { get; set; }

        /// <summary>
        /// Status do produto, se o mesmo está ativo ou não, ativo &#x3D; 1.
        /// </summary>
        /// <value>Status do produto, se o mesmo está ativo ou não, ativo &#x3D; 1.</value>
        [DataMember(Name="statusProduto")]
        public string StatusProduto { get; set; }

        /// <summary>
        /// Tipo do produto.
        /// </summary>
        /// <value>Tipo do produto.</value>
        [DataMember(Name="tipoProduto")]
        public string TipoProduto { get; set; }

        /// <summary>
        /// Nome do provedor do produto.
        /// </summary>
        /// <value>Nome do provedor do produto.</value>
        [DataMember(Name="nomeProvedor")]
        public string NomeProvedor { get; set; }

        /// <summary>
        /// ID do provedor do produto.
        /// </summary>
        /// <value>ID do provedor do produto.</value>
        [DataMember(Name="idProvedor")]
        public string IdProvedor { get; set; }

        /// <summary>
        /// Moeda que está sendo vendido o produto.
        /// </summary>
        /// <value>Moeda que está sendo vendido o produto.</value>
        [DataMember(Name="tipoMoeda")]
        public string TipoMoeda { get; set; }

        /// <summary>
        /// Código de barras do produto disponível com base na lista gerada na operação /consultaCatalogoCartaoPresente.
        /// </summary>
        /// <value>Código de barras do produto disponível com base na lista gerada na operação /consultaCatalogoCartaoPresente.</value>
        [DataMember(Name="eanProduto")]
        public string EanProduto { get; set; }

        /// <summary>
        /// Gets or Sets Informacoes
        /// </summary>
        [DataMember(Name="informacoes")]
        public CartaoPresenteProdutoObjInformacoes Informacoes { get; set; }

        /// <summary>
        /// Logo do produto no formato base64.
        /// </summary>
        /// <value>Logo do produto no formato base64.</value>
        [DataMember(Name="logoURL")]
        public string LogoURL { get; set; }

        /// <summary>
        /// Prioridade para aparecer para o cliente. Quanto maior, maior a prioridade.
        /// </summary>
        /// <value>Prioridade para aparecer para o cliente. Quanto maior, maior a prioridade.</value>
        [DataMember(Name="priority")]
        public string Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoPresenteProdutoObj {\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NomeProduto: ").Append(NomeProduto).Append("\n");
            sb.Append("  DescricaoProduto: ").Append(DescricaoProduto).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("  ValorMaximo: ").Append(ValorMaximo).Append("\n");
            sb.Append("  StatusProduto: ").Append(StatusProduto).Append("\n");
            sb.Append("  TipoProduto: ").Append(TipoProduto).Append("\n");
            sb.Append("  NomeProvedor: ").Append(NomeProvedor).Append("\n");
            sb.Append("  IdProvedor: ").Append(IdProvedor).Append("\n");
            sb.Append("  TipoMoeda: ").Append(TipoMoeda).Append("\n");
            sb.Append("  EanProduto: ").Append(EanProduto).Append("\n");
            sb.Append("  Informacoes: ").Append(Informacoes).Append("\n");
            sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CartaoPresenteProdutoObj)obj);
        }

        /// <summary>
        /// Returns true if CartaoPresenteProdutoObj instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoPresenteProdutoObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoPresenteProdutoObj other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdProduto == other.IdProduto ||
                    IdProduto != null &&
                    IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    NomeProduto == other.NomeProduto ||
                    NomeProduto != null &&
                    NomeProduto.Equals(other.NomeProduto)
                ) && 
                (
                    DescricaoProduto == other.DescricaoProduto ||
                    DescricaoProduto != null &&
                    DescricaoProduto.Equals(other.DescricaoProduto)
                ) && 
                (
                    Valor == other.Valor ||
                    Valor != null &&
                    Valor.Equals(other.Valor)
                ) && 
                (
                    ValorMinimo == other.ValorMinimo ||
                    ValorMinimo != null &&
                    ValorMinimo.Equals(other.ValorMinimo)
                ) && 
                (
                    ValorMaximo == other.ValorMaximo ||
                    ValorMaximo != null &&
                    ValorMaximo.Equals(other.ValorMaximo)
                ) && 
                (
                    StatusProduto == other.StatusProduto ||
                    StatusProduto != null &&
                    StatusProduto.Equals(other.StatusProduto)
                ) && 
                (
                    TipoProduto == other.TipoProduto ||
                    TipoProduto != null &&
                    TipoProduto.Equals(other.TipoProduto)
                ) && 
                (
                    NomeProvedor == other.NomeProvedor ||
                    NomeProvedor != null &&
                    NomeProvedor.Equals(other.NomeProvedor)
                ) && 
                (
                    IdProvedor == other.IdProvedor ||
                    IdProvedor != null &&
                    IdProvedor.Equals(other.IdProvedor)
                ) && 
                (
                    TipoMoeda == other.TipoMoeda ||
                    TipoMoeda != null &&
                    TipoMoeda.Equals(other.TipoMoeda)
                ) && 
                (
                    EanProduto == other.EanProduto ||
                    EanProduto != null &&
                    EanProduto.Equals(other.EanProduto)
                ) && 
                (
                    Informacoes == other.Informacoes ||
                    Informacoes != null &&
                    Informacoes.Equals(other.Informacoes)
                ) && 
                (
                    LogoURL == other.LogoURL ||
                    LogoURL != null &&
                    LogoURL.Equals(other.LogoURL)
                ) && 
                (
                    Priority == other.Priority ||
                    Priority != null &&
                    Priority.Equals(other.Priority)
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
                    if (IdProduto != null)
                    hashCode = hashCode * 59 + IdProduto.GetHashCode();
                    if (NomeProduto != null)
                    hashCode = hashCode * 59 + NomeProduto.GetHashCode();
                    if (DescricaoProduto != null)
                    hashCode = hashCode * 59 + DescricaoProduto.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                    if (ValorMinimo != null)
                    hashCode = hashCode * 59 + ValorMinimo.GetHashCode();
                    if (ValorMaximo != null)
                    hashCode = hashCode * 59 + ValorMaximo.GetHashCode();
                    if (StatusProduto != null)
                    hashCode = hashCode * 59 + StatusProduto.GetHashCode();
                    if (TipoProduto != null)
                    hashCode = hashCode * 59 + TipoProduto.GetHashCode();
                    if (NomeProvedor != null)
                    hashCode = hashCode * 59 + NomeProvedor.GetHashCode();
                    if (IdProvedor != null)
                    hashCode = hashCode * 59 + IdProvedor.GetHashCode();
                    if (TipoMoeda != null)
                    hashCode = hashCode * 59 + TipoMoeda.GetHashCode();
                    if (EanProduto != null)
                    hashCode = hashCode * 59 + EanProduto.GetHashCode();
                    if (Informacoes != null)
                    hashCode = hashCode * 59 + Informacoes.GetHashCode();
                    if (LogoURL != null)
                    hashCode = hashCode * 59 + LogoURL.GetHashCode();
                    if (Priority != null)
                    hashCode = hashCode * 59 + Priority.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CartaoPresenteProdutoObj left, CartaoPresenteProdutoObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CartaoPresenteProdutoObj left, CartaoPresenteProdutoObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
