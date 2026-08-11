using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataBingKeywordPerformanceLiveResultInfo 
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

        /// <summary>
        /// indicates the year for which the data is provided for
        /// <br/>example:
        /// <br/><c>2020</c>
        /// </summary>
        [JsonProperty("year", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Year { get; set; }

        /// <summary>
        /// indicates the month for which the data is provided for
        /// <br/>example:
        /// <br/><c>10</c>
        /// </summary>
        [JsonProperty("month", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Month { get; set; }

        /// <summary>
        /// object containing keyword metrics
        /// <br/>if there is no data, then the value is_<c>null</c>n
        /// </summary>
        [JsonProperty("keyword_kpi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeywordKpi KeywordKpi { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}