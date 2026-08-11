using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPagePageScreenshotResultInfo 
    {

        /// <summary>
        /// status of the crawling session
        /// <br/>possible values: <c>in_progress</c>, <c>finished</c>
        /// </summary>
        [JsonProperty("crawl_progress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlProgress { get; set; }

        /// <summary>
        /// error message
        /// <br/>if the <c>url</c> you indicated returns a 404 status code or is not a valid URL, you will obtain <c>'error_message':'Screenshot is empty'</c>
        /// <br/>if no error is encountered, the value will be <c>null</c>
        /// </summary>
        [JsonProperty("error_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// number of items in the results array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ScreenshotItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}