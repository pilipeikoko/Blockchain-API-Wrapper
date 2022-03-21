using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface ITransactionModuleService
    {
        /// <summary>
        /// Returns the status code of a transaction execution.
        /// Tip: The status field returns 0 for failed transactions and 1 for successful transactions.
        /// </summary>
        /// <param name="transactionHash">The string representing the transaction hash to check the execution status</param>
        /// <returns>The status code of a transaction execution.</returns>
        Task<TransactionStatus> GetTransactionReceiptStatus(string transactionHash);
    }
}
