using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainScanner.Chain.Configs
{
    public class EthereumConfig : BlockchainConfig
    {
        public EthereumConfig(string apiKey) : base(apiKey)
        {
        }

        protected internal override string ApiUrl => "https://api.etherscan.io/api";
        protected internal override string ApiKey { get; internal set; }
    }
}
