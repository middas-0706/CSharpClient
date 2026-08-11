using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainInfo 
    {

        /// <summary>
        /// domain name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// content management system
        /// <br/>content management system identified on a website
        /// <br/>the content of_the <c>generator</c>_meta tag
        /// <br/>the data is taken from the first random page that returns the 200 response code
        /// <br/>if our crawler was unable to identify the cms, the value would be <c>null</c>n
        /// </summary>
        [JsonProperty("cms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cms { get; set; }

        /// <summary>
        /// domain ip address
        /// </summary>
        [JsonProperty("ip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// website server
        /// <br/>the version of the server detected on a website
        /// <br/>the content of the <c>server</c> header
        /// <br/>the information is taken from the first page which response code is 200
        /// </summary>
        [JsonProperty("server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// time when the crawling start
        /// <br/>date and time when the website was sent for crawling
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("crawl_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlStart { get; set; }

        /// <summary>
        /// time when the crawling ended
        /// <br/>date and time when the crawling was finished
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// <br/>Note: informative only if <c>'crawl_progress'</c> is <c>'finished'</c>
        /// <br/>if <c>'crawl_progress'</c> is <c>in_progress</c>, the value will be <c>null</c>
        /// </summary>
        [JsonProperty("crawl_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CrawlEnd { get; set; }

        /// <summary>
        /// crawl status and errors
        /// <br/>indicates the reason why a website was not crawled;
        /// <br/>can take the following values:
        /// <br/><c>no_errors</c> - no crawling errors were detected;
        /// <br/><c>site_unreachable</c> - our crawler could not reach a website and thus was not able to obtain a status code;
        /// <br/><c>invalid_page_status_code</c> - status code of the first crawled page &gt;= 400;
        /// <br/><c>forbidden_meta_tag</c> - the first crawled page contains the  tag;
        /// <br/><c>forbidden_robots</c> - robots.txt forbids crawling the page;
        /// <br/><c>forbidden_http_header</c> - HTTP header of the page contains 'X-Robots-Tag: noindex' ;
        /// <br/><c>too_many_redirects</c> - the first crawled page has more than 10 redirects;
        /// <br/><c>unknown</c> - the reason is unknown
        /// </summary>
        [JsonProperty("extended_crawl_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendedCrawlStatus { get; set; }

        /// <summary>
        /// ssl certificate info
        /// <br/>information about the Secure Sockets Layer protocol detected on a website
        /// </summary>
        [JsonProperty("ssl_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SslInfo SslInfo { get; set; }

        /// <summary>
        /// website checks
        /// <br/>other on-page check-ups related to the website
        /// </summary>
        [JsonProperty("checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, bool?> Checks { get; set; }

        /// <summary>
        /// total crawled pages
        /// <br/>the total number of crawled pages
        /// </summary>
        [JsonProperty("total_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalPages { get; set; }

        /// <summary>
        /// total uncrawlable resources
        /// <br/>the total number of resources that could not be crawled;
        /// <br/>the resource is considered uncrawlable when the actual content type of the resource doesn't match the content type expected by the crawler
        /// </summary>
        [JsonProperty("total_uncrawlable_resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalUncrawlableResources { get; set; }

        /// <summary>
        /// status code returned by a non-existent page
        /// <br/>in most cases, it is recommended a server returns a 404 response code
        /// </summary>
        [JsonProperty("page_not_found_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNotFoundStatusCode { get; set; }

        /// <summary>
        /// status code returned by a canonicalized page
        /// <br/>the checkup of the server behavior when our crawler tries to access the website via IP;
        /// <br/>in most cases, it is recommended that canonicalized pages respond with a <c>301</c> or <c>302</c> status code
        /// </summary>
        [JsonProperty("canonicalization_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CanonicalizationStatusCode { get; set; }

        /// <summary>
        /// status code returned by a directory
        /// <br/>the status code returned by a directory page on a target website
        /// <br/>in most cases, it is recommended that directories respond with a <c>403</c> or <c>401</c> status code
        /// </summary>
        [JsonProperty("directory_browsing_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DirectoryBrowsingStatusCode { get; set; }

        /// <summary>
        /// redirect status code
        /// <br/>the status code of the www to non-www redirect
        /// <br/>in most cases, it is recommended that redirect returns a <c>301</c> status code
        /// </summary>
        [JsonProperty("www_redirect_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WwwRedirectStatusCode { get; set; }

        /// <summary>
        /// root domain name
        /// </summary>
        [JsonProperty("main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}