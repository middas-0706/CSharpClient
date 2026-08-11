using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataBingSearchVolumeHistoryLiveRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 1000
        /// <br/>The maximum number of characters for each keyword: 100
        /// <br/>the specified keywords will be converted to lowercase, data will be provided in a separate arraylearn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages</c>
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
        /// <br/>you can receive the list of available languages of the search engines with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engines with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// device types
        /// <br/>optional field
        /// <br/>specify this field if you want to get the data for a particular device types
        /// <br/>possible values: <c>mobile</c>, <c>desktop</c>, <c>tablet</c>, <c>non_smartphones</c>
        /// <br/>default value: <c>['mobile', 'desktop', 'tablet', 'non_smartphones']</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Device { get; set; }

        /// <summary>
        /// aggregates the returned data to a certain time period
        /// <br/>optional field
        /// <br/>specify this field if you want to get the data in monthly, weekly or daily formatpossible values: <c>monthly</c>, <c>weekly</c>, <c>daily</c>
        /// <br/><c>monthly</c> - returns data up to past 24 months
        /// <br/><c>weekly</c> - returns data up to past 15 weeks
        /// <br/><c>daily</c> - returns data up to past 45 days
        /// <br/>default value: <c>monthly</c>
        /// </summary>
        [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>minimum value: 24 months back from today’s date;
        /// <br/>if <see href="/v3/keywords_data/bing/status/">Status endpoint</see> returns <c>false</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the month before last and prior;
        /// <br/>if <see href="/v3/keywords_data/bing/status/">Status endpoint</see> returns <c>true</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the last month and prior;
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2020-01-01'</c>Note: we do not recommend using a custom time range;
        /// <br/>Note 2: if <c>date_from</c> and <c>date_to</c> parameters are not specified, the data will be returned for the past 24 months;
        /// <br/>if you specify the <c>period</c> parameter:
        /// <br/>with value <c>weekly</c>, you will get results for the past 15 weeks;
        /// <br/>with value <c>daily</c>, you will get results for the past 45 days
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional fieldminimum value: two years back from today’s date;
        /// <br/>maximum value: one day from today's date;
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2020-03-15'</c>
        /// <br/>Note: we do not recommend using a custom time range
        /// <br/>Note 2: if <c>date_from</c> and <c>date_to</c> parameters are not specified, the data will be returned for the past 24 months
        /// <br/>if you specify the <c>period</c> parameter:
        /// <br/>with value <c>weekly</c>, you will get results for the past 15 weeks
        /// <br/>with value <c>daily</c>, you will get results for the past 45 days
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

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