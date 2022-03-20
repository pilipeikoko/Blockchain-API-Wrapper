using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IGasModuleService
    {
        Task<GasOracle> GetGasOracle();
        //Pro required
        Task<IEnumerable<GasLimit>> GetDailyAverageGasLimit(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro required
        Task<IEnumerable<GasUsed>> GetDailyGasUsed(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro required
        Task<IEnumerable<GasPrice>> GetDailyAverageGasPrice(DateTime startDate, DateTime endDate, string sort = "asc");

    }
}
