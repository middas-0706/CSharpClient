using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOverviewSerpElementItem  : BaseSerpApiElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical <c>type</c> values;
        /// <br/>positions of elements with different <c>type</c> values are omitted from <c>rank_group</c>;
        /// <br/>always equals <c>0</c> for <c>desktop</c>
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// <br/>always equals <c>0</c> for <c>desktop</c>
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// indicates whether the element is loaded asynchronously
        /// <br/>if <c>true</c>, the <c>ai_overview</c> element is loaded asynchronously;
        /// <br/>if <c>false</c>, the <c>ai_overview</c> element is loaded from cache;
        /// <br/>to obtain the content of <c>ai_overview</c> elements, use the <c>load_async_ai_overview</c> parameter in the POST request
        /// </summary>
        [JsonProperty("asynchronous_ai_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsynchronousAiOverview { get; set; }

        /// <summary>
        /// content of the element in markdown format
        /// <br/>the text of the <c>ai_overview</c> formatted in the <see href="https://en.wikipedia.org/wiki/Markdown">markdown markup language</see>
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// contains arrays of elements available in the list
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseSerpApiAiOverviewElementItem> Items { get; set; }

        /// <summary>
        /// references relevant to the element
        /// <br/>includes references to webpages that were used to generate the <c>ai_overview_element</c>
        /// </summary>
        [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeAiOverviewReferenceInfo> References { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}