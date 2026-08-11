using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGooglePageIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// target URLs of pages
        /// <br/>required field
        /// <br/>you can set up to 20 pages in this object
        /// <br/>the pages should be specified with absolute URLs (including http:// or https://)
        /// <br/>example:
        /// <br/>`'pages': {`
        /// <br/>`'1':'https://www.apple.com/mac/*',`
        /// <br/>`'2':'https://dataforseo.com/*',`
        /// <br/>`'3':'https://support.microsoft.com/'`
        /// <br/>`}`if you specify a single page here, we will return results only for this page;
        /// <br/>you can also use a wildcard ('*') character to specify the search pattern
        /// <br/>example:
        /// <br/><c>'example.com'</c>
        /// <br/>search for the exact URL
        /// <br/><c>'example.com/eng/*'</c>
        /// <br/>search for the example.com page and all its related URLs which start with '/eng/', such as 'example.com/eng/index.html' and 'example.com/eng/help/', etc.
        /// <br/>note: a wilcard should be placed after the slash ('/') character in the end of the URL, it is not possible to place it after the domain in the following way:
        /// <br/>`https://dataforseo.com`*
        /// <br/>use `https://dataforseo.com`/* instead
        /// <br/>Note: this endpoint will not provide results if the number of intersecting keywords exceeds 10 million
        /// </summary>
        [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Pages { get; set; }

        /// <summary>
        /// URLs of pages you want to exclude
        /// <br/>optional field
        /// <br/>you can set up to 10 pages in this array
        /// <br/>if you use this array, results will contain the keywords for which URLs from the <c>pages</c> object rank, but URLs from <c>exclude_pages</c> array do not;
        /// <br/>note that if you specify this field, the results will be based on the keywords any URL from <c>pages</c> ranks for regardless of intersections between them. However, you can set <c>intersection_mode</c> to <c>intersect</c> and results will contain the keywords all URLs from <c>pages</c> rank for in the same SERP and URLs from <c>exclude_pages</c> do not. 
        /// <br/>use a wildcard ('&amp;ast;') character to specify the search pattern
        /// <br/>example:
        /// <br/>`'exclude_pages':`
        /// <br/>`['https://www.apple.com/iphone/&amp;ast;',`
        /// <br/>`'https://dataforseo.com/apis/&amp;ast;',`
        /// <br/>`'https://www.microsoft.com/en-us/industry/services/']`
        /// </summary>
        [JsonProperty("exclude_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExcludePages { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don't specify <c>location_name</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search results type
        /// <br/>indicates type of search results included in the response
        /// <br/>optional field
        /// <br/>possible values: 
        /// <br/><c>['organic', 'paid', 'featured_snippet', 'local_pack']</c>
        /// <br/>default value: 
        /// <br/><c>['organic', 'paid']</c>
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// the maximum number of returned keywords
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the <c>items</c> array of returned keywords
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify <c>10</c> here, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// indicates if the subdomains will be included in the search
        /// <br/>optional field
        /// <br/>if set to <c>false</c>, the subdomains will be ignored
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates whether to intersect keywords
        /// <br/>optional field
        /// <br/>use this field to intersect or merge results for the specified URLs
        /// <br/>possible values: <c>union</c>, <c>intersect</c>
        /// <br/><c>union</c> - results are based on all keywords any URL from <c>pages</c> rank for;
        /// <br/><c>intersect</c> - results are based on the keywords all URLs from <c>pages</c> rank for in the same SERP:
        /// <br/>by default, results are based on the <c>intersect</c> mode if you specify only <c>pages</c> array. If you specify <c>exclude_pages</c> as well, results are based on the <c>union</c> mode
        /// </summary>
        [JsonProperty("intersection_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionMode { get; set; }

        /// <summary>
        /// include data from SERP for each keyword
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, we will return a <c>serp_info</c> array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>optional field
        /// <br/>if the parameter is set to <c>true</c>, you will receive <c>clickstream_keyword_info</c>, <c>clickstream_etv</c>, <c>keyword_info_normalized_with_clickstream</c>, and <c>keyword_info_normalized_with_bing</c> fields in the response
        /// <br/>default value: <c>false</c>
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>learn more about how clickstream-based metrics are calculated in this <see href="https://dataforseo.com/help-center/what-are-clickstream-based-metrics-and-how-do-we-calculate-them">help center article</see>
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to <c>true</c> only core keywords will be returned, all highly similar keywords will be excluded;  
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>ilike</c>, <c>not_ilike</c>, <c>like</c>, <c>not_like</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c>, as well as <c>ilike</c> and <c>not_ilike</c> to match any string of zero or more characters
        /// <br/>note that if you want to filter by any field in the <c>intersection_result</c> array you need to specify the number of corresponding page
        /// <br/>for instance, if you want to filter results by the ranking of the first specified URL, you should set the following filter:
        /// <br/><c>[intersection_result.1.rank_absolute,'=',1]</c>
        /// <br/>if you want to filter results and receive only organic listings for the third specified URL, you should set the following filter:
        /// <br/><c>[intersection_result.3.type,'=','organic']</c> , etc.example:
        /// <br/><c>['keyword_data.keyword_info.search_volume','in',[100,1000]]</c>
        /// <br/><c>[['intersection_result.1.etv','&gt;',0],'and',['intersection_result.1.description','like','%goat%']]</c><c>[['keyword_data.keyword_info.search_volume','&gt;',100],'and',[['intersection_result.2.description','like','%goat%'],'or',['intersection_result.2.type','=','organic']]]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/dataforseo_labs/filters">Dataforseo Labs - Filters</see> or this <see href="https://dataforseo.com/help-center/how-to-use-filters-in-dataforseo-labs-api">help center guide</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting parameter
        /// <br/>example:
        /// <br/><c>['keyword_data.keyword_info.competition,desc']</c>
        /// <br/>default rule:
        /// <br/><c>['keyword_data.keyword_info.search_volume,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['intersection_result.1.rank_group,asc','intersection_result.2.rank_absolute,asc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

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