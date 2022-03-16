﻿using BscScanner.Data;
using BscScanner.Dtos;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlockchainAnalysis.Modules
{
    public abstract class ModuleService : IDisposable
    {
        private readonly HttpClient _client = new();

        private readonly JsonSerializerSettings _serializerSettings = new()
        {
            Error = (_, ev) => ev.ErrorContext.Handled = true
        };

        protected virtual BlockchainConfig BlockchainConfig { get; }

        protected async Task<T> Get<T>(string url)
        {
            var json = await _client.GetStringAsync(url);
            var obj = JsonConvert.DeserializeObject<T>(json, _serializerSettings);

            if (obj is Response result && result.Status == "0")
            {
                switch (result.Message)
                {
                    case "NOTOK":
                        var error = new BscError();
                        JsonConvert.PopulateObject(json, error);
                        switch (error.ErrorMessage)
                        {
                            case "Max rate limit reached":
                                throw new HttpRequestException(error.ErrorMessage, null, HttpStatusCode.TooManyRequests);
                            case "Error! Block number already pass":
                                //throw new HttpRequestException(error.ErrorMessage,null,HttpStatusCode.BadRequest);
                                break; //Ignore to keep same result
                            default:
                                throw new HttpRequestException(error.ErrorMessage, null, HttpStatusCode.BadRequest);
                        }
                        break;
                    case "No transactions found":
                        //throw new HttpRequestException(result.Message, null, HttpStatusCode.NoContent);
                        break; //Ignore to keep same result
                    default:
                        throw new HttpRequestException(result.Message);
                }
            }

            return obj;
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
