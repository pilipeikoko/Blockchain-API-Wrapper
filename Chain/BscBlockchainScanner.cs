using BlockchainScanner.Chain.Configs;

namespace BlockchainScanner.Chain
{ 
    public class BscBlockchainScanner : BlockchainScanner
    {
        protected internal override BlockchainConfig BlockchainConfig { get; internal set; }

        public BscBlockchainScanner(BscConfig blockchainConfig) : base(blockchainConfig)
        {

        }
    }
}
