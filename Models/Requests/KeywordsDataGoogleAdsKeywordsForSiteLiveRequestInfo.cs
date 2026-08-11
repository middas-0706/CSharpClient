using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo 
    {

        /// <summary>
        /// domain or page
        /// <br/>required field
        /// <br/>the domain name of the target website or the url of the target page;
        /// <br/>note: to obtain keywords for the target website, use the <c>target_type</c> parameter
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// search keywords for site or for url
        /// <br/>optional field
        /// <br/>possible values: <c>site</c>, <c>page</c>;
        /// <br/>default value: <c>page</c>;
        /// <br/>if set to <c>site</c>, keywords will be provided for the entire site;
        /// <br/>if set to <c>page</c>, keywords will be provided for the specified webpage
        /// </summary>
        [JsonProperty("target_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

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
        /// include Google search partners
        /// <br/>optional field
        /// <br/>if you specify <c>true</c>, the results will be delivered for owned, operated, and syndicated networks across <see href="https://support.google.com/google-ads/answer/1722047?hl=en">Google and partner sites</see> that host Google search;
        /// <br/>default value: <c>false</c> - results are returned for Google search sites
        /// </summary>
        [JsonProperty("search_partners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>minimal value: 4 years from the current date
        /// <br/>by default, data is returned for the past 12 months;
        /// <br/>Note: the indicated date cannot be greater than that specified in <c>date_to</c> and/or yesterday's date;if <see href="/v3/keywords_data/google_ads/status/">Status endpoint</see> returns <c>false</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the month before last and prior;
        /// <br/>if <see href="/v3/keywords_data/google_ads/status/">Status endpoint</see> returns <c>true</c> in the <c>actual_data</c> field, <c>date_from</c> can be set to the last month and prior
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>Note: the indicated date cannot be greater than yesterday's date;
        /// <br/>if you don't specify this field, yesterday's date will be used by default
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2022-11-30'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// include keywords associated with adult content
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, adult keywords will be included in the response
        /// <br/>default value: <c>false</c>
        /// <br/>note that the API may return no data for such keywords due to <see href="https://support.google.com/adspolicy/answer/6008942?hl=en">Google Ads restrictions</see>
        /// </summary>
        [JsonProperty("include_adult_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAdultKeywords { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>Use these parameters to sort the results by <c>relevance</c>, <c>search_volume</c>, <c>competition_index</c>, <c>low_top_of_page_bid</c>, or <c>high_top_of_page_bid</c> in descending order
        /// <br/>default value: <c>relevance</c>
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

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