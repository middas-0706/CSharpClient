using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageSummaryResultInfo 
    {

        /// <summary>
        /// status of the crawling session
        /// <br/>possible values: <c>in_progress</c>, <c>finished</c>
        /// </summary>
        [JsonProperty("crawl_progress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlProgress { get; set; }

        /// <summary>
        /// details of the crawling session
        /// </summary>
        [JsonProperty("crawl_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CrawlStatusInfo CrawlStatus { get; set; }

        /// <summary>
        /// crawler ip address
        /// <br/>displays the IP address used by the crawler to initiate the current crawling session
        /// <br/>you can find the full list of IPs used by our crawler in the <see href="/v3/on_page/overview">Overview section</see>
        /// </summary>
        [JsonProperty("crawl_gateway_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlGatewayAddress { get; set; }

        /// <summary>
        /// reason why the crawling stopped
        /// <br/>information about the reason why the crawling process stopped;
        /// <br/>possible values:
        /// <br/><c>limit_exceeded</c> - the limit set in the <c>max_crawl_pages</c> was exceeded;
        /// <br/><c>empty_queue</c> - all URLs in the queue were crawled;
        /// <br/><c>force_stopped</c> - the crawling process was halted using the<see href="/v3/on_page/force_stop">On Page API Force Stop</see> function;
        /// <br/><c>unexpected_exception</c> - an internal error was encountered while crawling the <c>target</c>, contact support for more info
        /// </summary>
        [JsonProperty("crawl_stop_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlStopReason { get; set; }

        /// <summary>
        /// domain-wide info
        /// <br/>on-page information about the target domain and crawling process
        /// </summary>
        [JsonProperty("domain_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DomainInfo DomainInfo { get; set; }

        /// <summary>
        /// page-specific info
        /// <br/>metrics information on the target website pages
        /// </summary>
        [JsonProperty("page_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageMetrics PageMetrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}