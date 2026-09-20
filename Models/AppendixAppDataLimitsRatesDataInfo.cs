using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAppDataLimitsRatesDataInfo 
    {
        [JsonProperty("app_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpDaysRatesDataInfo AppInfo { get; set; }
        [JsonProperty("app_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpDaysRatesDataInfo AppList { get; set; }
        [JsonProperty("app_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpDaysRatesDataInfo AppReviews { get; set; }
        [JsonProperty("app_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpDaysRatesDataInfo AppSearches { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Locations { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Categories { get; set; }
        [JsonProperty("id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IdList { get; set; }
        [JsonProperty("app_listings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTrBusinessDataDayLimitsRatesDataInfo AppListings { get; set; }
        [JsonProperty("pp_listings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDataforseoLabsLimitsRatesDataInfo PpListings { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}