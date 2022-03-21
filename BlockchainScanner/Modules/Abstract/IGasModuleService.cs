using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;
using BlockchainScanner.Utils;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IGasModuleService
    {
        /// <summary>
        /// Returns the current Safe, Proposed and Fast gas prices.
        /// </summary>
        /// <returns>
        /// The current Safe, Proposed and Fast gas prices.
        /// Note: The gas prices are returned in Gwei.</returns>
        Task<GasOracle> GetGasOracle();

        /// <summary>
        /// Pro required.
        /// Returns the historical daily average gas limit of the Chain network.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The historical daily average gas limit of the Chain network.</returns>
        [ProRequired]
        Task<IEnumerable<GasLimit>> GetDailyAverageGasLimit(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the total amount of gas used daily for transactions on the Chain network.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The total amount of gas used daily for transactions on Chain network.</returns>
        [ProRequired]
        Task<IEnumerable<GasUsed>> GetDailyGasUsed(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the daily average gas price used on the BNB Smart Chain network.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The daily average gas price used on the BNB Smart Chain network.</returns>
        [ProRequired]
        Task<IEnumerable<GasPrice>> GetDailyAverageGasPrice(DateTime startDate, DateTime endDate, string sort = "asc");

    }
}
