using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainAnalysis.Models;

namespace BlockchainAnalysis.Modules.Abstract
{
    public interface IAccountModuleService
    {
        public Task<MainTokenBalance> GetMainTokenBalance(string address, string tag);
        public Task<IEnumerable<MainTokenBalance>> GetMainTokenMultipleBalance(IEnumerable<string> addresses, string tag);
        //Pro required
        public Task<MainTokenBalance> GetMainTokenBalanceByBlockNumber(string address, string blockNumber);
        //Pro required
        public Task<IEnumerable<MainTokenBalance>> GetMainTokenBalanceMultipleByBlockNumber(IEnumerable<string> addresses, string blockNumber);

        public Task<IEnumerable<Transaction>> GetListOfNormalTransactionsByAddress(string address, string startBlock, string endBlock, string page, string offset, string sort);

        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByAddress(string address, string startBlock, string endBlock, string page, string offset, string sort);
        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByHash(string hash);
        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByBlockRange(string startBlock, string endBlock, string page, string offset, string sort);

        public Task<IEnumerable<Transaction>> GetListOfBep20TokenTransactions(string address, string contractAddress, string startBlock, string endBlock, string page, string offset, string sort);
        public Task<IEnumerable<Transaction>> GetListOfBep721TokenTransactions(string address, string contractAddress, string startBlock, string endBlock, string page, string offset, string sort);

        public Task<IEnumerable<Block>> GetListOfBlocksValidatedByAddress(string address, string contractAddress,string blockType, string page, string offset);

    }
}
