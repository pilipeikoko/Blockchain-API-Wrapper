using System.Collections.Generic;
using System.Linq;
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

        public async Task<Contract> GetContractSourceCodeByAddress(string contractAddress)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=contract&action=getsourcecode&address={contractAddress}&apikey={BlockchainConfig.ApiKey}";

            //Returned in array, taking first.
            //I don't see sense of requesting more than one contract so
            var response = await Get<SourceCodeResponse>(url).ConfigureAwait(false);

            return response.Result.FirstOrDefault();
        }
    }
}