using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class CountryDistribution 
    {

        /// <summary>
        /// country ISO code
        /// </summary>
        [JsonProperty("country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// clickstream-based average monthly search volume rate
        /// <br/>represents the (approximate) number of searches for the given keyword idea based on clickstream
        /// <br/>you can learn more about clickstream search volume in <see href="https://dataforseo.com/help-center/what-is-clickstream-search-volume-and-how-to-get-it-with-dataforseo">this Help Center article</see>
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// percentage of global search volume
        /// </summary>
        [JsonProperty("percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}