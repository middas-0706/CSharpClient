using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataBingSearchVolumeHistoryTaskGetResultInfo 
    {

        /// <summary>
        /// keyword in a POST array
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, then the value is_<c>null</c>n
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>if there is no data, then the value is_<c>null</c>n
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Device { get; set; }
        [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }
        [JsonProperty("searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SearchVolumeHistorySearchInfo Searches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}