using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HtmlContentInfo 
    {

        /// <summary>
        /// total size of the text on the page measured in bytes
        /// </summary>
        [JsonProperty("plain_text_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PlainTextSize { get; set; }

        /// <summary>
        /// plaintext rate value
        /// <br/>plain_text_size to size ratio
        /// </summary>
        [JsonProperty("plain_text_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PlainTextRate { get; set; }

        /// <summary>
        /// number of words on the page
        /// </summary>
        [JsonProperty("plain_text_word_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PlainTextWordCount { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Automated_readability_index">Automated Readability Index</see>
        /// </summary>
        [JsonProperty("automated_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AutomatedReadabilityIndex { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Coleman%E2%80%93Liau_index">Coleman–Liau Index</see>
        /// </summary>
        [JsonProperty("coleman_liau_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ColemanLiauReadabilityIndex { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Dale%E2%80%93Chall_readability_formula">Dale–Chall Readability Index</see>
        /// </summary>
        [JsonProperty("dale_chall_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DaleChallReadabilityIndex { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Flesch%E2%80%93Kincaid_readability_tests">Flesch–Kincaid Readability Index</see>
        /// </summary>
        [JsonProperty("flesch_kincaid_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FleschKincaidReadabilityIndex { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/SMOG">SMOG Readability Index</see>
        /// </summary>
        [JsonProperty("smog_readability_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SmogReadabilityIndex { get; set; }

        /// <summary>
        /// consistency of the meta <c>description</c> tag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [JsonProperty("description_to_content_consistency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DescriptionToContentConsistency { get; set; }

        /// <summary>
        /// consistency of the meta <c>title</c> tag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [JsonProperty("title_to_content_consistency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TitleToContentConsistency { get; set; }

        /// <summary>
        /// consistency of meta <c>keywords</c>tag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [JsonProperty("meta_keywords_to_content_consistency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MetaKeywordsToContentConsistency { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}