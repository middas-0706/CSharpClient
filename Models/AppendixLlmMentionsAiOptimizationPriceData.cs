using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixLlmMentionsAiOptimizationPriceData 
    {
        [JsonProperty("aggregated_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo AggregatedMetrics { get; set; }
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo AvailableFilters { get; set; }
        [JsonProperty("cross_aggregated_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo CrossAggregatedMetrics { get; set; }
        [JsonProperty("historical", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Historical { get; set; }
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo LocationsAndLanguages { get; set; }
        [JsonProperty("multi_target_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo MultiTargetMetrics { get; set; }
        [JsonProperty("search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Search { get; set; }
        [JsonProperty("search_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo SearchMentions { get; set; }
        [JsonProperty("target_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TargetMetrics { get; set; }
        [JsonProperty("target_metrics_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TargetMetricsLite { get; set; }
        [JsonProperty("timeseries_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TimeseriesDelta { get; set; }
        [JsonProperty("timeseries_new_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TimeseriesNewLost { get; set; }
        [JsonProperty("top_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopDomains { get; set; }
        [JsonProperty("top_mentioned_brand_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedBrandCategories { get; set; }
        [JsonProperty("top_mentioned_brand_categories_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedBrandCategoriesLite { get; set; }
        [JsonProperty("top_mentioned_brands", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedBrands { get; set; }
        [JsonProperty("top_mentioned_brands_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedBrandsLite { get; set; }
        [JsonProperty("top_mentioned_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedDomains { get; set; }
        [JsonProperty("top_mentioned_domains_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedDomainsLite { get; set; }
        [JsonProperty("top_mentioned_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedPages { get; set; }
        [JsonProperty("top_mentioned_pages_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopMentionedPagesLite { get; set; }
        [JsonProperty("top_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopPages { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}