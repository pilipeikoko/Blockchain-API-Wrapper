using System;
using System.Threading.Tasks;
using BlockchainAnalysis.Modules;
using BscScanner;

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
