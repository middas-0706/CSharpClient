using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceAssetPairElementItem  : BaseSerpApiGoogleFinanceTickerSearchElementItem 
    {

        /// <summary>
        /// identifier of the base asset in a pair
        /// <br/>example: <c>EUR</c>
        /// </summary>
        [JsonProperty("base_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSymbol { get; set; }

        /// <summary>
        /// identifier of the quote asset in a pair
        /// <br/>example: <c>USD</c>
        /// </summary>
        [JsonProperty("quote_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string QuoteSymbol { get; set; }

        /// <summary>
        /// full name of the base asset in a pair
        /// <br/>example: <c>Euro</c>
        /// </summary>
        [JsonProperty("base_display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BaseDisplayName { get; set; }

        /// <summary>
        /// full name of the base asset in a pair
        /// <br/>example: <c>Euro</c>
        /// </summary>
        [JsonProperty("quote_display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string QuoteDisplayName { get; set; }

        /// <summary>
        /// value of the base asset compared to the quote asset
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// change in price
        /// <br/>change in <c>price</c> at a given <c>timestamp</c>
        /// </summary>
        [JsonProperty("price_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceDelta { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}