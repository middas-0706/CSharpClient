using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleFinanceMarketTrendsElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// object of items
        /// <br/>array contains the following <c>type</c> of items: <c>google_finance_asset_pair_element</c>, <c>google_finance_market_instrument_element</c>, <c>google_finance_market_index_element</c>
        /// </summary>
        [JsonProperty("quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BaseSerpApiGoogleFinanceElementItem Quote { get; set; }

        /// <summary>
        /// array of items
        /// <br/>array contains the following <c>type</c> of items: <c>google_finance_news_element</c>
        /// </summary>
        [JsonProperty("news", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleFinanceNewsElement> News { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}