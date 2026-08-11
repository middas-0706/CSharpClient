using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageMicrodataRequestInfo 
    {

        /// <summary>
        /// ID of the task
        /// <br/>required field
        /// <br/>you can get this ID in the response of the <see href="/v3/on_page/task_post/">Task POST</see> endpoint
        /// <br/>example:
        /// <br/><c>'07131248-1535-0216-1000-17384017ad04'</c>
        /// </summary>
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// resource URL
        /// <br/>required field
        /// <br/>you can get this URL in the response of the <see href="/v3/on_page/pages/">Pages</see> endpoint
        /// <br/>example:
        /// <br/><c>https://dataforseo.com/apis</c>
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}