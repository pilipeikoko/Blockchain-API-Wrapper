using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Models;

namespace BlockchainScanner.Modules.Abstract
{
    public interface IBlockModuleService
    {
        Task<BlockReward> GetBlockRewardByBlock(int blockNumber);
        Task<BlockCountdown> GetEstimatedBlockCountdownByBlock(int blockNumber);
        Task<int> GetBlockNumberByTimestamp(DateTime time, string closest = "before");
        Task<int> GetBlockNumberByTimestamp(long unixTime,string closest = "before");
        //Pro Required
        Task<IEnumerable<DailyBlockSize>> GetDailyAverageBlockSize (DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro Required
        Task<IEnumerable<DailyBlockCountAndReward>> GetDailyBlockCountAndRewards(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro Required
        Task<IEnumerable<DailyBlockReward>> GetDailyBlockRewards(DateTime startDate, DateTime endDate, string sort = "asc");
        //Pro Required
        Task<IEnumerable<DailyAverageBlockTime>> GetDailyAverageTimeForBlock(DateTime startDate, DateTime endDate, string sort = "asc");
    }
}