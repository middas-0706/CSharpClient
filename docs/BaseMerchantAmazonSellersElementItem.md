# BaseMerchantAmazonSellersElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em> absolute rank in SERP</em><br>absolute position among all the elements found in Amazon Sellers SERP |[optional]|
**Position** | **string** | <em>alignment of the element in SERP</em><br>possible values:<br><code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em><a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**SellerName** | **string** | <em>business name of the seller</em> |[optional]|
**SellerUrl** | **string** | <em>url forwarding to the seller's page on Amazon</em> |[optional]|
**ShipsFrom** | **string** | <em>sender company name</em> |[optional]|
**Price** | **PriceInfo** | <em>product pricing details</em><br>if there are no details, the value will be <code>null</code> |[optional]|
**PercentageDiscount** | **double?** | <em>value of the percentage discount</em> |[optional]|
**ApplicableVouchers** | **IEnumerable<AmazonApplicableVouchersItem>** | <em>array of objects containing information about applicable vouchers</em> |[optional]|
**Rating** | **RatingElement** | <em>seller rating details</em><br>seller popularity rate based on customer reviews |[optional]|
**Condition** | **string** | <em>product condition</em><br>condition of the product offered by the seller |[optional]|
**ConditionDescription** | **string** | <em>product condition details</em><br>expanded details on the condition of the product offered by the seller |[optional]|
**DeliveryInfo** | **AmazonDeliveryInfo** | <em>delivery information</em><br>delivery information including free and fast delivery date ranges |[optional]|