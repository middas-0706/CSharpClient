# AmazonSerp


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in Amazon SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | <em>the alignment of the element in Amazon SERP</em><br>can take the following values:<br><code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**Domain** | **string** | <em>Amazon domain</em> |[optional]|
**Title** | **string** | <em>product title</em> |[optional]|
**Url** | **string** | <em>URL of the product page</em> |[optional]|
**Description** | **string** | <em>description of the product</em> |[optional]|
**Asin** | **string** | <em>ASIN in a POST array</em> |[optional]|
**ImageUrl** | **string** | <em>URL of the product image featured in the results</em> |[optional]|
**PriceFrom** | **int?** | <em>the regular price of a product</em><br>example:<br><code>49.98</code> |[optional]|
**PriceTo** | **string** | <em>the upper limit of the product price range</em><br>example:<br><code>384.99</code> |[optional]|
**Currency** | **string** | <em>currency in the <a href='https://en.wikipedia.org/wiki/ISO_4217'>ISO</a> format</em><br>example:<br><code>USD</code> |[optional]|
**SpecialOffers** | **IEnumerable<string>** | <em>special offer details</em><br>contains special offer details, including coupon and Subscribe & Save discounts |[optional]|
**IsBestSeller** | **bool?** | <em>'Best Seller' label</em><br>if the value is <code>true</code>, the product is marked with the 'Best Seller' label |[optional]|
**IsAmazonChoice** | **bool?** | <em>'Amazon's choice' label</em><br>if the value is <code>true</code>, the product is marked with the 'Amazon's choice' label |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>the popularity rate based on reviews and displayed in SERP |[optional]|
**DeliveryInfo** | **AmazonDeliveryInfo** | <em>delivery information</em><br>delivery information including free and fast delivery date ranges |[optional]|