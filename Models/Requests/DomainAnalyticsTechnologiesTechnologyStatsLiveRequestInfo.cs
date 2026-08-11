using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo 
    {

        /// <summary>
        /// target technology
        /// <br/>required field
        /// <br/>you can find the full list of technologies you can specify here <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>example:
        /// <br/><c>'Salesforce'</c>
        /// </summary>
        [JsonProperty("technology", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Technology { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>minimum value: <c>2022-10-31</c>
        /// <br/>if you don't specify this field, the minimum value will be used by default
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2023-06-01'</c>
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don't specify this field, the today's date will be used by default
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2023-01-15'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

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