using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleShoppingSellersShopsListElementItem  : BaseMerchantGoogleShoppingSellersElementItem 
    {

        /// <summary>
        /// monthly price multiplier
        /// <br/>indicates the number of months covered by the monthly payment for the product
        /// </summary>
        [JsonProperty("price_multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMultiplier { get; set; }

        /// <summary>
        /// installment details as displayed in the results
        /// <br/>shows how the product price can be broken down into monthly payments, if applicable
        /// </summary>
        [JsonProperty("displayed_payment_breakdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedPaymentBreakdown { get; set; }

        /// <summary>
        /// shop rating
        /// <br/>the shop popularity rate based on product reviews
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// indicated condition of the product
        /// <br/>possible values: <c>Used</c>, <c>Refurbished</c>, <c>New</c>, <c>Pre-owned</c>, <c>null</c>
        /// </summary>
        [JsonProperty("product_condition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCondition { get; set; }

        /// <summary>
        /// data from annotations and badges with special offers
        /// <br/>if there is no annotation for this product, the value will be <c>null</c>
        /// <br/>examples: <c>LOW PRICE</c>, <c>SPECIAL OFFER</c>, <c>SALE</c>, <c>PRICE DROP</c>
        /// </summary>
        [JsonProperty("product_annotation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAnnotation { get; set; }

        /// <summary>
        /// product availability information
        /// <br/>product availability information
        /// <br/>can take the following values: <c>in_stock</c>, <c>limited_stock</c>, <c>out_of_stock</c>, <c>backordered</c>, <c>pre_order_available</c>, <c>on_display_to_order</c>
        /// </summary>
        [JsonProperty("product_availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAvailability { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}