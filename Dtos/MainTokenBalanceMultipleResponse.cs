using System.Collections.Generic;
using BscScanner.Dtos;
using Newtonsoft.Json;

namespace BscScanner.Data {
    internal class MainTokenBalanceMultipleResponse : Response {
       
        [JsonProperty("result")]
        public List<MainTokenBalance> Balances { get; set; }
    }
}