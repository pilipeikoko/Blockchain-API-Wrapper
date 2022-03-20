using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IAccountModuleService
    {
        public Task<double> GetMainTokenBalance(string address, string tag = "latest");
        public Task<IEnumerable<MainTokenBalance>> GetMainTokenMultipleBalance(IEnumerable<string> addresses, string tag = "latest");
        //Pro required
        public Task<MainTokenBalance> GetMainTokenBalanceByBlockNumber(string address, string blockNumber);
        //Pro required
        public Task<IEnumerable<MainTokenBalance>> GetMainTokenBalanceMultipleByBlockNumber(IEnumerable<string> addresses, string blockNumber);

        public Task<IEnumerable<Transaction>> GetListOfNormalTransactionsByAddress(string address,
            string startBlock = "0", string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc");

        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByAddress(string address,
            string startBlock = "0", string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc");

        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByHash(string hash);
        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByBlockRange(string startBlock, string endBlock, string page = "1", string offset = "10", string sort = "asc");

        public Task<IEnumerable<Transaction>> GetListOfBep20TokenTransactions(string address,
            string contractAddress, string startBlock = "0", string endBlock = "99999999",
            string page = "1", string offset = "10", string sort = "asc");

        public Task<IEnumerable<Transaction>> GetListOfBep721TokenTransactions(string address,
            string contractAddress, string startBlock = "0", string endBlock = "99999999",
            string page = "1", string offset = "10", string sort = "asc");

        public Task<IEnumerable<Block>> GetListOfBlocksValidatedByAddress(string address, string contractAddress,
            string blockType = "blocks", string page = "1", string offset = "10");

    }
}
