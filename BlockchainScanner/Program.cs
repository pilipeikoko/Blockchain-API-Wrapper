using System.Threading.Tasks;
using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Modules.Services;

namespace BlockchainScanner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BscConfig config = new BscConfig("");

            AccountModuleService accountModule = new AccountModuleService(config);

            double balance = await accountModule.GetMainTokenBalance("0x60d573D6F01869e1D69f71a468CE4eD246111290");
        }
    }
}
