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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class CartaoPresenteApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta dos produtos de catálogo cartão presente. Traz uma lista de todas as operadoras e seus respectivos produtos/valores.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de consulta valores de recarga de cartão.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.2/consultaCatalogoCartaoPresente")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaCatalogoCartaoPresentePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaCatalogoCartaoPresenteResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaCatalogoCartaoPresentePost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaCatalogoCartaoPresenteReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaCatalogoCartaoPresenteResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfConsultaCatalogoCartaoPresente\" : {\n    \"produtos\" : [ {\n      \"nomeProvedor\" : \"STEAM\",\n      \"valor\" : \"0003000\",\n      \"eanProduto\" : \"4260433452913\",\n      \"priority\" : \"1\",\n      \"logoURL\" : \"dHUgw6kgbyBjYXJhIDsp\",\n      \"descricaoProduto\" : \"Cartao Presente\",\n      \"valorMaximo\" : \"0003000\",\n      \"idProvedor\" : \"132\",\n      \"idProduto\" : \"1\",\n      \"statusProduto\" : \"1\",\n      \"valorMinimo\" : \"0003000\",\n      \"tipoProduto\" : \"PIN\",\n      \"informacoes\" : {\n        \"descricaoResgate\" : \"O cartão presente deve ser resgatado de tal forma.\",\n        \"termoDeUso\" : \"O produto só poderá ser resgatado uma vez.\"\n      },\n      \"nomeProduto\" : \"Cartao Presente\",\n      \"tipoMoeda\" : \"BRL\"\n    }, {\n      \"nomeProvedor\" : \"STEAM\",\n      \"valor\" : \"0003000\",\n      \"eanProduto\" : \"4260433452913\",\n      \"priority\" : \"1\",\n      \"logoURL\" : \"dHUgw6kgbyBjYXJhIDsp\",\n      \"descricaoProduto\" : \"Cartao Presente\",\n      \"valorMaximo\" : \"0003000\",\n      \"idProvedor\" : \"132\",\n      \"idProduto\" : \"1\",\n      \"statusProduto\" : \"1\",\n      \"valorMinimo\" : \"0003000\",\n      \"tipoProduto\" : \"PIN\",\n      \"informacoes\" : {\n        \"descricaoResgate\" : \"O cartão presente deve ser resgatado de tal forma.\",\n        \"termoDeUso\" : \"O produto só poderá ser resgatado uma vez.\"\n      },\n      \"nomeProduto\" : \"Cartao Presente\",\n      \"tipoMoeda\" : \"BRL\"\n    } ]\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaCatalogoCartaoPresenteResp>(exampleJson)
            : default(ConsultaCatalogoCartaoPresenteResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Confirmação de operação de compra de cartão presente.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de confirmação de operação de compra de cartão presente.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.2/efetuarCompraCartaoPresenteConf")]
        [ValidateModelState]
        [SwaggerOperation("EfetuarCompraCartaoPresenteConfPost")]
        public virtual IActionResult EfetuarCompraCartaoPresenteConfPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]TransacConf body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de compra de cartão presente.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição para a compra de cartão presente.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.2/efetuarCompraCartaoPresente")]
        [ValidateModelState]
        [SwaggerOperation("EfetuarCompraCartaoPresentePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(EfetuarCompraCartaoPresenteResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult EfetuarCompraCartaoPresentePost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]EfetuarCompraCartaoPresenteReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EfetuarCompraCartaoPresenteResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfEfetuarCompraCartaoPresente\" : {\n    \"validadeChave\" : \"AAAAMMDDhhmmss\",\n    \"chaveSerial\" : \"9999999999999999999\",\n    \"idCompra\" : \"b1a5c4bd-a914-4506-8d1d-744a6b3a285c\",\n    \"chaveResgate\" : \"93215783\"\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EfetuarCompraCartaoPresenteResp>(exampleJson)
            : default(EfetuarCompraCartaoPresenteResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="clientSecret">Cliente Secret.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.2/token")]
        [ValidateModelState]
        [SwaggerOperation("TokenPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InfTokenResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult TokenPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string clientSecret)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InfTokenResp));

            string exampleJson = null;
            exampleJson = "{\n  \"access_token\" : \"847c2530-9819-434b-82fb-a9058a1ec957\",\n  \"token_type\" : \"bearer\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InfTokenResp>(exampleJson)
            : default(InfTokenResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
