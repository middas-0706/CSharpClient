using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RankInfo 
    {

        /// <summary>
        /// page rank
        /// <br/>            <c>page_rank</c> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm;
        /// <br/>            learn more about the metric and how it is calculated in <see href="https://dataforseo.com/help-center/what_is_rank_in_backlinks_api">this help center article</see>
        /// </summary>
        [JsonProperty("page_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageRank { get; set; }

        /// <summary>
        /// average main domain rank
        /// <br/>            learn more about the metric and its calculation formula in <see href="https://dataforseo.com/help-center/what_is_rank_in_backlinks_api">this help center article</see>
        /// </summary>
        [JsonProperty("main_domain_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MainDomainRank { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}