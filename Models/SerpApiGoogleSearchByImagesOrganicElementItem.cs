using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleSearchByImagesOrganicElementItem  : BaseSerpApiGoogleSearchByImagesElementItem 
    {

        /// <summary>
        /// domain in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }
        [JsonProperty("cache_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CacheUrl { get; set; }
        [JsonProperty("related_search_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedSearchUrl { get; set; }
        [JsonProperty("breadcrumb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// name of the website in SERP
        /// </summary>
        [JsonProperty("website_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebsiteName { get; set; }
        [JsonProperty("is_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImage { get; set; }
        [JsonProperty("is_video", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVideo { get; set; }
        [JsonProperty("is_featured_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFeaturedSnippet { get; set; }
        [JsonProperty("is_malicious", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMalicious { get; set; }
        [JsonProperty("is_web_story", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWebStory { get; set; }
        [JsonProperty("checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Checks { get; set; }
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("pre_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PreSnippet { get; set; }
        [JsonProperty("extended_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendedSnippet { get; set; }
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeImagesElementInfo> Images { get; set; }
        [JsonProperty("amp_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AmpVersion { get; set; }
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LinkElement> Links { get; set; }
        [Obsolete]
        [JsonProperty("faq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FaqBox Faq { get; set; }
        [JsonProperty("extended_people_also_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExtendedPeopleAlsoSearch { get; set; }
        [Obsolete]
        [JsonProperty("about_this_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AboutThisResultElement AboutThisResult { get; set; }
        [JsonProperty("related_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<RelatedResult> RelatedResult { get; set; }
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}