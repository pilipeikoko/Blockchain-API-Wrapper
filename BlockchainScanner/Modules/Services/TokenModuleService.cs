using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Dtos.Responses;
using BlockchainScanner.Models;
using BlockchainScanner.Modules.Abstract;

namespace BlockchainScanner.Modules.Services
{
    public class TokenModuleService : ModuleService, ITokenModuleService
    {
        public TokenModuleService(BlockchainConfig blockchainConfig) : base(blockchainConfig)
        {
        }

        public async Task<double> GetTokenTotalSupplyByContractAddress(string contractAddress)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=tokensupply&contractaddress={contractAddress}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenAmountResponse>(url).ConfigureAwait(false);

            return double.Parse(response.Result);
        }

        public async Task<double> GetTokenCirculatingSupplyByContractAddress(string contractAddress)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=tokenCsupply&contractaddress={contractAddress}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenAmountResponse>(url).ConfigureAwait(false);

            return double.Parse(response.Result);
        }

        public async Task<double> GetTokenBalanceByContractAddress(string address, string contractAddress, string tag = "latest")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=tokenbalance&contractaddress={contractAddress}&address={address}&tag={tag}&apikey={BlockchainConfig.ApiKey}";

            var obj = await Get<TokenAmountResponse>(url).ConfigureAwait(false);

            return double.Parse(obj.Result);
        }

        public async Task<IEnumerable<TokenHolder>> GetTokenHolderListByContractAddress(string contractAddress, string page = "1", string offset = "10")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=token&action=tokenholderlist&contractaddress={contractAddress}&page={page}&offset={offset}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenHolderResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<double> GetHistoricalTokenSupplyByContractAddressAndBlockNumber(string contractAddress, string blockNumber)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=tokensupplyhistory&contractaddress={contractAddress}&blockno={blockNumber}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenAmountResponse>(url).ConfigureAwait(false);

            return double.Parse(response.Result);
        }

        public async Task<double> GetHistoricalTokenAccountBalanceByContractAddressAndBlockNumber(string address, string contractAddress,
            string blockNumber)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=tokenbalancehistory&address={address}&contractaddress={contractAddress}&blockno={blockNumber}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenAmountResponse>(url).ConfigureAwait(false);

            return double.Parse(response.Result);
        }

        public async Task<TokenInformation> GetTokenInformationByContractAddress(string contractAddress)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=token&action=tokeninfo&contractaddress={contractAddress}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenInformationResponse>(url).ConfigureAwait(false);

            return response.Result.FirstOrDefault();
        }

        public async Task<IEnumerable<TokenHolding>> GetAddressTokenHoldings(string address, string page = "1", string offset = "10")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=addresstokenbalance&address={address}&page={page}&offset={offset}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenHoldingResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<NftTokenHolding>> GetAddressNftTokenHoldings(string address, string page = "1", string offset = "10")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=addresstokennftbalance&address={address}&page={page}&offset={offset}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<NftTokenHoldingResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<NftInventoryItem>> GetAddressNftInventoryByContractAddress(string address, string contractAddress, string page = "1", string offset = "10")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=addresstokennftinventory&address={address}&contractaddress={contractAddress}&page={page}&offset={offset}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<NftInventoryItemResponse>(url).ConfigureAwait(false);

            return response.Result;
        }
    }
}
