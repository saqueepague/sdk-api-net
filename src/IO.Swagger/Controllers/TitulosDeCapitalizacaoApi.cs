/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.1
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
    public class TitulosDeCapitalizacaoApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Confirmação de operação de compra de títulos de capitalização.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de confirmação de operação de compra de titulos de capitalizacao</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.25.1/compraTitulosCapitalizacaoConf")]
        [ValidateModelState]
        [SwaggerOperation("CompraTitulosCapitalizacaoConfPost")]
        public virtual IActionResult CompraTitulosCapitalizacaoConfPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]TransacConf body)
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
        /// <remarks>Operação de compra de títulos de capitalização.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de operação de compra de títulos de capitalização.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.25.1/compraTitulosCapitalizacao")]
        [ValidateModelState]
        [SwaggerOperation("CompraTitulosCapitalizacaoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(CompraTitulosCapitalizacaoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult CompraTitulosCapitalizacaoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]CompraTitulosCapitalizacaoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CompraTitulosCapitalizacaoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfCompraTitulosCapitalizacao\" : {\n    \"recibo\" : \"@               TITULOS COMPRADOS                @                                                @ NOME DO TITULO:  XXXXXXXXXXXXX                 @ QUANTIDADE: 2                                  @ VALOR: R$ 25,00                                @ VALOR TOTAL: R$ 50,00                          @ TELEFONE: 05199999999                          @ CPF: 02358422785                               \"\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CompraTitulosCapitalizacaoResp>(exampleJson)
            : default(CompraTitulosCapitalizacaoResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta dos possíveis produtos de títulos de capitalização de uma operadora.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de consulta produtos de títulos de capitalização.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.25.1/consultaTitulosCapitalizacao")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaTitulosCapitalizacaoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaTitulosCapitalizacaoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaTitulosCapitalizacaoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaTitulosCapitalizacaoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaTitulosCapitalizacaoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"InfConsultaTitulosCapitalizacao\" : {\n    \"produtos\" : [ {\n      \"limiteMaximoCompra\" : \"4\",\n      \"tema\" : {\n        \"estilos\" : [ {\n          \"valor\" : \"#00288C\",\n          \"nome\" : \"cor-fundo ou cor-botao\"\n        }, {\n          \"valor\" : \"#00288C\",\n          \"nome\" : \"cor-fundo ou cor-botao\"\n        } ]\n      },\n      \"valor\" : \"000000000500\",\n      \"nome\" : \"Grêmio Mais\",\n      \"id\" : \"7\",\n      \"dataFimVigencia\" : \"20181130\",\n      \"dataInicioVigencia\" : \"20181122\",\n      \"detalhes\" : \"Edição ouro de mais um produto do Grêmio Mais\",\n      \"descricao\" : \"Edição 115 Anos\"\n    }, {\n      \"limiteMaximoCompra\" : \"4\",\n      \"tema\" : {\n        \"estilos\" : [ {\n          \"valor\" : \"#00288C\",\n          \"nome\" : \"cor-fundo ou cor-botao\"\n        }, {\n          \"valor\" : \"#00288C\",\n          \"nome\" : \"cor-fundo ou cor-botao\"\n        } ]\n      },\n      \"valor\" : \"000000000500\",\n      \"nome\" : \"Grêmio Mais\",\n      \"id\" : \"7\",\n      \"dataFimVigencia\" : \"20181130\",\n      \"dataInicioVigencia\" : \"20181122\",\n      \"detalhes\" : \"Edição ouro de mais um produto do Grêmio Mais\",\n      \"descricao\" : \"Edição 115 Anos\"\n    } ]\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaTitulosCapitalizacaoResp>(exampleJson)
            : default(ConsultaTitulosCapitalizacaoResp);
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
        [Route("/saqueepague/SepTransaction/1.25.1/token")]
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
