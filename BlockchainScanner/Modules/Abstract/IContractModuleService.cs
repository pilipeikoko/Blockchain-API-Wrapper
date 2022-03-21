using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IContractModuleService
    {
        /// <summary>
        /// Returns the contract Application Binary Interface ( ABI ) of a verified smart contract.
        /// </summary>
        /// <param name="contractAddress">The contract address that has a verified source code</param>
        /// <returns>The contract Application Binary Interface ( ABI ) of a verified smart contract</returns>
        Task<string> GetAbiFromContractAddress(string contractAddress);

        /// <summary>
        /// Returns the Solidity source code of a verified smart contract.
        /// </summary>
        /// <param name="contractAddress">The contract address that has a verified source code</param>
        /// <returns>The Solidity source code of a verified smart contract.</returns>
        Task<Contract> GetContractSourceCodeByAddress(string contractAddress);
    }
}
