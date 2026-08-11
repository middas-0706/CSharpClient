using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo 
    {

        /// <summary>
        /// target technology paths
        /// <br/>required field if you don't specify <c>groups</c>, <c>technologies</c> and <c>categories</c>
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
        /// <br/>required field if you don't specify <c>technologies</c>, <c>technology_paths</c>, <c>categories</c>, or <c>keywords</c>
        /// <br/>you can find the full list of technology group ids <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>note: you can specify up to 10 technology groups in this array
        /// <br/>example:
        /// <br/><c>['sales', 'marketing']</c>
        /// </summary>
        [JsonProperty("groups", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Groups { get; set; }

        /// <summary>
        /// ids of the target technology categories
        /// <br/>required field if you don't specify <c>groups</c>, <c>technology_paths</c>, <c>technologies</c>, or <c>keywords</c>
        /// <br/>you can find the full list of technology category ids <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>note: you can specify up to 10 technology categories in this array
        /// <br/>example:
        /// <br/><c>['payment_processors','crm']</c>
        /// </summary>
        [JsonProperty("categories", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// target technologies
        /// <br/>required field if you don't specify <c>groups</c>, <c>technology_paths</c>, <c>categories</c>, or <c>keywords</c>
        /// <br/>you can find the full list of technologies you can specify here <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>note: you can specify up to 10 technologies in this array
        /// <br/>example:
        /// <br/><c>['Google Pay','Salesforce']</c>
        /// </summary>
        [JsonProperty("technologies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Technologies { get; set; }

        /// <summary>
        /// target keywords in the domain's title, description or meta keywords
        /// <br/>required field if you don't specify <c>groups</c>, <c>technology_paths</c>, <c>categories</c>, or <c>technologies</c>
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
        /// <br/><c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>,<c>not_like</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>you can use the following parameters to filter the results: <c>domain_rank</c>, <c>last_visited</c>, <c>country_iso_code</c>, <c>language_code</c>, <c>content_language_code</c>
        /// <br/>example:
        /// <br/><c>[['country_iso_code','=','US'],'and',['domain_rank','&gt;',800]]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/domain_analytics/technologies/filters">Domain Analytics Technologies API - Filters</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/><c>countries</c>, <c>languages</c>, <c>content_languages</c>, <c>keywords</c>
        /// <br/>default value: <c>10</c>
        /// <br/>minimum value: <c>1</c>
        /// <br/>maximum value: <c>10000</c>
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

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