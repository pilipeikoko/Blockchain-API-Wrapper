using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface ITokenModuleService
    {
        Task<double> GetTokenTotalSupplyByContractAddress(string contractAddress);
        Task<double> GetTokenCirculatingSupplyByContractAddress(string contractAddress);
        Task<double> GetTokenBalanceByContractAddress(string address, string contractAddress, string tag = "latest");
        //Pro required
        Task<IEnumerable<TokenHolder>> GetTokenHolderListByContractAddress(string contractAddress, string page = "1", string offset = "10");
        //Pro required
        Task<double> GetHistoricalTokenSupplyByContractAddressAndBlockNumber(string contractAddress, string blockNumber);
        //Pro required
        Task<double> GetHistoricalTokenAccountBalanceByContractAddressAndBlockNumber(string address, string contractAddress, string blockNumber);
        //Pro required
        Task<TokenInformation> GetTokenInformationByContractAddress(string contractAddress);
        //Pro required
        Task<IEnumerable<TokenHolding>> GetAddressTokenHoldings(string address, string page = "1", string offset = "10");
        //Pro required
        Task<IEnumerable<NftTokenHolding>> GetAddressNftTokenHoldings(string address, string page = "1", string offset = "10");
        //Pro required
        Task<IEnumerable<NftInventoryItem>> GetAddressNftInventoryByContractAddress(string address,string contractAddress, string page = "1", string offset = "10");
    }
}
