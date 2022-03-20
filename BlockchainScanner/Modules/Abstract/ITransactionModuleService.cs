using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface ITransactionModuleService
    {
        Task<TransactionStatus> GetTransactionReceiptStatus(string transactionHash);
    }
}
