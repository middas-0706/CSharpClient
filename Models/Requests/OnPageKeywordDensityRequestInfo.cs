using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageKeywordDensityRequestInfo 
    {

        /// <summary>
        /// ID of the task
        /// <br/>required field
        /// <br/>you can get this ID in the response of the <see href="/v3/on_page/task_post/">Task POST</see> endpoint
        /// <br/>example:
        /// <br/>'07131248-1535-0216-1000-17384017ad04'
        /// </summary>
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// number of words for a keyword
        /// <br/>required field
        /// <br/>possible values:
        /// <br/><c>1</c>, <c>2</c>, <c>3</c>, <c>4</c>, <c>5</c>
        /// </summary>
        [JsonProperty("keyword_length", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? KeywordLength { get; set; }

        /// <summary>
        /// page URL
        /// <br/>optional field
        /// <br/>if you do not specify a page here, the results will be provided for the whole website
        /// <br/>if you use this field, the API response will contain only keywords from the specified page
        /// <br/>a page should be specified with absolute URL (including <c>http://</c> or <c>https://</c>)
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the maximum number of returned keywords
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['keyword','=','%seo%']</c>
        /// <br/><c>[['keyword','=','%seo%'],'and',['frequency','&lt;','6']]</c>
        /// <br/><c>[['keyword','not_like','%seo%'],'and',[['frequency','&gt;','6'],'or',['density','&gt;','0.02']]]</c>
        /// <br/>The full list of possible filters is available <see href="/v3/on_page/filters_and_thresholds/?bash">by this link.</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/><c>['frequency,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['keyword,asc','frequency,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

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