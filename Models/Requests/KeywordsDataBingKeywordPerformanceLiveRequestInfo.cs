using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataBingKeywordPerformanceLiveRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 1000
        /// <br/>The maximum number of characters for each keyword: 80
        /// <br/>The maximum number of words for each keyword phrase: 10
        /// <br/>the specified keywords will be converted to lowercase, data will be provided in a separate array
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>specify this field if you want to get the data for a particular device typepossible values: <c>desktop</c>, <c>mobile</c>, <c>tablet</c>, <c>all</c>
        /// <br/>default value: <c>all</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// keywords match type
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/><c>aggregate</c> returns data across all match types;
        /// <br/><c>broad</c> returns data for all user queries containing the specified keyword with varying word order;
        /// <br/><c>phrase</c> returns data for all user queries containing the specified keyword with identical word order;
        /// <br/><c>exact</c> returns data for user query that matches the specified keyword;Note: the <c>aggregate</c> match type is applied by default
        /// </summary>
        [JsonProperty("match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations and languages by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>'United States'</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations and languages by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude' format
        /// <br/>the data will be provided for the country the specified coordinates belong to
        /// <br/>example:
        /// <br/><c>52.6178549,-155.352142</c>
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available locations and languages by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>you can receive the list of available locations and languages by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>'en'</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

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