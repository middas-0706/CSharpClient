using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SearchIntentInfo 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// main search intent
        /// <br/>possible values: <c>informational</c>, <c>navigational</c>, <c>commercial</c>, <c>transactional</c>
        /// </summary>
        [JsonProperty("main_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainIntent { get; set; }

        /// <summary>
        /// supplementary search intents
        /// <br/>possible values: <c>informational</c>, <c>navigational</c>, <c>commercial</c>, <c>transactional</c>
        /// </summary>
        [JsonProperty("foreign_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ForeignIntent { get; set; }

        /// <summary>
        /// date and time when keyword data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}