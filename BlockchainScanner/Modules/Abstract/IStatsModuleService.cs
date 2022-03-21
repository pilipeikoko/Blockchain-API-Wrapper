using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;
using BlockchainScanner.Utils;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IStatsModule
    {
        /// <summary>
        /// Returns the current amount of Main Token in circulation.
        /// </summary>
        /// <returns>The current amount of Main Token in circulation</returns>
        Task<double> GetMainTokenTotalSupply();

        /// <summary>
        /// Returns the top 21 validators for the Chain.
        /// </summary>
        /// <returns>Top 21 validators for the Chain</returns>
        Task<IEnumerable<Validator>> GetValidatorsList();

        /// <summary>
        /// Returns the latest price of 1 Main Token
        /// </summary>
        /// <returns>
        /// The latest price of 1 Main Token</returns>
        Task<MainTokenPrice> GetMainTokenLastPrice();

        /// <summary>
        /// Pro required.
        /// Returns the historical price of 1 Main Token
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The historical price of 1 Main Token</returns>
        [ProRequired]
        Task<IEnumerable<DailyPriceItem>> GetMainTokenHistoricalPrice(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the historical amount of transaction fees paid to validators per day.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The historical amount of transaction fees paid to validators per day.</returns>
        [ProRequired]
        Task<IEnumerable<DailyTransactionFee>> GetDailyTransactionFee(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the historical number of new Chain addresses created per day.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The historical number of new Chain addresses created per day.</returns>
        [ProRequired]
        Task<IEnumerable<DailyNewAddressCount>> GetDailyNewAddressCount(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the daily average gas used over gas limit percentage.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The daily average gas used over gas limit percentage.</returns>
        [ProRequired]
        Task<IEnumerable<DailyNetworkUtilization>> GetDailyNetworkUtilization(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the number of transactions performed on the Chain per day.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The number of transactions performed on the Chain per day.</returns>
        [ProRequired]
        Task<IEnumerable<DailyTransactionCount>> GetDailyTransactionCount(DateTime startDate, DateTime endDate, string sort = "asc");
    }
}
