# BaseMerchantGoogleShoppingSellersElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em> absolute rank in SERP</em><br>absolute position among all the elements found in Google Shopping SERP |[optional]|
**Position** | **string** | <em>the alignment of the element in Google Shopping SERP</em><br>possible values:<br><code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em><a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**Domain** | **string** | <em>domain in SERP</em> |[optional]|
**Title** | **string** | <em>product title</em> |[optional]|
**Url** | **string** | <em>Google Shopping URL forwarding to the product page on the seller’s website</em><br>if you want to obtain a URL of the advertisement forwarding to the product page on the seller's website, please refer to the <a href='/v3/merchant/google/sellers/ad_url/'>Google Shopping Sellers Ad URL</a> endpoint |[optional]|
**Details** | **string** | <em>details and special offers</em><br>if there are no details, the value will be <code>null</code> |[optional]|
**BasePrice** | **double?** | <em>product price without tax and shipping</em> |[optional]|
**Tax** | **double?** | <em>the amount of tax</em><br>tax is specified as the actual amount of money, not as the percentage |[optional]|
**ShippingPrice** | **double?** | <em>product shipping price</em> |[optional]|
**TotalPrice** | **double?** | <em>product price including tax and shipping</em> |[optional]|
**Currency** | **string** | <em>currency in the <a href='https://en.wikipedia.org/wiki/ISO_4217'>ISO</a> format</em><br>example:<br><code>USD</code> |[optional]|
**SellerName** | **string** | <em>name of the seller</em><br>the name of the company that placed a corresponding product on Google Shopping |[optional]|
**ShopAdAclk** | **string** | <em>unique ad click referral parameter</em><br>using this parameter you can get a URL of the advertisement in <a href='/v3/merchant/google/sellers/ad_url/'>Google Shopping Sellers Ad URL</a> |[optional]|