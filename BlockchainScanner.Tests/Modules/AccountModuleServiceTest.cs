using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Models;
using BlockchainScanner.Modules.Abstract;
using BlockchainScanner.Modules.Services;
using Xunit;

namespace BlockchainScanner.Tests.Modules
{
    public class AccountModuleServiceTest
    {
        private readonly IAccountModuleService _accountService;

        private const string ApiKey = "";
        //Pro code parts weren't ever tested :(
        private const bool IsProApiKey = false;

        private const string FirstEmptyTestAddress = "0x60d573D6F01869e1D69f71a468CE4eD246111290";
        private const string SecondEmptyTestAddress = "0xbf355Ab92652B7889CC1242D00e02e4212cA3E06";

        public AccountModuleServiceTest()
        {
            BscConfig config = new BscConfig(ApiKey);
            EthereumConfig ethConfig = new EthereumConfig("");

            _accountService = new AccountModuleService(ethConfig);
        }


        [Fact]
        public async Task GetMainTokenBalanceTest()
        {
            //Please, make this test fail itself! :D
            double actual = await _accountService.GetMainTokenBalance(FirstEmptyTestAddress);

            double expected = 0f;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public async Task GetMainTokenMultipleBalanceTest()
        {
            IEnumerable<string> addresses = new List<string>
            {
                FirstEmptyTestAddress,
                SecondEmptyTestAddress
            };

            IEnumerable<MainTokenBalance> balances = await _accountService.GetMainTokenMultipleBalance(addresses);

            Assert.True(balances.All(x => x.Balance == 0f));
        }

        [Fact]
        public async Task GetMainTokenBalanceByBlockNumberTest()
        {
            if (IsProApiKey)
            {
                MainTokenBalance balance =
                    await _accountService.GetMainTokenBalanceByBlockNumber(FirstEmptyTestAddress, "6360000");

                float expected = 0.007f;

                Assert.Equal(balance.Balance, expected);
            }
            else
            {
                await Assert.ThrowsAsync<HttpRequestException>(() =>
                    _accountService.GetMainTokenBalanceByBlockNumber(FirstEmptyTestAddress, "6360000"));
            }
        }
    }
}