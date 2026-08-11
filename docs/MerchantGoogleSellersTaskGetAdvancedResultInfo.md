# MerchantGoogleSellersTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ProductId** | **string** | <em><code>product_id</code> received in a POST array</em><br>learn more about the parameter in <a href='https://dataforseo.com/help-center/product-id-google-shopping' rel='noopener noreferrer' target='_blank'>this help center guide</a> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to Google Shopping results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>title of the product</em> |[optional]|
**Url** | **string** | <em>URL to the product page</em> |[optional]|
**ImageUrl** | **string** | <em>URL to the product image</em> |[optional]|
**Rating** | **RatingInfo** | <em>product rating</em><br>the product popularity rate based on product reviews |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results found in Google Shopping SERP</em><br>contains types of all search results (<code>items</code>) found in the returned SERP<br>possible item types:<br><code>shops_list</code>, <code>buy_on_google</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<BaseMerchantGoogleShoppingSellersElementItem>** | <em>items in SERP</em> |[optional]|