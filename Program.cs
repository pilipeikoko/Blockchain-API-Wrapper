using BlockchainAnalysis.Chain;
using BlockchainAnalysis.Chain.Configs;
using BlockchainAnalysis.Modules.Services;
using System;
using System.Threading.Tasks;

namespace BlockchainAnalysis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BscConfig config = new BscConfig("");
            BscBlockchainScanner scanner = new BscBlockchainScanner(config);
            AccountModuleService servce = new AccountModuleService(config);

            float value = (await servce.GetMainTokenBalance("0x6BE43Dc58e46E65dac001544A35e0A95de59456B")).Balance;



        }
    }
}
