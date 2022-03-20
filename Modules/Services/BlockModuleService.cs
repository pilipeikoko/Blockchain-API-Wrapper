using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Dtos.Responses;
using BlockchainScanner.Models;
using BlockchainScanner.Modules.Abstract;

namespace BlockchainScanner.Modules.Services
{
    public class BlockModuleService : ModuleService, IBlockModuleService
    {
        public BlockModuleService(BlockchainConfig blockchainConfig) : base(blockchainConfig)
        {
        }

        public async Task<BlockReward> GetBlockRewardByBlock(int blockNumber)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=block&action=getblockreward&blockno={blockNumber}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<BlockRewardResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<BlockCountdown> GetEstimatedBlockCountdownByBlock(int blockNumber)
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=block&action=getblockcountdown&blockno={blockNumber}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<BlockCountdownResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<int> GetBlockNumberByTimestamp(DateTime time, string closest = "before")
        {
            var unixTime = ((DateTimeOffset) time).ToUnixTimeSeconds();

            return await GetBlockNumberByTimestamp(unixTime, closest);
        }

        public async Task<int> GetBlockNumberByTimestamp(long unixTime, string closest = "before")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=block&action=getblocknobytime&timestamp={unixTime}&closest={closest}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<BlockByTimeResponse>(url).ConfigureAwait(false);

            return int.Parse(response.Result);
        }

        public async Task<IEnumerable<DailyBlockSize>> GetDailyAverageBlockSize(DateTime startDate, DateTime endDate,
            string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailyavgblocksize&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyBlockSizeResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyBlockCountAndReward>> GetDailyBlockCountAndRewards(DateTime startDate,
            DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailyblkcount&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyBlockCountAndRewardResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyBlockReward>> GetDailyBlockRewards(DateTime startDate, DateTime endDate,
            string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailyblockrewards&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyBlockRewardResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyAverageBlockTime>> GetDailyAverageTimeForBlock(DateTime startDate,
            DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailyavgblocktime&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyAverageBlockTimeResponse>(url).ConfigureAwait(false);

            return response.Result;
        }
    }
}