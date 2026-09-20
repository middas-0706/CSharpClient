using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAiKeywordDataAiOptimizationPriceData 
    {
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo AvailableFilters { get; set; }
        [JsonProperty("keywords_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordsSearchVolume { get; set; }
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo LocationsAndLanguages { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}