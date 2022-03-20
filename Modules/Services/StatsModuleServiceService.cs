using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Dtos.Responses;
using BlockchainScanner.Models;
using BlockchainScanner.Modules.Abstract;

namespace BlockchainScanner.Modules.Services
{
    public class StatsModuleService : ModuleService, IStatsModule
    {
        public StatsModuleService(BlockchainConfig blockchainConfig) : base(blockchainConfig)
        {
        }

        public async Task<double> GetMainTokenTotalSupply()
        {
            var url = $"{BlockchainConfig.ApiUrl}?module=stats&action=bnbsupply&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<MainTokenBalanceResponse>(url).ConfigureAwait(false);

            return double.Parse(response.Result);
        }

        public async Task<IEnumerable<Validator>> GetValidatorsList()
        {
            var url = $"{BlockchainConfig.ApiUrl}?module=stats&action=validators&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<ValidatorResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<MainTokenPrice> GetMainTokenLastPrice()
        {
            var url = $"{BlockchainConfig.ApiUrl}?module=stats&action=bnbprice&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<TokenPriceResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyPriceItem>> GetMainTokenHistoricalPrice(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=bnbdailyprice&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyPriceItemResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyTransactionFee>> GetDailyTransactionFee(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailytxnfee&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyTransactionFeeResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyNewAddressCount>> GetDailyNewAddressCount(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailynewaddress&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyNewAddressCountResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyNetworkUtilization>> GetDailyNetworkUtilization(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailynetutilization&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyNetworkUtilizationResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<DailyTransactionCount>> GetDailyTransactionCount(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailytx&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<DailyTransactionCountResponse>(url).ConfigureAwait(false);

            return response.Result;
        }
    }
}
