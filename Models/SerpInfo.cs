using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpInfo 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// types of search results in SERP
        /// <br/>contains types of search results (items) found in SERP
        /// <br/>possible item types:
        /// <br/><c>answer_box</c>, <c>app</c>, <c>carousel</c>, <c>multi_carousel</c>, <c>featured_snippet</c>, <c>google_flights</c>, <c>google_reviews</c>, <c>third_party_reviews</c>, <c>google_posts</c>, <c>images</c>, <c>jobs</c>, <c>knowledge_graph</c>, <c>local_pack</c>, <c>hotels_pack</c>, <c>map</c>, <c>organic</c>, <c>paid</c>, <c>people_also_ask</c>, <c>related_searches</c>, <c>people_also_search</c>, <c>shopping</c>, <c>top_stories</c>, <c>twitter</c>, <c>video</c>, <c>events</c>, <c>mention_carousel</c>, <c>recipes</c>, <c>top_sights</c>, <c>scholarly_articles</c>, <c>popular_products</c>, <c>podcasts</c>, <c>questions_and_answers</c>, <c>find_results_on</c>, <c>stocks_box</c>, <c>visual_stories</c>, <c>commercial_units</c>, <c>local_services</c>, <c>google_hotels</c>, <c>math_solver</c>, <c>currency_box</c>, <c>product_considerations</c>, <c>found_on_web</c>, <c>short_videos</c>, <c>refine_products</c>, <c>explore_brands</c>, <c>perspectives</c>, <c>discussions_and_forums</c>, <c>compare_sites</c>, <c>courses</c>, <c>ai_overview</c>;
        /// <br/>note that the actual results will be returned only for <c>organic</c>, <c>paid</c>, <c>featured_snippet</c>, and <c>local_pack</c> elements
        /// </summary>
        [JsonProperty("serp_item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SerpItemTypes { get; set; }

        /// <summary>
        /// number of search results for the returned keyword
        /// </summary>
        [JsonProperty("se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SeResultsCount { get; set; }

        /// <summary>
        /// date and time when keyword data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// previous to the most recent date and time when SERP data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-10-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("previous_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousUpdatedTime { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}