using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IStatsModule
    {
        Task<double> GetMainTokenTotalSupply();
        Task<IEnumerable<Validator>> GetValidatorsList();
        Task<MainTokenPrice> GetMainTokenLastPrice();

        //Pro required
        Task<IEnumerable<DailyPriceItem>> GetMainTokenHistoricalPrice(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro required
        Task<IEnumerable<DailyTransactionFee>> GetDailyTransactionFee(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro required
        Task<IEnumerable<DailyNewAddressCount>> GetDailyNewAddressCount(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro required
        Task<IEnumerable<DailyNetworkUtilization>> GetDailyNetworkUtilization(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro required
        Task<IEnumerable<DailyTransactionCount>> GetDailyTransactionCount(DateTime startDate, DateTime endDate, string sort = "asc");
    }
}
