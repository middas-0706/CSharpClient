using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TrendsMapDataInfo 
    {

        /// <summary>
        /// Google Trends location identifier
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>example:
        /// <br/><c>US-NY</c>
        /// </summary>
        [JsonProperty("geo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeoId { get; set; }

        /// <summary>
        /// Google Trends location name
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// </summary>
        [JsonProperty("geo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeoName { get; set; }

        /// <summary>
        /// relative keyword popularity rate in a given location
        /// <br/>represents the location-specific keyword popularity rate over the given time range
        /// <br/>if you specify more than one keyword, the values will be averaged to the highest value across all specified keywords
        /// <br/>a value of <c>100</c> is the peak popularity for the term
        /// <br/>a value of <c>50</c> means that the term is half as popular
        /// <br/>a value of <c>0</c> means there was not enough data for this term
        /// </summary>
        [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<double?> Values { get; set; }

        /// <summary>
        /// max value among comparable terms
        /// <br/>represents the maximum value if you specified more than two keywords in a POST array
        /// <br/>if you specified only one keyword, the value will be <c>null</c>
        /// </summary>
        [JsonProperty("max_value_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxValueIndex { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}