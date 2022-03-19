using BlockchainAnalysis.Chain.Configs;
using BlockchainAnalysis.Dtos.Responses;
using BlockchainAnalysis.Models;
using BlockchainAnalysis.Modules.Abstract;
using System.Threading.Tasks;

namespace BlockchainAnalysis.Modules.Services
{
    public class TransactionModuleService : ModuleService, ITransactionModuleService
    {
        public TransactionModuleService(BlockchainConfig blockchainConfig) : base(blockchainConfig)
        {
        }

        public async Task<TransactionStatus> GetTransactionReceiptStatus(string transactionHash)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=transaction&action=gettxreceiptstatus&txhash={transactionHash}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TransactionReceiptResponse>(url).ConfigureAwait(false);

            return response.Result.Result == "0" ? TransactionStatus.Fail : TransactionStatus.Pass;
        }
    }
}