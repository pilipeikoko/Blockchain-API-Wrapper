using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;
using BlockchainScanner.Utils;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IBlockModuleService
    {
        /// <summary>
        /// Returns the block reward awarded for validating a certain block.
        /// Tip : The timestamp field is denoted in Unix timestamp.
        /// </summary>
        /// <param name="blockNumber">The integer block number to check block rewards for eg. 12697906</param>
        /// <returns>Block reward awarded for validating a certain block.</returns>
        Task<BlockReward> GetBlockRewardByBlock(int blockNumber);

        /// <summary>
        /// Returns the estimated time remaining, in seconds, until a certain block is validated.
        /// Tip : The timestamp field is denoted in Unix timestamp.
        /// </summary>
        /// <param name="blockNumber">The integer block number to estimate time remaining to be validated eg. 12697906</param>
        /// <returns>The estimated time remaining, in seconds, until a certain block is validated.</returns>
        Task<BlockCountdown> GetEstimatedBlockCountdownByBlock(int blockNumber);

        /// <summary>
        /// Returns the block number that was validated at a certain timestamp.
        /// Tip : Convert a regular date-time to a Unix timestamp.
        /// </summary>
        /// <param name="time">The DateTime representing date and time.</param>
        /// <param name="closest">The closest available block to the provided timestamp, either before or after</param>
        /// <returns>Block number that was validated at a certain timestamp.</returns>
        Task<int> GetBlockNumberByTimestamp(DateTime time, string closest = "before");

        /// <summary>
        /// Returns the block number that was validated at a certain timestamp.
        /// Tip : Convert a regular date-time to a Unix timestamp.
        /// </summary>
        /// <param name="unixTime">The integer representing the Unix timestamp in seconds.</param>
        /// <param name="closest">The closest available block to the provided timestamp, either before or after</param>
        /// <returns>Block number that was validated at a certain timestamp.</returns>
        Task<int> GetBlockNumberByTimestamp(long unixTime,string closest = "before");

        /// <summary>
        /// Pro required.
        /// Returns the daily average block size within a date range.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing.</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The daily average block size within a date range.</returns>
        [ProRequired]
        Task<IEnumerable<DailyBlockSize>> GetDailyAverageBlockSize (DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the number of blocks validated daily and the amount of block rewards.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>Number of blocks validated daily and the amount of block rewards.</returns>
        [ProRequired]
        Task<IEnumerable<DailyBlockCountAndReward>> GetDailyBlockCountAndRewards(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the amount of block rewards distributed to validators daily.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The amount of block rewards distributed to validators daily.</returns>
        [ProRequired]
        Task<IEnumerable<DailyBlockReward>> GetDailyBlockRewards(DateTime startDate, DateTime endDate, string sort = "asc");

        /// <summary>
        /// Pro required.
        /// Returns the daily average of time needed for a block to be successfully validated.
        /// </summary>
        /// <param name="startDate">The starting date in DateTime representing</param>
        /// <param name="endDate">The ending date in DateTime representing</param>
        /// <param name="sort">The sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <returns>The daily average of time needed for a block to be successfully validated.</returns>
        [ProRequired]
        Task<IEnumerable<DailyAverageBlockTime>> GetDailyAverageTimeForBlock(DateTime startDate, DateTime endDate, string sort = "asc");
    }
}