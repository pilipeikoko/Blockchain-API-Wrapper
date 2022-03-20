using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Modules.Abstract;
using BlockchainScanner.Modules.Services;

namespace BlockchainScanner.Chain
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