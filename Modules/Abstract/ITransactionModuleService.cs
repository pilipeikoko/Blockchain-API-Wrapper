using BlockchainAnalysis.Models;
using System.Threading.Tasks;

namespace BlockchainAnalysis.Modules.Abstract
{
    public interface ITransactionModuleService
    {
        Task<TransactionStatus> GetTransactionReceiptStatus(string transactionHash);
    }
}
