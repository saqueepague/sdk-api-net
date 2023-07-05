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
    public class DemonstrativoINSSComCartaoApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Confirmação de operação de demonstrativo INSS.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de confirmação de operação de demonstrativo INSS.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.3/demonstrativoINSSConf")]
        [ValidateModelState]
        [SwaggerOperation("DemonstrativoINSSConfPost")]
        public virtual IActionResult DemonstrativoINSSConfPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]TransacConf body)
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
        /// <remarks>Operação de extrato.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de operação de demonstrativo INSS.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.3/demonstrativoINSS")]
        [ValidateModelState]
        [SwaggerOperation("DemonstrativoINSSPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(DemonstrativoINSSResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult DemonstrativoINSSPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]DemonstrativoINSSReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DemonstrativoINSSResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfDemonstrativoINSS\" : {\n    \"recibo\" : \"@                DEMONSTRATIVO INSS                @                                                @ CLIENTE: EUGENIO SCHMITT COELHO                @ AGENCIA: 0150 CONTA: 03.013689.0-1             @ SALDO DA CONTA                                 @ SALDO DEVEDOR...............R$          450,35-@ TOTAL DEVEDOR...............R$          450,35-@ LIMITE DA CONTA.............R$          100,00 @ LIMITE DA CONTA DISPONIVEL..R$          350,35-@--------- MOVIMENTOS DA CONTA CORRENTE ---------@@    SALDO ANT EM 18/01/2019               93,56-@    MOVIMENTOS JAN/2019                         @    COMPRAS           201218              85,68-@    COMPRAS           201218             139,14-@    COMPRAS           211218              20,70-@    COMPRAS           211218              39,00-@    SALDO NA DATA                        378,08-@\",\n    \"qtdPaginas\" : \"000010\"\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"numAgencia\" : \"4029\",\n    \"numConta\" : \"0082348296\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DemonstrativoINSSResp>(exampleJson)
            : default(DemonstrativoINSSResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de identificação do cliente e informações adicionais de sua conta.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de identificação.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.3/identificacao")]
        [ValidateModelState]
        [SwaggerOperation("IdentificacaoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(IdentificacaoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult IdentificacaoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]IdentificacaoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(IdentificacaoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfIdentificacao\" : {\n    \"pedirToken\" : \"01\",\n    \"valorLimiteFavorecido\" : \"000000030000\",\n    \"frase\" : \"Informe o token gerado em seu app:\",\n    \"numAgencia\" : \"4029\",\n    \"perguntas\" : [ {\n      \"pergunta\" : \"Qual é o dia de seu aniversário?\",\n      \"tamResposta\" : \"2\",\n      \"id\" : \"1\"\n    }, {\n      \"pergunta\" : \"Qual é o dia de seu aniversário?\",\n      \"tamResposta\" : \"2\",\n      \"id\" : \"1\"\n    } ],\n    \"idPositiva\" : [ {\n      \"pos8\" : \"4E-8G-1P\",\n      \"idTela\" : \"1\",\n      \"pos4\" : \"P1-G8-E4\",\n      \"pos5\" : \"REG SOS\",\n      \"pos6\" : \"EN/UQ/AM\",\n      \"pos7\" : \"69 05 41\",\n      \"pos1\" : \"SOS GER\",\n      \"pos2\" : \"MA/QU/NE\",\n      \"pos3\" : \"14 50 96\"\n    }, {\n      \"pos8\" : \"4E-8G-1P\",\n      \"idTela\" : \"1\",\n      \"pos4\" : \"P1-G8-E4\",\n      \"pos5\" : \"REG SOS\",\n      \"pos6\" : \"EN/UQ/AM\",\n      \"pos7\" : \"69 05 41\",\n      \"pos1\" : \"SOS GER\",\n      \"pos2\" : \"MA/QU/NE\",\n      \"pos3\" : \"14 50 96\"\n    } ],\n    \"numConta\" : \"0082348296\",\n    \"transacValidas\" : \"068101068010\",\n    \"saldo\" : \"000000005000\"\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"numAgencia\" : \"4029\",\n    \"numConta\" : \"0082348296\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<IdentificacaoResp>(exampleJson)
            : default(IdentificacaoResp);
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
        [Route("/saqueepague/SepTransaction/1.27.3/token")]
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
