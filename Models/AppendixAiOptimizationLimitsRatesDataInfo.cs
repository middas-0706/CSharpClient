using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAiOptimizationLimitsRatesDataInfo 
    {
        [JsonProperty("llm_responses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmResponsesAiOptimizationLimitsRatesDataInfo LlmResponses { get; set; }
        [JsonProperty("ai_keyword_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAiKeywordDataAiOptimizationLimitsRatesDataInfo AiKeywordData { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("llm_scraper", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpDaysRatesDataInfo LlmScraper { get; set; }
        [JsonProperty("llm_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmMentionsAiOptimizationLimitsRatesDataInfo LlmMentions { get; set; }
        [JsonProperty("id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IdList { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}