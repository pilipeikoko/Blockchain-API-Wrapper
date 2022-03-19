using Newtonsoft.Json;

namespace BlockchainAnalysis.Models
{
    public class Validator
    {
        [JsonProperty("validatorAddress")] 
        public string ValidatorAddress { get; set; }

        [JsonProperty("validatorName")]
        public string ValidatorName { get; set; }

        [JsonProperty("validatorStatus")] 
        public string ValidatorStatus { get; set; }

        [JsonProperty("validatorVotingPower")]
        public string ValidatorVotingPower { get; set; }

        [JsonProperty("validatorVotingPowerProportion")]
        public string ValidatorVotingPowerProportion { get; set; }
    }
}