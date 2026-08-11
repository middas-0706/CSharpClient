using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 1000
        /// <br/>The maximum number of characters for each keyword: 80
        /// <br/>The maximum number of words for each keyword phrase: 10
        /// <br/>the keywords you specify will be converted to a lowercase format
        /// <br/>Note #1: <see href="https://dataforseo.com/help-center/no-search-volume-data-for-some-keywords">Google Ads may return no data for certain groups of keywords</see>;
        /// <br/>Note #2: <see href="https://dataforseo.com/help-center/sv-broad-exact-phrase-match">Google Ads provides combined search volume values for groups of similar keywords</see>
        /// <br/>to obtain search volume for similar keywords, we recommend submitting such keywords in separate requests;
        /// <br/>Note #3: Google Ads doesn't allow using certain symbols and characters (e.g., UTF symbols, emojis), so you can't use them when setting a task;
        /// <br/>to learn more about which symbols and characters can be used, please refer to <see href="https://dataforseo.com/help-center/using-symbols-in-keywords-when-setting-a-google-ads-task">this article</see>
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// the maximum custom bid
        /// <br/>required field
        /// <br/>the collected data will be based on this value
        /// <br/>it stands for the price you are willing to pay for an ad; the higher value you specify here, the higher values you will get in the returned metrics
        /// <br/>learn more in <see href="https://dataforseo.com/help-center/configuring-bid">this help center article</see>
        /// </summary>
        [JsonProperty("bid", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? Bid { get; set; }

        /// <summary>
        /// keywords match-type
        /// <br/>required field
        /// <br/>can take the following values: <c>exact</c>, <c>broad</c>, <c>phrase</c>
        /// </summary>
        [JsonProperty("match", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_ads/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>;
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_ads/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>;
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude' format;
        /// <br/>the data will be provided for the country the specified coordinates belong to;
        /// <br/>example:
        /// <br/><c>52.6178549,-155.352142</c>
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_ads/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/google_ads/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// starting date of the forecasting time range
        /// <br/>required field if you specify <c>date_to</c>
        /// <br/>if you indicate <c>date_from</c> and <c>date_to</c>, you don't need to specify <c>date_interval</c>
        /// <br/>minimum value is tomorrow's date
        /// <br/>the value you specify in <c>date_from</c> shouldn't be further than <c>date_to</c>
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2021-10-30'</c>if <see href="/v3/keywords_data/google_ads/status/">Status endpoint</see> returns <c>false</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the month before last and prior;
        /// <br/>if <see href="/v3/keywords_data/google_ads/status/">Status endpoint</see> returns <c>true</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the last month and prior
        /// </summary>
        [JsonProperty("date_from", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the forecasting time range
        /// <br/>required field if you specify <c>date_from</c>
        /// <br/>if you indicate <c>date_from</c> and <c>date_to</c>, you don't need to specify <c>date_interval</c>
        /// <br/>minimum value is <c>date_from</c> +1 day
        /// <br/>maximum value is current day and month of the next year
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2022-10-30'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// forecasting date interval
        /// <br/>optional field
        /// <br/>if you specify <c>date_interval</c>, you don't need to indicate <c>date_from</c> and <c>date_to</c>
        /// <br/>possible values: <c>next_week</c>, <c>next_month</c>, <c>next_quarter</c>
        /// <br/>default value: <c>next_month</c>
        /// </summary>
        [JsonProperty("date_interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateInterval { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>Use these parameters to sort the results by <c>relevance</c>, <c>average_cpc</c>, <c>cost</c>, or <c>clicks</c> in the descending order
        /// <br/>default value: <c>relevance</c>
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

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
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
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