using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageBrokenResourceItem  : BaseOnPageResourceItem 
    {

        /// <summary>
        /// time range within which a result was fetched
        /// </summary>
        [JsonProperty("fetch_timing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FetchTiming FetchTiming { get; set; }

        /// <summary>
        /// indicates whether a page is a single resource
        /// </summary>
        [JsonProperty("is_resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsResource { get; set; }

        /// <summary>
        /// resource properties
        /// <br/>the value depends on the <c>resource_type</c>
        /// <br/>note that if you do not indicate a <c>url</c> when setting a task, resource's <c>meta</c> is returned based on the data from the page where our crawler first saw the resource;
        /// <br/>to obtain resource's <c>meta</c> from a particular <c>url</c>, specify that URL when setting a task
        /// </summary>
        [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageMetaInfo Meta { get; set; }

        /// <summary>
        /// indicates the expected type of resource
        /// <br/>for example, if <c>'resource_type': 'broken'</c>, <c>accept_type</c> will indicate the type of the broken resource
        /// <br/>possible values: 
        /// <br/><c>any</c>, <c>none</c>, <c>image</c>, <c>sitemap</c>, <c>robots</c>, <c>script</c>, <c>stylesheet</c>, <c>redirect</c>, <c>html</c>, <c>text</c>, <c>other</c>, <c>font</c>
        /// </summary>
        [JsonProperty("accept_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptType { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}