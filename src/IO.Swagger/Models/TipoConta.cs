/*
 * Saque e Pague Transaction
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.17.0
 * Contact: captura_atm@saqueepague.com.br
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
{         /// <summary>
        /// Tipo de conta do extrato (CC = conta corrente, CP = conta poupança, CS = conta salário).
        /// </summary>
        /// <value>Tipo de conta do extrato (CC = conta corrente, CP = conta poupança, CS = conta salário).</value>
        public enum TipoConta
        { 
            /// <summary>
            /// Enum CCEnum for CC
            /// </summary>
            [EnumMember(Value = "CC")]
            CCEnum = 1,
            
            /// <summary>
            /// Enum CPEnum for CP
            /// </summary>
            [EnumMember(Value = "CP")]
            CPEnum = 2,
            
            /// <summary>
            /// Enum CSEnum for CS
            /// </summary>
            [EnumMember(Value = "CS")]
            CSEnum = 3
        }
}
