using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceMarketIndexElementItem  : BaseSerpApiGoogleFinanceTickerSearchElementItem 
    {

        /// <summary>
        /// ticker of the market index
        /// <br/>example: <c>DAX</c>
        /// </summary>
        [JsonProperty("ticker", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ticker { get; set; }

        /// <summary>
        /// market identifier
        /// <br/>example: <c>INDEXDB</c>
        /// </summary>
        [JsonProperty("market_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MarketIdentifier { get; set; }

        /// <summary>
        /// value of the market index
        /// <br/>numerical value of the index at a given <c>timestamp</c>
        /// </summary>
        [JsonProperty("index_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IndexValue { get; set; }

        /// <summary>
        /// change in value of the market index
        /// <br/>change in the <c>index_value</c> at a given <c>timestamp</c>
        /// </summary>
        [JsonProperty("index_value_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IndexValueDelta { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}