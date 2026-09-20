using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsAvailableFiltersResultInfo 
    {
        [JsonProperty("search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Search { get; set; }
        [JsonProperty("search_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> SearchMentions { get; set; }
        [JsonProperty("target_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TargetMetrics { get; set; }
        [JsonProperty("multi_target_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> MultiTargetMetrics { get; set; }
        [JsonProperty("top_mentioned_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedDomains { get; set; }
        [JsonProperty("top_mentioned_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedPages { get; set; }
        [JsonProperty("top_mentioned_brands", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedBrands { get; set; }
        [JsonProperty("top_mentioned_brand_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedBrandCategories { get; set; }
        [JsonProperty("target_metrics_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TargetMetricsLite { get; set; }
        [JsonProperty("top_mentioned_domains_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedDomainsLite { get; set; }
        [JsonProperty("top_mentioned_pages_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedPagesLite { get; set; }
        [JsonProperty("top_mentioned_brands_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedBrandsLite { get; set; }
        [JsonProperty("top_mentioned_brand_categories_lite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> TopMentionedBrandCategoriesLite { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}