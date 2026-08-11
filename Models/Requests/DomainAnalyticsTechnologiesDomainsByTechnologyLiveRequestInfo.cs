using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo 
    {

        /// <summary>
        /// target technology paths
        /// <br/>required field if you don't specify <c>groups</c>, <c>technologies</c>, <c>keywords</c> or <c>categories</c>
        /// <br/>at least one field (<c>technology_paths</c>, <c>groups</c>, <c>technologies</c>, <c>keywords</c> or <c>categories</c>) must be set;
        /// <br/>each technology path should be specified as a separate object containing 'path' and 'name', where 'path' is specified as '$group_id.$category_id' and 'name' - as the name of the target technology; 
        /// <br/>each object with a technology path should be separated with a comma
        /// <br/>you can find the full list of technology group ids, category ids and technology names <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>note: you can specify up to 10 technology paths in this array
        /// <br/>example:
        /// <br/><c>[{'path': 'content.cms','name': 'wordpress'}, {'path': 'marketing.crm','name': 'salesforce'}]</c>
        /// </summary>
        [JsonProperty("technology_paths", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> TechnologyPaths { get; set; }

        /// <summary>
        /// ids of the target technology groups
        /// <br/>required field if you don't specify <c>technologies</c>, <c>technology_paths</c>, <c>keywords</c> or <c>categories</c>
        /// <br/>you can find the full list of technology group ids <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>note: you can specify up to 10 technology groups in this array
        /// <br/>example:
        /// <br/><c>['sales', 'marketing']</c>
        /// </summary>
        [JsonProperty("groups", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Groups { get; set; }

        /// <summary>
        /// ids of the target technology categories
        /// <br/>required field if you don't specify <c>groups</c>, <c>technology_paths</c>, <c>keywords</c> or <c>technologies</c>
        /// <br/>you can find the full list of technology category ids <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>note: you can specify up to 10 technology categories in this array
        /// <br/>example:
        /// <br/><c>['payment_processors','crm']</c>
        /// </summary>
        [JsonProperty("categories", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// target technologies
        /// <br/>required field if you don't specify <c>groups</c>, <c>technology_paths</c>, <c>keywords</c> or <c>categories</c>
        /// <br/>you can find the full list of technologies you can specify here <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>note: you can specify up to 10 technologies in this array
        /// <br/>example:
        /// <br/><c>['Google Pay','Salesforce']</c>
        /// </summary>
        [JsonProperty("technologies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Technologies { get; set; }

        /// <summary>
        /// target keywords in the domain's title, description or meta keywords
        /// <br/>required field if you don't specify <c>groups</c>, <c>technology_paths</c>, <c>technologies</c> or <c>categories</c>
        /// <br/>optional field
        /// <br/>you can specify the maximum of 10 keywords;
        /// <br/>UTF-8 encoding;
        /// <br/>example:
        /// <br/><c>['seo','software']</c>
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// search mode
        /// <br/>optional field
        /// <br/>possible search mode types:
        /// <br/><c>as_is</c> - search for results exactly matching the specified group ids, category ids, or technology names
        /// <br/><c>entry</c> - search for results matching a part of the specified group ids, category ids, or technology names
        /// <br/>default value: <c>as_is</c>
        /// </summary>
        [JsonProperty("mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['country_iso_code','=','US']</c>
        /// <br/><c>[['country_iso_code','=','US'],'and',['domain_rank','&gt;',100]]</c>
        /// <br/><c>[['domain_rank','&gt;',100],'and',[['country_iso_code','=','US'],'or',['country_iso_code','=','CA']]]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/domain_analytics/technologies/filters">Domain Analytics Technologies API - Filters</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>available fields: 
        /// <br/><c>domain_rank</c>, <c>domain</c>, <c>last_visited</c>, <c>country_iso_code</c>, <c>language_code</c>, <c>content_language_code</c>
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/><c>['last_visited,desc']</c>
        /// <br/>default rule:
        /// <br/><c>['domain_rank,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['last_visited,desc','domain_rank,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// the maximum number of returned domains
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>10000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned domains
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten domains in the results array will be omitted and the data will be provided for the successive domains;
        /// <br/>Note: the maximum value is <c>9999</c>, the sum of <c>limit</c> and <c>offset</c> must not exceed <c>10000</c>;
        /// <br/>use the <c>offset_token</c> if you would like to offset more results
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;
        /// <br/>by specifying the unique <c>offset_token</c> value from the response array, you will get the subsequent results of the initial task;
        /// <br/><c>offset_token</c> values are unique for each subsequent task 
        /// <br/>Note: if the <c>offset_token</c> is specified in the request, all other parameters should be identical to the previous request
        /// <br/>learn more about this parameter on our <see href="https://dataforseo.com/help-center/what-is-the-difference-between-the-offset-and-offset_token-parameters#offset_token">Help Center</see>
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}