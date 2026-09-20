using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixLlmMentionsAiOptimizationLimitsRatesDataInfo 
    {
        [JsonProperty("search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Search { get; set; }
        [JsonProperty("aggregated_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo AggregatedMetrics { get; set; }
        [JsonProperty("cross_aggregated_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo CrossAggregatedMetrics { get; set; }
        [JsonProperty("top_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopDomains { get; set; }
        [JsonProperty("top_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopPages { get; set; }
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LocationsAndLanguages { get; set; }
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableFilters { get; set; }
        [JsonProperty("search_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SearchMentions { get; set; }
        [JsonProperty("target_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TargetMetrics { get; set; }
        [JsonProperty("multi_target_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo MultiTargetMetrics { get; set; }
        [JsonProperty("top_mentioned_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedDomains { get; set; }
        [JsonProperty("top_mentioned_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedPages { get; set; }
        [JsonProperty("top_mentioned_brands", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedBrands { get; set; }
        [JsonProperty("top_mentioned_brand_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedBrandCategories { get; set; }
        [JsonProperty("target_metrics_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TargetMetricsLite { get; set; }
        [JsonProperty("top_mentioned_domains_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedDomainsLite { get; set; }
        [JsonProperty("top_mentioned_pages_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedPagesLite { get; set; }
        [JsonProperty("top_mentioned_brands_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedBrandsLite { get; set; }
        [JsonProperty("top_mentioned_brand_categories_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopMentionedBrandCategoriesLite { get; set; }
        [JsonProperty("historical", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Historical { get; set; }
        [JsonProperty("timeseries_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TimeseriesDelta { get; set; }
        [JsonProperty("timeseries_new_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TimeseriesNewLost { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}