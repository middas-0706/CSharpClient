using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAiOptimizationPriceData 
    {
        [JsonProperty("llm_scraper", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmScraperAiOptimizationPriceData LlmScraper { get; set; }
        [JsonProperty("llm_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmMentionsAiOptimizationPriceData LlmMentions { get; set; }
        [JsonProperty("ai_keyword_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAiKeywordDataAiOptimizationPriceData AiKeywordData { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }
        [JsonProperty("id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo IdList { get; set; }
        [JsonProperty("llm_responses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmResponsesAiOptimizationPriceData LlmResponses { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}