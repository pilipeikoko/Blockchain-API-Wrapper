using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Dtos.Responses;
using BlockchainScanner.Models;
using BlockchainScanner.Modules.Abstract;

namespace BlockchainScanner.Modules.Services
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