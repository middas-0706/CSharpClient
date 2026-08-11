using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoTrendsinterestsValuesInfo 
    {

        /// <summary>
        /// location identifier
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>see the full list of available locations with their <c>geo_id</c> <see href="/v3/keywords_data/dataforseo_trends/locations/">here</see> or by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations</c>
        /// <br/>example:
        /// <br/><c>US-NY</c>
        /// </summary>
        [JsonProperty("geo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeoId { get; set; }

        /// <summary>
        /// location name
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>see the full list of available locations with their <c>geo_name</c> <see href="/v3/keywords_data/dataforseo_trends/locations/">here</see> or by making a separate request to <c>https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations</c>
        /// <br/>example:
        /// <br/><c>Andorra</c>
        /// </summary>
        [JsonProperty("geo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeoName { get; set; }

        /// <summary>
        /// relative keyword popularity rate in a given location
        /// <br/>represents location-specific keyword popularity rate over the specified time range;
        /// <br/>using this <c>value</c> you can understand how popular a keyword is in one location compared to another location;
        /// <br/>calculation: we determine the highest popularity value for the relevant keyword across all locations, and then express all other values as a percentage of that highest value (100);
        /// <br/>a value of <c>100</c> is the highest popularity for the term
        /// <br/>a value of <c>50</c> means that the term is half as popular
        /// <br/>a value of <c>0</c> means there was not enough data for this term
        /// </summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}