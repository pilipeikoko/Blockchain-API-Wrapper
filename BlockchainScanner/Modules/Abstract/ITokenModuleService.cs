using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;
using BlockchainScanner.Utils;

namespace BlockchainScanner.Modules.Abstract
{
    public interface ITokenModuleService
    {
        /// <summary>
        /// Returns the total supply of token.
        /// </summary>
        /// <param name="contractAddress">The contract address of the token</param>
        /// <returns>The total supply of token</returns>
        Task<double> GetTokenTotalSupplyByContractAddress(string contractAddress);

        /// <summary>
        /// Returns the current circulating supply of a token. 
        /// </summary>
        /// <param name="contractAddress">The contract address of the token</param>
        /// <returns>Current circulating supply of a token.</returns>
        Task<double> GetTokenCirculatingSupplyByContractAddress(string contractAddress);

        /// <summary>
        /// Returns the current balance of a token of an address.
        /// </summary>
        /// <param name="address">The contract address of the token</param>
        /// <param name="contractAddress">The string representing the address to check for token balance</param>
        /// <param name="tag">The string pre-defined block parameter, either earliest, pending or latest</param>
        /// <returns>The current balance of a token of an address.</returns>
        Task<double> GetTokenBalanceByContractAddress(string address, string contractAddress, string tag = "latest");

        /// <summary>
        /// Pro required.
        /// Returns the current token holders and number of tokens held.
        /// </summary>
        /// <param name="contractAddress">The contract address of the token</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <returns>The current token holders and number of tokens held.</returns>
        [ProRequired]
        Task<IEnumerable<TokenHolder>> GetTokenHolderListByContractAddress(string contractAddress, string page = "1", string offset = "10");

        /// <summary>
        /// Pro required.
        /// Returns the historical amount of a token in circulation at a certain block height.
        /// Note : This endpoint is throttled to 2 calls/second regardless of API Pro tier.
        /// </summary>
        /// <param name="contractAddress">the contract address of the token</param>
        /// <param name="blockNumber">the integer block number to check total supply for eg. 4000000</param>
        /// <returns>The historical amount of a token in circulation at a certain block height</returns>
        [ProRequired]
        Task<double> GetHistoricalTokenSupplyByContractAddressAndBlockNumber(string contractAddress, string blockNumber);

        /// <summary>
        /// Pro required.
        /// Returns the balance of a token of an address at a certain block height.
        /// Note : This endpoint is throttled to 2 calls/second regardless of API Pro tier.
        /// </summary>
        /// <param name="address">The contract address of the token</param>
        /// <param name="contractAddress">The string representing the address to check for balance</param>
        /// <param name="blockNumber">The integer block number to check total supply for eg. 400000</param>
        /// <returns>The balance of a token of an address at a certain block height.</returns>
        [ProRequired]
        Task<double> GetHistoricalTokenAccountBalanceByContractAddressAndBlockNumber(string address, string contractAddress, string blockNumber);

        /// <summary>
        /// Pro required.
        /// Returns project information and social media links of a token/nft token.
        /// Note : This endpoint is throttled to 2 calls/second regardless of API Pro tier.
        /// </summary>
        /// <param name="contractAddress">The contract address of the token/nft token to retrieve token info</param>
        /// <returns>Project information and social media links of a token/nft token</returns>
        [ProRequired]
        Task<TokenInformation> GetTokenInformationByContractAddress(string contractAddress);

        /// <summary>
        /// Pro required.
        /// Returns the tokens and amount held by an address.
        /// Note : This endpoint is throttled to 2 calls/second regardless of API Pro tier.
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <returns>The tokens and amount held by an address</returns>
        [ProRequired]
        Task<IEnumerable<TokenHolding>> GetAddressTokenHoldings(string address, string page = "1", string offset = "10");

        /// <summary>
        /// Pro required.
        /// Returns the NFT tokens and amount held by an address
        /// Note : This endpoint is throttled to 2 calls/second regardless of API Pro tier.
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <returns>The NFT tokens and amount held by an address</returns>
        [ProRequired]
        Task<IEnumerable<NftTokenHolding>> GetAddressNftTokenHoldings(string address, string page = "1", string offset = "10");

        /// <summary>
        /// Pro required.
        /// Returns the NFT token inventory of an address, filtered by contract address.
        /// Note : This endpoint is throttled to 2 calls/second regardless of API Pro tier.
        /// </summary>
        /// <param name="address">The string representing the address to check for balance</param>
        /// <param name="contractAddress">The contract address of the token/nft token to retrieve token info</param>
        /// <param name="page">The integer page number, if pagination is enabled</param>
        /// <param name="offset">The number of transactions displayed per page</param>
        /// <returns>The NFT token inventory of an address, filtered by contract address.</returns>
        [ProRequired]
        Task<IEnumerable<NftInventoryItem>> GetAddressNftInventoryByContractAddress(string address,string contractAddress, string page = "1", string offset = "10");
    }
}
