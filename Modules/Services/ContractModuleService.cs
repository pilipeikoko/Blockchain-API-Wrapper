using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainAnalysis.Chain.Configs;
using BlockchainAnalysis.Dtos.Responses;
using BlockchainAnalysis.Models;
using BlockchainAnalysis.Modules.Abstract;

namespace BlockchainAnalysis.Modules.Services
{
    public class ContractModuleService : ModuleService, IContractModuleService
    {
        public ContractModuleService(BlockchainConfig blockchainConfig) : base(blockchainConfig)
        {
        }

        public async Task<string> GetAbiFromContractAddress(string contractAddress)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=contract&action=getabi&address={contractAddress}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<AbiResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<Contract>> GetContractSourceCodeByAddress(string contractAddress)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=contract&action=getsourcecode&address={contractAddress}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<SourceCodeResponse>(url).ConfigureAwait(false);

            return response.Result;
        }
    }
}