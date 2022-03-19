using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlockchainAnalysis.Chain.Configs;
using BlockchainAnalysis.Dtos.Responses;
using BlockchainAnalysis.Models;
using BlockchainAnalysis.Modules.Abstract;

namespace BlockchainAnalysis.Modules.Services
{
    public class AccountModuleService : ModuleService, IAccountModuleService
    {
        public AccountModuleService(BlockchainConfig blockchainConfig) : base(blockchainConfig)
        {
        }

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

        public async Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByBlockRange(string startBlock = "0",
            string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=txlistinternal&startblock={startBlock}&endblock={endBlock}&page={page}&offset={offset}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TransactionResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<Transaction>> GetListOfBep20TokenTransactions(string address,
            string contractAddress, string startBlock = "0", string endBlock = "99999999",
            string page = "1", string offset = "10", string sort = "asc")
        {
            var url = new StringBuilder($"{BlockchainConfig.ApiUrl}?module=account&action=tokentx");
            if (address is not null)
                url.Append($"&address={address}");

            if (contractAddress is not null)
                url.Append($"&contractaddress={contractAddress}");

            var response =
                await Get<TransactionResponse>(url
                    .Append(
                        $"&startblock={startBlock}&endblock={endBlock}&page={page}&offset={offset}&sort={sort}&apikey={BlockchainConfig.ApiKey}")
                    .ToString()).ConfigureAwait(false);
            return response.Result;
        }

        public async Task<IEnumerable<Transaction>> GetListOfBep721TokenTransactions(string address,
            string contractAddress, string startBlock = "0", string endBlock = "99999999",
            string page = "1", string offset = "10", string sort = "asc")
        {
            var url = new StringBuilder($"{BlockchainConfig.ApiUrl}?module=account&action=tokennfttx");
            if (address is not null)
                url.Append($"&address={address}");

            if (contractAddress is not null)
                url.Append($"&contractaddress={contractAddress}");

            var response =
                await Get<TransactionResponse>(url
                    .Append(
                        $"&startblock={startBlock}&endblock={endBlock}&page={page}&offset={offset}&sort={sort}&apikey={BlockchainConfig.ApiKey}")
                    .ToString()).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<Block>> GetListOfBlocksValidatedByAddress(string address, string contractAddress,
            string blockType = "blocks", string page = "1", string offset = "10")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=account&action=getminedblocks&address={address}&blocktype={blockType}&page={page}&offset={offset}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<BlockResponse>(url).ConfigureAwait(false);

            return response.Result;
        }
    }
}