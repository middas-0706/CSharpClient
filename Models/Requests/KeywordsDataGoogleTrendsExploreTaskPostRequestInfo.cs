using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataGoogleTrendsExploreTaskPostRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>the maximum number of keywords you can specify: 5
        /// <br/>the maximum number of characters you can specify in a keyword: 100
        /// <br/>the minimum number of characters must be greater than 1
        /// <br/>comma characters (<c>,</c>) in the specified keywords will be unset and ignored
        /// <br/>Note: keywords cannot consist of a combination of the following characters: <c>|  ' - + = ~ ! : * ( ) [ ] { }</c>
        /// <br/>Note: to obtain <c>google_trends_topics_list</c> and <c>google_trends_queries_list</c> items, specify no more than 1 keyword
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>optional field
        /// <br/>if you don't use this field, you will recieve global results
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>
        /// <br/>you can use this field as an array to set several locations, each corresponding to a specific keyword - <see href="https://dataforseo.com/help-center/multiple-locations-in-google-trends-api">learn more</see>;
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_trends/locations</c>
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>optional field
        /// <br/>if you don't use this field, you will recieve global results
        /// <br/>if you use this field, you don't need to specify <c>location_name</c>
        /// <br/>you can use this field as an array to set several locations, each corresponding to a specific keyword - <see href="https://dataforseo.com/help-center/multiple-locations-in-google-trends-api">learn more</see>;
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_trends/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCode { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>default value: <c>English</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_trends/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>default value: <c>en</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_trends/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// google trends search category
        /// <br/>optional field
        /// <br/>if you don't specify this field, the <c>0</c> value will be applied by default and the search will be carried out across all available categories
        /// <br/>you can receive the list of available categories with their <c>category_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/keywords_data/google_trends/categories</c>
        /// </summary>
        [JsonProperty("category_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>if you don't specify this field, the current day and month of the preceding year will be used by default
        /// <br/>minimal value for the <c>web</c> type: <c>2004-01-01</c>
        /// <br/>minimal value for other types: <c>2008-01-01</c>
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2019-01-15'</c>
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don't specify this field, the today's date will be used by default
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2019-01-15'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// preset time ranges
        /// <br/>optional field
        /// <br/>if you specify <c>date_from</c> or <c>date_to</c> parameters, this field will be ignored when setting a task
        /// <br/>possible values for all <c>type</c> parameters:
        /// <br/><c>past_hour</c>, <c>past_4_hours</c>, <c>past_day</c>, <c>past_7_days</c>, <c>past_30_days</c>, <c>past_90_days</c>, <c>past_12_months</c>, <c>past_5_years</c>
        /// <br/>possible values for <c>web</c> only:
        /// <br/><c>2004_present</c>
        /// <br/>possible values for <c>news</c>, <c>youtube</c>, <c>images</c>, <c>froogle</c>:
        /// <br/><c>2008_present</c>
        /// </summary>
        [JsonProperty("time_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeRange { get; set; }

        /// <summary>
        /// types of items returned
        /// <br/>optional field
        /// <br/>to speed up the execution of the request, specify one item at a time;
        /// <br/>possible values:
        /// <br/><c>'google_trends_graph'</c>, <c>'google_trends_map'</c>, <c>'google_trends_topics_list'</c>,<c>'google_trends_queries_list'</c>
        /// <br/>default value:
        /// <br/><c>'google_trends_graph'</c>
        /// <br/>Note: to obtain <c>google_trends_topics_list</c> and <c>google_trends_queries_list</c> items, specify no more than 1 keyword in the <c>keywords</c> field
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the <c>gzip</c> format to the <c>postback_url</c> you specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/><c>http://your-server.com/postbackscript?id=$id</c>
        /// <br/><c>http://your-server.com/postbackscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special characters in <c>postback_url</c> will be urlencoded;
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("postback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request
        /// <br/>example:
        /// <br/><c>http://your-server.com/pingscript?id=$id</c>
        /// <br/><c>http://your-server.com/pingscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special characters in <c>pingback_url</c> will be urlencoded;
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("pingback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}