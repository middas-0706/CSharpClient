using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageLinksRequestInfo 
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
        /// relative page URL
        /// <br/>optional field
        /// <br/>if you use this field, the API response will contain only links from the specified page
        /// <br/>note that in this field you can specify relative URLs only
        /// </summary>
        [JsonProperty("page_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageFrom { get; set; }

        /// <summary>
        /// relative page URL
        /// <br/>optional field
        /// <br/>if you use this field, the API response will contain only internal links pointing to the specified page
        /// <br/>note that in this field you can specify relative URLs only
        /// </summary>
        [JsonProperty("page_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageTo { get; set; }

        /// <summary>
        /// the maximum number of returned links
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned links
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>maximum value: <c>2000000</c>
        /// <br/>if you specify the <c>10</c> value, the first ten links in the results array will be omitted and the data will be provided for the successive links
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['direction','=','external']</c>
        /// <br/><c>[['domain_to','&lt;&gt;','example.com'],'and',['link_from','not_like','%example.com/blog%']]</c>
        /// <br/><c>[['direction','=','external'],'and',[['link_from','like','%example.com/blog%'],'or',['link_from','like','%example.com/help%']]]</c>
        /// <br/>The full list of possible filters is available <see href="/v3/on_page/filters_and_thresholds/?bash">by this link.</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over <c>20,000</c> results in a single request;
        /// <br/>by specifying the unique <c>search_after_token</c> value from the response array, you will get the subsequent results of the initial task;
        /// <br/><c>search_after_token</c> values are unique for each subsequent task ;
        /// <br/>Note: if the <c>search_after_token</c> is specified in the request, all other parameters should be identical to the previous request
        /// </summary>
        [JsonProperty("search_after_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchAfterToken { get; set; }

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