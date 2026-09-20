using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAiKeywordDataAiOptimizationLimitsRatesDataInfo 
    {
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LocationsAndLanguages { get; set; }
        [JsonProperty("keywords_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsSearchVolume { get; set; }
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableFilters { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}