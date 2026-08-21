using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceMarketIndexElementElementItem  : BaseSerpApiGoogleFinanceElementItem 
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

        /// <summary>
        /// identifier of the element
        /// <br/>full identifier of the element that consists from <c>ticker</c> and <c>market_identifier</c>
        /// <br/>example: <c>PX1:INDEXDB</c>
        /// </summary>
        [JsonProperty("identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// name of the market index as displayed on Google Finance
        /// <br/>example: <c>CAC 40</c>
        /// </summary>
        [JsonProperty("displayed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedName { get; set; }

        /// <summary>
        /// URL to the page of the market index on Google Finance
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// location of the market index
        /// <br/>example: <c>Europe/Paris</c>
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// growth trend of the market index
        /// <br/>possible values: <c>up</c>, <c>down</c>, <c>stable</c>
        /// </summary>
        [JsonProperty("trend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Trend { get; set; }

        /// <summary>
        /// date and time of the value readout
        /// <br/>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'
        /// <br/>example:
        /// <br/><c>2025-02-10 09:40:00 +00:00</c>
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// percentage of change in value of the market index
        /// </summary>
        [JsonProperty("percentage_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentageDelta { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}