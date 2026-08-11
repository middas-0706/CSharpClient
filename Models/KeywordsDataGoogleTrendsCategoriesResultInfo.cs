using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataGoogleTrendsCategoriesResultInfo 
    {

        /// <summary>
        /// unique google trends category identifier
        /// </summary>
        [JsonProperty("category_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// name of the google trends category
        /// </summary>
        [JsonProperty("category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// the code of the superordinate category
        /// <br/>example:
        /// <br/><c>'category_code': 1100,</c>
        /// <br/><c>'category_name': 'Superhero Films',</c>
        /// <br/><c>'category_code_parent': 1097</c> 
        /// <br/>where <c>category_code_parent</c> corresponds to: 
        /// <br/><c>'category_code': 1097,</c>
        /// <br/><c>'category_name': 'Action &amp; Adventure Films'</c>
        /// </summary>
        [JsonProperty("category_code_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryCodeParent { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}