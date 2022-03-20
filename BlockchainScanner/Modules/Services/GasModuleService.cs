using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlockchainScanner.Chain.Configs;
using BlockchainScanner.Dtos.Responses;
using BlockchainScanner.Models;
using BlockchainScanner.Modules.Abstract;

namespace BlockchainScanner.Modules.Services
{
    public class GasModuleService : ModuleService, IGasModuleService
    {
        public GasModuleService(BlockchainConfig blockchainConfig) : base(blockchainConfig)
        {
        }

        public async Task<GasOracle> GetGasOracle()
        {
            var url = $"{BlockchainConfig.ApiUrl}?module=gastracker&action=gasoracle&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<GasOracleResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<GasLimit>> GetDailyAverageGasLimit(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailyavggaslimit&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<GasLimitResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<GasUsed>> GetDailyGasUsed(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailygasused&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<GasUsedResponse>(url).ConfigureAwait(false);

            return response.Result;
        }

        public async Task<IEnumerable<GasPrice>> GetDailyAverageGasPrice(DateTime startDate, DateTime endDate, string sort = "asc")
        {
            var url =
                $"{BlockchainConfig.ApiUrl}?module=stats&action=dailyavggasprice&startdate={startDate:yyyyMMdd}&enddate={endDate:yyyyMMdd}&sort={sort}&apikey={BlockchainConfig.ApiKey}";

            var response = await Get<GasPriceResponse>(url).ConfigureAwait(false);

            return response.Result;
        }
    }
}
