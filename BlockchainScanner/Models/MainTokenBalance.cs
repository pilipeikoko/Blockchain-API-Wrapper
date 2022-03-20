﻿using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class MainTokenBalance
    {
        [JsonProperty("account")] 
        public string Account { get; set; }

        [JsonProperty("balance")] 
        public float Balance { get; set; }
    }
}