using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleDomainIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// domain
        /// <br/>            required field
        /// <br/>            the domain name of the first target website
        /// <br/>            the domain should be specified without <c>https://</c> and <c>www.</c>
        /// </summary>
        [JsonProperty("target1", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target1 { get; set; }

        /// <summary>
        /// domain
        /// <br/>            required field
        /// <br/>            the domain name of the second target website
        /// <br/>            the domain should be specified without <c>https://</c> and <c>www.</c>
        /// </summary>
        [JsonProperty("target2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target2 { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>            required field if you don't specify <c>location_code</c>
        /// <br/>            Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>            you can receive the list of available locations with their <c>location_name</c> by making a separate request to the
        /// <br/>            <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>            example:
        /// <br/>            <c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>            required field if you don't specify <c>location_name</c>
        /// <br/>            Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>            you can receive the list of available locations with their <c>location_code</c> by making a separate request to the
        /// <br/>            <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>            example:
        /// <br/>            <c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>            required field if you don't specify <c>language_code</c>
        /// <br/>            Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>            you can receive the list of available languages with their <c>language_name</c> by making a separate request to the
        /// <br/>            <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>            example:
        /// <br/>            <c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>            required field if you don't specify <c>language_name</c>
        /// <br/>            Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>            you can receive the list of available languages with their <c>language_code</c> by making a separate request to the
        /// <br/>            <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>            example:
        /// <br/>            <c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// domain intersections in SERP
        /// <br/>            optional field
        /// <br/>            if you set intersections to <c>true</c>, you will get the keywords for which both target domains specified as <c>target1</c> and <c>target2</c> have results within the same SERP; the corresponding SERP elements for both domains will be provided in the results array
        /// <br/>            Note: this endpoint will not provide results if the number of intersecting keywords exceeds 10 million
        /// <br/>            if you specify <c>intersections: false</c>, you will get the keywords for which the domain specified as <c>target1</c> has results in SERP, and the domain specified as <c>target2</c> doesn't;
        /// <br/>            thus, the corresponding SERP elements and other data will be provided for the domain specified as <c>target1</c>only
        /// <br/>            default value: <c>true</c>
        /// </summary>
        [JsonProperty("intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intersections { get; set; }

        /// <summary>
        /// search results type
        /// <br/>            indicates type of search results included in the response
        /// <br/>            optional field
        /// <br/>            possible values:
        /// <br/>            <c>['organic', 'paid', 'featured_snippet', 'local_pack']</c>
        /// <br/>            default value:
        /// <br/>            <c>['organic', 'paid']</c>
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// include data from SERP for each keyword
        /// <br/>            optional field
        /// <br/>            if set to <c>true</c>, we will return a <c>serp_info</c> array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response
        /// <br/>            default value: <c>false</c>
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>            optional field
        /// <br/>            if the parameter is set to <c>true</c>, you will receive <c>clickstream_keyword_info</c>, <c>clickstream_etv</c>, <c>keyword_info_normalized_with_clickstream</c>, and <c>keyword_info_normalized_with_bing</c> fields in the response
        /// <br/>            default value: <c>false</c>
        /// <br/>            with this parameter enabled, you will be charged double the price for the request
        /// <br/>            learn more about how clickstream-based metrics are calculated in this <see href="https://dataforseo.com/help-center/what-are-clickstream-based-metrics-and-how-do-we-calculate-them">help center article</see>
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// the maximum number of returned keywords
        /// <br/>            optional field
        /// <br/>            default value: <c>100</c>
        /// <br/>            maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the <c>items</c> array of returned keywords
        /// <br/>            optional field
        /// <br/>            default value: <c>0</c>
        /// <br/>            if you specify the <c>10</c> value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>            optional field
        /// <br/>            you can add several filters at once (8 filters maximum)
        /// <br/>            you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>            the following operators are supported:
        /// <br/>            <c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>match</c>, <c>not_match</c>, <c>ilike</c>, <c>not_ilike</c>, <c>like</c>, <c>not_like</c>
        /// <br/>            you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c>, as well as <c>ilike</c> and <c>not_ilike</c> to match any string of zero or more characters
        /// <br/>            example:
        /// <br/>            <c>['keyword_data.keyword_info.search_volume','in',[100,1000]]</c>
        /// <br/>            <c>[['first_domain_serp_element.etv','&gt;',0],'and',['first_domain_serp_element.description','like','%goat%']]</c>
        /// <br/>            <c>[['keyword_data.keyword_info.search_volume','&gt;',100],                'and',                [['first_domain_serp_element.description','like','%goat%'],                'or',                ['second_domain_serp_element.type','=','organic']]]</c>
        /// <br/>            for more information about filters, please refer to <see href="/v3/dataforseo_labs/filters">Dataforseo Labs - Filters</see> or this <see href="https://dataforseo.com/help-center/how-to-use-filters-in-dataforseo-labs-api">help center guide</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>            optional field
        /// <br/>            you can use the same values as in the <c>filters</c> array to sort the results
        /// <br/>            possible sorting types:
        /// <br/>            <c>asc</c> - results will be sorted in the ascending order
        /// <br/>            <c>desc</c> - results will be sorted in the descending order
        /// <br/>            you should use a comma to set up a sorting parameter
        /// <br/>            example:
        /// <br/>            <c>['keyword_data.keyword_info.competition,desc']</c>
        /// <br/>            default rule:
        /// <br/>            <c>['keyword_data.keyword_info.search_volume,desc']</c>
        /// <br/>            note that you can set no more than three sorting rules in a single request
        /// <br/>            you should use a comma to separate several sorting rules
        /// <br/>            example:
        /// <br/>            <c>['keyword_data.keyword_info.search_volume,desc','keyword_data.keyword_info.cpc,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>            optional field
        /// <br/>            the character limit is 255
        /// <br/>            you can use this parameter to identify the task and match it with the result
        /// <br/>            you will find the specified <c>tag</c> value in the <c>data</c> object of the response
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