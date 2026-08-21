using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ChatGptAdElementItem  : BaseChatGptLlmScraperElementItem 
    {

        /// <summary>
        /// indicates whether the ad is displayed to the user
        /// <br/>if `true`, the ad is present in the response and shown on the page
        /// <br/>if `false`, the ad is present in the response but not displayed to the user
        /// </summary>
        [JsonProperty("is_rendered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRendered { get; set; }

        /// <summary>
        /// name of the brand
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// source description
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// URL of the image displayed in the ad
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// information about the advertiser associated with the ad
        /// </summary>
        [JsonProperty("advertiser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChatGptAdAdvertiser Advertiser { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}