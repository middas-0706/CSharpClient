using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageImageResourceItem  : BaseOnPageResourceItem 
    {

        /// <summary>
        /// page properties
        /// <br/>the value depends on the <c>resource_type</c>
        /// </summary>
        [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ResourceMetaInfo Meta { get; set; }

        /// <summary>
        /// time range within which a result was fetched
        /// </summary>
        [JsonProperty("fetch_timing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FetchTiming FetchTiming { get; set; }

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