using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsAvailableFiltersTaskInfo  : BaseResponseTaskInfo 
    {

        /// <summary>
        /// array of results
        /// <br/>contains the full list of available parameters that can be used for data filtration
        /// <br/>the parameters are grouped by the endpoint they can be used with
        /// </summary>
        [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<DataforseoLabsAvailableFiltersResultInfo> Result { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}