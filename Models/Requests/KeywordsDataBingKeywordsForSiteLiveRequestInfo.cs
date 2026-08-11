using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataBingKeywordsForSiteLiveRequestInfo 
    {

        /// <summary>
        /// domain or URL
        /// <br/>required field
        /// <br/>the domain name or URL of the target website
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/bing/locations</c>
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
        /// <br/>supported languages:
        /// <br/><c>English</c>, <c>French</c>, <c>German</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>supported languages:
        /// <br/><c>en</c>, <c>fr</c>, <c>de</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// keywords negative array
        /// <br/>optional field
        /// <br/>These keywords will be ignored in the results array;
        /// <br/>You can specify a maximum of 200 terms that you want to exclude from the results;
        /// <br/>the specified keywords will be converted to lowercase format
        /// </summary>
        [JsonProperty("keywords_negative", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> KeywordsNegative { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>specify this field if you want to get the data for a particular device typepossible values: <c>all</c>, <c>mobile</c>, <c>desktop</c>, <c>tablet</c>
        /// <br/>default value: <c>all</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>minimal value: 24 months from today's date;
        /// <br/>if you don't specify this field, data will be provided for the last 12 months;
        /// <br/>if <see href="/v3/keywords_data/bing/status/">Status endpoint</see> returns <c>false</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the month before last and prior;
        /// <br/>if <see href="/v3/keywords_data/bing/status/">Status endpoint</see> returns <c>true</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the last month and prior;
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2020-01-01'</c>
        /// <br/>Note: we do not recommend using a custom time range for the past year's dates
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don't specify this field, data will be provided for the last 12 months;
        /// <br/>minimum value: two years back from today’s date;
        /// <br/>maximum value: one month from today's date;
        /// <br/>note: we do not recommend using a custom time range for the past year's dates;
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2020-03-15'</c>
        /// <br/>Note: we do not recommend using a custom time range for the past year's dates
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>Use these parameters to sort the results by <c>search_volume</c>, <c>cpc</c>, <c>competition</c> or <c>relevance</c> in the descending order
        /// <br/>default value: <c>relevance</c>
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// Bing search partners type
        /// <br/>optional field
        /// <br/>if you specify <c>true</c>, the results will be delivered for owned, operated, and syndicated networks across Bing, Yahoo, AOL and partner sites that host Bing, AOL, and Yahoo search.
        /// <br/>default value: <c>false</c> - results are returned for Bing, AOL, and Yahoo search networks
        /// </summary>
        [JsonProperty("search_partners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

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