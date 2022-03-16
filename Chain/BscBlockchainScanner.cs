using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAnalysis
{ 
    public class BscBlockchainScanner : BlockchainScanner
    {
        protected internal override BlockchainConfig BlockchainConfig { get; internal set; }

        public BscBlockchainScanner(BscConfig blockchainConfig) : base(blockchainConfig)
        {

        }
    }
}
