/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.27.1
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
    public class PagamentoSemCartaoApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta de informações do boleto a ser pago em dinheiro ou débito em conta.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição para consulta de pagamento de boleto com cartão.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.1/consultaPagamento")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaPagamentoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaPagamentoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaPagamentoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaPagamentoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaPagamentoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"InfConsultaPagamento\" : {\n    \"aceitaPagamentoParcial\" : \"01\",\n    \"dataPagamento\" : \"20181122\",\n    \"desconto\" : \"000000000499\",\n    \"mensagem\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"valor\" : \"000000005000\",\n    \"cip\" : {\n      \"valorMaximoPermitidoPagamento\" : \"000000050000\",\n      \"valorMinimoPermitidoPagamento\" : \"000000000500\",\n      \"valorJurosCalculado\" : \"000000000499\",\n      \"valorAbatimento\" : \"000000000499\",\n      \"tipoValorAceito\" : \"3\",\n      \"valorMultaCalculadada\" : \"000000000499\"\n    },\n    \"valorMinimo\" : \"000000000500\",\n    \"codBarras\" : {\n      \"codigo\" : \"12345678912346579812345678912345678913456789123456789\",\n      \"dataVencimento\" : \"20181122\"\n    },\n    \"cedente\" : \"Saque e Pague\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaPagamentoResp>(exampleJson)
            : default(ConsultaPagamentoResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Confirmação de operação de pagamento de boleto de cobrança.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de confirmação de operação de pagamento.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.1/pagamentoConf")]
        [ValidateModelState]
        [SwaggerOperation("PagamentoConfPost")]
        public virtual IActionResult PagamentoConfPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]TransacConf body)
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
        /// <remarks>Operação de pagamento de boleto de cobrança com cartão.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição para pagamento de boleto com cartão.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.1/pagamento")]
        [ValidateModelState]
        [SwaggerOperation("PagamentoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(PagamentoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult PagamentoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]PagamentoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PagamentoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfPagamentoResp\" : {\n    \"recibo\" : \"@            COMPROVANTE DE PAGAMENTO            @                                                @ CEDENTE: 008 BANCO SAQUE E PAGUE               @ VALOR..: 263,85                                @ DATA DO PAGAMENTO.: 29/01/2019                 @ CODIGO DE BARRAS                               @@   84600000000-3 25850072001-1                 @   10357244475-5 01192190121-8                  @\",\n    \"qtdeViasComprovante\" : \"1\",\n    \"dataPagamento\" : \"20181122\",\n    \"desconto\" : \"000000000499\",\n    \"mensagem\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"valor\" : \"000000005000\",\n    \"cedente\" : \"Saque e Pague\"\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PagamentoResp>(exampleJson)
            : default(PagamentoResp);
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
        [Route("/saqueepague/SepTransaction/1.27.1/token")]
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
