using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainAnalysis.Dtos.Requests;
using BscScanner.Data;
using BscScanner.Dtos;

namespace BlockchainAnalysis.Modules
{
    public class AccountModuleService : ModuleService, IAccountModuleService
    {
        public AccountModuleService(BlockchainConfig blockchainConfig)
        {
            BlockchainConfig = blockchainConfig;
        }

        protected override BlockchainConfig BlockchainConfig { get; }

        public async Task<MainTokenBalance> GetMainTokenBalance(string address, string tag = "latest")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=balance&address={address}&tag={tag}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<MainTokenBalanceResponse>(url);

            return new MainTokenBalance
            {
                Balance = float.Parse(response.Result),
                Account = address
            };
        }

        public async Task<IEnumerable<MainTokenBalance>> GetMainTokenMultipleBalance(IEnumerable<string> addresses,
            string tag = "latest")
        {
            var url = $"{BlockchainConfig.ApiUrl}?module=account&action=balancemulti&address="
                      + string.Join(",", addresses)
                      + $"&tag={tag}&apikey={BlockchainConfig.ApiKey}";
            var response = await Get<MainTokenBalanceMultipleResponse>(url).ConfigureAwait(false);

            return response.Balances;
        }

        public async Task<MainTokenBalance> GetMainTokenBalanceByBlockNumber(string address, string blockNumber)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=balancehistory&address={address}&blockno={blockNumber}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<MainTokenBalanceResponse>(url).ConfigureAwait(false);

            return new MainTokenBalance
            {
                Balance = float.Parse(response.Result),
                Account = address
            };
        }

        public async Task<IEnumerable<MainTokenBalance>> GetMainTokenBalanceMultipleByBlockNumber(
            IEnumerable<string> addresses, string blockNumber)
        {
            var url = $"{BlockchainConfig.ApiUrl}?module=account&action=balancehistory&address="
                      + string.Join(",", addresses)
                      + $"&blocknu={blockNumber}&apikey={BlockchainConfig.ApiKey}";
            var response = await Get<MainTokenBalanceMultipleResponse>(url).ConfigureAwait(false);

            return response.Balances;
        }

        public async Task<IEnumerable<Transaction>> GetListOfNormalTransactionsByAddress(string address,
            string startBlock = "0", string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=txlist&address={address}&startblock={startBlock}&endblock={endBlock}&page={page}&offset={offset}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TransactionResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByAddress(string address,
            string startBlock = "0", string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=txlistinternal&address={address}&startblock={startBlock}&endblock={endBlock}&page={page}&offset={offset}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TransactionResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByHash(string hash)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=txlistinternal&txhash={hash}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TransactionResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByBlockRange(string startBlock = "0", string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=txlistinternal&startblock={startBlock}&endblock={endBlock}&page={page}&offset={offset}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TransactionResponse>(url).ConfigureAwait(false);

            return response.Result;
        }
    }
}