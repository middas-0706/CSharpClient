using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixGoogleBusinessDataPriceData 
    {
        [JsonProperty("extended_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo ExtendedReviews { get; set; }
        [JsonProperty("hotel_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAmazonMerchantPriceDataInfo HotelInfo { get; set; }
        [JsonProperty("hotel_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmResponsesAiOptimizationPriceData HotelSearches { get; set; }
        [JsonProperty("my_business_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmResponsesAiOptimizationPriceData MyBusinessInfo { get; set; }
        [JsonProperty("my_business_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmResponsesAiOptimizationPriceData MyBusinessUpdates { get; set; }
        [JsonProperty("questions_and_answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmResponsesAiOptimizationPriceData QuestionsAndAnswers { get; set; }
        [JsonProperty("reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLlmResponsesAiOptimizationPriceData Reviews { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}