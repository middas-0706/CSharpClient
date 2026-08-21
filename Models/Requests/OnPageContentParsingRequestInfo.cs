using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageContentParsingRequestInfo 
    {

        /// <summary>
        /// URL of the content to parse
        /// <br/>required field
        /// <br/>URL of the page to parse
        /// <br/>example:
        /// <br/>`https://dataforseo.com/blog/a-versatile-alternative-to-google-trends-exploring-the-power-of-dataforseo-trends-api`
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// ID of the task
        /// <br/>required field
        /// <br/>you can get this ID in the response of the <see href="/v3/on_page/task_post/">Task POST</see> endpoint
        /// <br/>note: the <c>enable_content_parsing</c> parameter in the POST request must be set to <c>true</c>
        /// <br/>example:
        /// <br/><c>'07131248-1535-0216-1000-17384017ad04'</c>
        /// </summary>
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// return page content as markdown
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, the markdown-formatted content of the page will be returned in the <c>page_as_markdown</c> field of the response;
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("markdown_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkdownView { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}