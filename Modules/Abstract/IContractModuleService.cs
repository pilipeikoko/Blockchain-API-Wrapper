using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainAnalysis.Models;

namespace BlockchainAnalysis.Modules.Abstract
{
    public interface IContractModuleService
    {
        Task<string> GetAbiFromContractAddress(string contractAddress);
        Task<IEnumerable<Contract>> GetContractSourceCodeByAddress(string contractAddress);
    }
}
