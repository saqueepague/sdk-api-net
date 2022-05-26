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
    public class EmprestimoSemCartaoApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta de condições disponíveis de parcelamento do empréstimo.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de consulta parcelas de empréstimo.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.2/consultaParcelasEmprestimo")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaParcelasEmprestimoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaParcelasEmprestimoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaParcelasEmprestimoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaParcelasEmprestimoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaParcelasEmprestimoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfConsultaParcelasEmprestimo\" : {\n    \"opcoesParcelas\" : [ {\n      \"valorParcela\" : \"000000005000\",\n      \"qntParcelas\" : \"5\",\n      \"tributos\" : {\n        \"iof\" : \"0008094\",\n        \"cetAnual\" : \"0008094\",\n        \"valorJuros\" : \"000000001099\",\n        \"taxaJurosAnual\" : \"0008094\",\n        \"ultimoVencimento\" : \"20200928\",\n        \"taxaValorIof\" : \"0005012\",\n        \"iofAdicional\" : \"0008094\",\n        \"taxaJurosMensal\" : \"0008094\",\n        \"cetMensal\" : \"0008094\",\n        \"valorTotalParcelas\" : \"000000500010\",\n        \"valorSolicitado\" : \"000000000499\",\n        \"dataContratacao\" : \"20200928\",\n        \"primeiroVencimento\" : \"20200928\",\n        \"taxaValorSolicitado\" : \"0000700\"\n      }\n    }, {\n      \"valorParcela\" : \"000000005000\",\n      \"qntParcelas\" : \"5\",\n      \"tributos\" : {\n        \"iof\" : \"0008094\",\n        \"cetAnual\" : \"0008094\",\n        \"valorJuros\" : \"000000001099\",\n        \"taxaJurosAnual\" : \"0008094\",\n        \"ultimoVencimento\" : \"20200928\",\n        \"taxaValorIof\" : \"0005012\",\n        \"iofAdicional\" : \"0008094\",\n        \"taxaJurosMensal\" : \"0008094\",\n        \"cetMensal\" : \"0008094\",\n        \"valorTotalParcelas\" : \"000000500010\",\n        \"valorSolicitado\" : \"000000000499\",\n        \"dataContratacao\" : \"20200928\",\n        \"primeiroVencimento\" : \"20200928\",\n        \"taxaValorSolicitado\" : \"0000700\"\n      }\n    } ],\n    \"limiteMinimoEmprestimo\" : \"000000500000\",\n    \"limiteMaximoEmprestimo\" : \"000005000000\",\n    \"valorTotalDisponivel\" : \"000000700000\",\n    \"dataPrimeiraParcela\" : \"20181122\",\n    \"nomeAgenciaBancaria\" : \"Agência bancária\",\n    \"nomeTitularConta\" : \"Carl Edward Sagan\"\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"numAgencia\" : \"4029\",\n    \"numConta\" : \"0082348296\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaParcelasEmprestimoResp>(exampleJson)
            : default(ConsultaParcelasEmprestimoResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Confirmação de operação de empréstimo.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de confirmação de operação de empréstimo.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.2/emprestimoConf")]
        [ValidateModelState]
        [SwaggerOperation("EmprestimoConfPost")]
        public virtual IActionResult EmprestimoConfPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]TransacConf body)
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
        /// <remarks>Operação de empréstimo.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de empréstimo.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.27.2/emprestimo")]
        [ValidateModelState]
        [SwaggerOperation("EmprestimoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmprestimoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult EmprestimoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]EmprestimoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmprestimoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"numAgencia\" : \"4029\",\n    \"numConta\" : \"0082348296\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  },\n  \"InfEmprestimo\" : {\n    \"recibo\" : \"@           COMPROVANTE DE EMPRESTIMO            @------------------------------------------------@ Agencia....: 0101                              @ Conta......: 74414-0                           @ Nome.......: EUGENIO SCHMITT COELHO            @@------------------------------------------------@ Favorecido: EUGENIO SCHMITT COELHO             @ Agencia Destino:                           0101@ Conta Destino:         Conta Corrente - 74414-0@@Tipo            NSU                        Valor@Dinheiro        697841472523             R$20,00@------------------------------------------------@               SAC - 0800 123 4569@      SAC - DEF. AUDITIVO - 0800 123 4568@            OUVIDORIA - 0800 123 4567@@             www.siteparceiro.com.br@\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EmprestimoResp>(exampleJson)
            : default(EmprestimoResp);
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
