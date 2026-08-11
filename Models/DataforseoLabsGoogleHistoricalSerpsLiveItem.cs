using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleHistoricalSerpsLiveItem 
    {

        /// <summary>
        /// search engine type in a POST array
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// keyword received in a POST array
        /// <br/>            the keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character)
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// search engine domain in a POST array
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>            you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the result was received
        /// <br/>            in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>            example:
        /// <br/>            <c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// autocorrection of the search engine
        /// <br/>            if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection
        /// </summary>
        [JsonProperty("spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SpellInfo Spell { get; set; }

        /// <summary>
        /// types of search results in SERP
        /// <br/>            contains types of search results (<c>items</c>) found in SERP.
        /// <br/>            possible item types:
        /// <br/>            <see href="#answer_box">answer_box</see>, <see href="#carousel">carousel</see>, <see href="#multi_carousel">multi_carousel</see>, <see href="#featured_snippet">featured_snippet</see>, <see href="#google_flights">google_flights</see>, <see href="#google_reviews">google_reviews</see>, <see href="#google_posts">google_posts</see>, <see href="#images">images</see>, <see href="#jobs">jobs</see>, <see href="#knowledge_graph">knowledge_graph</see>, <see href="#local_pack">local_pack</see>, <see href="#hotels_pack">hotels_pack</see>, <see href="#map">map</see>, <see href="#organic">organic</see>, <see href="#paid">paid</see>, <see href="#people_also_ask">people_also_ask</see>, <see href="#related_searches">related_searches</see>, <see href="#people_also_search">people_also_search</see>, <see href="#shopping">shopping</see>, <see href="#top_stories">top_stories</see>, <see href="#twitter">twitter</see>, <see href="#video">video</see>, <see href="#events">events</see>, <see href="#mention_carousel">mention_carousel</see>, <see href="#recipes">recipes</see>, <see href="#top_sights">top_sights</see>, <see href="#scholarly_articles">scholarly_articles</see>, <see href="#popular_products">popular_products</see>, <see href="#podcasts">podcasts</see>, <see href="#questions_and_answers">questions_and_answers</see>, <see href="#find_results_on">find_results_on</see>, <see href="#stocks_box">stocks_box</see>, <see href="#visual_stories">visual_stories</see>, <see href="#commercial_units">commercial_units</see>,  <see href="#local_services">local_services</see>, <see href="#google_hotels">google_hotels</see>, <see href="#math_solver">math_solver</see>, <see href="#ai_overview">ai_overview</see>
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// total number of results in SERP
        /// </summary>
        [JsonProperty("se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SeResultsCount { get; set; }

        /// <summary>
        /// the number of results returned in the <c>items</c> array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// historical SERPs and related data found in the database
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseDataforseoLabsApiElementItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}