using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo 
    {

        /// <summary>
        /// id of the target technology group
        /// <br/>required field if you don't specify <c>technology</c>, <c>category</c> or <c>keyword</c>
        /// <br/>at least one field (<c>group</c>, <c>category</c>, <c>keyword</c>, <c>technology</c>) must be set
        /// <br/>you can find the full list of technology group ids <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>example:
        /// <br/><c>'marketing'</c>
        /// </summary>
        [JsonProperty("group", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// id of the target technology category
        /// <br/>required field if you don't specify <c>group</c>, <c>keyword</c> or <c>technology</c>
        /// <br/>at least one field (<c>group</c>, <c>category</c>, <c>keyword</c>, <c>technology</c>) must be set
        /// <br/>you can find the full list of technology category ids <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>example:
        /// <br/><c>'crm'</c>
        /// </summary>
        [JsonProperty("category", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// target technology
        /// <br/>required field if you don't specify <c>group</c>, <c>keyword</c> or <c>category</c>
        /// <br/>at least one field (<c>group</c>, <c>category</c>, <c>keyword</c>, <c>technology</c>) must be set
        /// <br/>you can find the full list of technologies <see href="/v3/domain_analytics/technologies/technologies">on this page</see>
        /// <br/>example:
        /// <br/><c>'Salesforce'</c>
        /// </summary>
        [JsonProperty("technology", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Technology { get; set; }

        /// <summary>
        /// target keyword in the domain's meta keywords
        /// <br/>required field if you don't specify <c>group</c>, <c>category</c> or <c>technology</c>
        /// <br/>at least one field (<c>group</c>, <c>category</c>, <c>keyword</c>, <c>technology</c>) must be set
        /// <br/>UTF-8 encoding
        /// <br/>example:
        /// <br/><c>'seo'</c>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

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
        /// <br/>Note: all filtering parameters are taken from the <c>domain_technology_item</c> of the <see href="/v3/domain_analytics/technologies/filters">domain_technologies</see> endpoint;
        /// <br/>example:
        /// <br/><c>[['country_iso_code','=','US'],'and',['domain_rank','&gt;',800]]</c>for more information about filters, please refer to <see href="/v3/domain_analytics/technologies/filters">Domain Analytics Technologies API - Filters</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the following values to sort the results: <c>groups_count</c>, <c>categories_count</c>, <c>technologies_count</c>
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/><c>['groups_count,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['groups_count,desc','technologies_count,desc']</c>
        /// <br/>default value:
        /// <br/><c>['groups_count,desc','categories_count,desc','technologies_count,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// maximum number of returned technology groups
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of items with identical <c>'group'</c> in the results
        /// <br/>default value: <c>5</c>
        /// <br/>minimum value: <c>1</c>
        /// <br/>maximum value: <c>10000</c>
        /// </summary>
        [JsonProperty("internal_groups_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalGroupsListLimit { get; set; }

        /// <summary>
        /// maximum number of returned technology categories within the same group
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of items with identical <c>'category'</c> in the results
        /// <br/>default value: <c>5</c>
        /// <br/>minimum value: <c>1</c>
        /// <br/>maximum value: <c>10000</c>
        /// </summary>
        [JsonProperty("internal_categories_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalCategoriesListLimit { get; set; }

        /// <summary>
        /// maximum number of returned technologies within the same category
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of items with identical <c>'technology'</c> in the results
        /// <br/>default value: <c>10</c>
        /// <br/>minimum value: <c>1</c>
        /// <br/>maximum value: <c>10000</c>
        /// </summary>
        [JsonProperty("internal_technologies_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalTechnologiesListLimit { get; set; }

        /// <summary>
        /// maximum number of items with identical <c>'category'</c>, <c>'group'</c>, and <c>'technology'</c>
        /// <br/>optional field
        /// <br/>if you use this field, the values specified in <c>internal_groups_list_limit</c>, <c>internal_categories_list_limit</c> and <c>internal_technologies_list_limit</c> will be ignored;
        /// <br/>you can use this field to limit the number of items with identical <c>'category'</c>, <c>'group'</c>, or <c>'technology'</c>
        /// <br/>default value: <c>10</c>
        /// <br/>minimum value: <c>1</c>
        /// <br/>maximum value: <c>10000</c>
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// the maximum number of returned technologies
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
        /// <br/>maximum value: <c>9999</c>
        /// <br/>if you specify the <c>10</c> value, the first ten technologies in the results array will be omitted and the data will be provided for the successive technologies
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

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