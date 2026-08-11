using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KnowledgeGraphAiOverviewItemSerpElementItem  : BaseSerpApiElementItem 
    {

        /// <summary>
        /// indicates whether the element is loaded asynchronously
        /// <br/>if <c>true</c>, the <c>ai_overview</c> element is loaded asynchronously;
        /// <br/>if <c>false</c>, the <c>ai_overview</c> element is loaded from cache
        /// </summary>
        [JsonProperty("asynchronous_ai_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsynchronousAiOverview { get; set; }

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