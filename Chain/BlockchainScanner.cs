using BlockchainAnalysis.Chain.Configs;
using BlockchainAnalysis.Modules.Abstract;
using BlockchainAnalysis.Modules.Services;

namespace BlockchainAnalysis.Chain
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