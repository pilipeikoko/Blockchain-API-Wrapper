using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAnalysis
{
    public abstract class BlockchainConfig
    {
        protected internal abstract string ApiUrl { get; }
        protected internal abstract string ApiKey { get; internal set; }

        public BlockchainConfig(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
