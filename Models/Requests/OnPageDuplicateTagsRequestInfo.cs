using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageDuplicateTagsRequestInfo 
    {

        /// <summary>
        /// ID of the task
        /// <br/>required field
        /// <br/>you can get this ID in the response of the <see href="https://docs.dataforseo.com/v3/on_page/task_post/">Task POST</see> endpoint
        /// <br/>example:
        /// <br/>'07131248-1535-0216-1000-17384017ad04'
        /// </summary>
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// tag value
        /// <br/>optional field
        /// <br/>specify a title or description here if you want to receive a list of duplicate pages that contains this tag
        /// </summary>
        [JsonProperty("accumulator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Accumulator { get; set; }

        /// <summary>
        /// the maximum number of returned pages
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned pages
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>maximum value: <c>2000000</c>
        /// <br/>if you specify the <c>10</c> value, the first ten pages in the results array will be omitted and the data will be provided for the successive pages
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

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