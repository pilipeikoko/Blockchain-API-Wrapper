using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;
using BlockchainScanner.Utils;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IAccountModuleService
    {
        /// <summary>
        /// Returns the Main Token balance of a given address.
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="tag">The string pre-defined block parameter, either earliest, pending or latest</param>
        /// <returns>The result is returned in Main Token</returns>
        public Task<double> GetMainTokenBalance(string address, string tag = "latest");

        /// <summary>
        /// Returns the balance of the accounts from a list of addresses.
        /// </summary>
        /// <param name="addresses">The strings representing the addresses to check for balance, separated by , commas.
        /// Up to 20 addresses per call</param>
        /// <param name="tag">The string pre-defined block parameter, either earliest, pending or latest</param>
        /// <returns>The result is returned in Main Token</returns>
        public Task<IEnumerable<MainTokenBalance>> GetMainTokenMultipleBalance(IEnumerable<string> addresses, string tag = "latest");

        /// <summary>
        /// Pro required.
        /// Returns the historical BNB balance of an address at a certain block height. 
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="blockNumber">The integer block number to check balance for eg. 2000000</param>
        /// <returns>The result is returned in Main Token</returns>
        [ProRequired]
        public Task<MainTokenBalance> GetMainTokenBalanceByBlockNumber(string address, string blockNumber);

        /// <summary>
        /// Pro required.
        /// Returns the historical BNB balance of multiple addresses at a certain block height. 
        /// </summary>
        /// <param name="addresses">The strings representing the addresses to check for balance, separated by , commas
        /// <param name="blockNumber">The integer block number to check balance for eg. 2000000</param>
        /// <returns>The result is returned in Main Token</returns>
        [ProRequired]
        public Task<IEnumerable<MainTokenBalance>> GetMainTokenBalanceMultipleByBlockNumber(IEnumerable<string> addresses, string blockNumber);

        /// <summary>
        /// Returns the list of transactions performed by an address, with optional pagination.
        /// Note : This API endpoint returns a maximum of 10000 records only.
        /// Tip: Specify a smaller startblock and endblock range for faster search results.
        /// </summary>
        /// <param name="address">The string representing the addresses to check for balance</param>
        /// <param name="startBlock">The integer block number to start searching for transactions</param>
        /// <param name="endBlock">The integer block number to stop searching for transactions</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>List of transactions performed by an address</returns>
        public Task<IEnumerable<Transaction>> GetListOfNormalTransactionsByAddress(string address,
            string startBlock = "0", string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc");

        /// <summary>
        /// Returns the list of internal transactions performed by an address, with optional pagination.
        /// Note : This API endpoint returns a maximum of 10000 records only.
        /// Tip: Specify a smaller startblock and endblock range for faster search results.
        /// </summary>
        /// <param name="address">The string representing the addresses to check for balance</param>
        /// <param name="startBlock">The integer block number to start searching for transactions</param>
        /// <param name="endBlock">The integer block number to stop searching for transactions</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>List of internal transactions performed by an address</returns>
        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByAddress(string address,
            string startBlock = "0", string endBlock = "99999999", string page = "1",
            string offset = "10", string sort = "asc");

        /// <summary>
        /// Returns the list of internal transactions performed within a transaction.
        /// Note : This API endpoint returns a maximum of 10000 records only.
        /// </summary>
        /// <param name="hash">The string representing the transaction hash to check for internal transactions</param>
        /// <returns>List of internal transactions performed by hash
        /// The isError field returns 0 for successful transactions and 1 for rejected/cancelled transactions.</returns>
        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByHash(string hash);

        /// <summary>
        /// Returns the list of internal transactions performed within a block range, with optional pagination.
        /// Note : This API endpoint returns a maximum of 10000 records only.
        /// Tip: Specify a smaller startblock and endblock range for faster search results.
        /// </summary>
        /// <param name="startBlock">The integer block number to start searching for transactions</param>
        /// <param name="endBlock">The integer block number to stop searching for transactions</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>List of internal transactions performed by hash
        /// The isError field returns 0 for successful transactions and 1 for rejected/cancelled transactions.</returns>
        public Task<IEnumerable<Transaction>> GetListOfInternalTransactionsByBlockRange(string startBlock, string endBlock, string page = "1", string offset = "10", string sort = "asc");

        /// <summary>
        /// Returns the list of tokens transferred by an address, with optional filtering by token contract.
        /// Usage:
        /// Token transfers from an address, specify the address parameter
        /// Token transfers from a contract address, specify the contract address parameter
        /// Token transfers from an address filtered by a token contract, specify both address and contract address parameters.
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="contractAddress">The string representing the token contract address to check for balance</param>
        /// <param name="startBlock">The integer block number to start searching for transactions</param>
        /// <param name="endBlock">The integer block number to stop searching for transactions</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>List of tokens transferred by an address, with optional filtering by token contract.</returns>
        public Task<IEnumerable<Transaction>> GetListOfTokenTransactions(string address,
            string contractAddress, string startBlock = "0", string endBlock = "99999999",
            string page = "1", string offset = "10", string sort = "asc");

        /// <summary>
        /// Returns the list of NFT tokens transferred by an address, with optional filtering by token contract.
        /// Usage:
        /// NFT transfers from an address, specify the address parameter
        /// NFT transfers from a contract address, specify the contract address parameter
        /// NFT transfers from an address filtered by a token contract, specify both address and contract address parameters.
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="contractAddress">The string representing the token contract address to check for balance</param>
        /// <param name="startBlock">The integer block number to start searching for transactions</param>
        /// <param name="endBlock">The integer block number to stop searching for transactions</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>List of NFT tokens transferred by an address, with optional filtering by token contract.</returns>
        public Task<IEnumerable<Transaction>> GetListOfNft721TokenTransactions(string address,
            string contractAddress, string startBlock = "0", string endBlock = "99999999",
            string page = "1", string offset = "10", string sort = "asc");

        /// <summary>
        /// Returns the list of blocks validated by an address.
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="contractAddress">The string representing the token contract address to check for balance</param>
        /// <param name="blockType">The string pre-defined block type, blocks for canonical blocks </param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <returns>List of blocks validated by an address.</returns>
        public Task<IEnumerable<Block>> GetListOfBlocksValidatedByAddress(string address, string contractAddress,
            string blockType = "blocks", string page = "1", string offset = "10");

    }
}
