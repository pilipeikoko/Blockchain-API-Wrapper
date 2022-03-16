using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockchainAnalysis.Modules;

namespace BlockchainAnalysis
{
    public abstract class BlockchainScanner
    {
        private readonly IAccountModuleService _accountModuleService;

        protected internal abstract BlockchainConfig BlockchainConfig { get; internal set; }

        public BlockchainScanner(BlockchainConfig blockchainConfig)
        {
            BlockchainConfig = blockchainConfig;

            _accountModuleService = new AccountModuleService(blockchainConfig);
        }
    }
}