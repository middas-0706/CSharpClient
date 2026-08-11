# ShoppingElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | <em>title of a given link element</em> |[optional]|
**Price** | **PriceInfo** | <em>price indicated in the element</em> |[optional]|
**Source** | **string** | <em>reference source name or title</em> |[optional]|
**Description** | **string** | <em>link description</em> |[optional]|
**Marketplace** | **string** | <em>merchant account provider</em><br>commerce site that hosts products or websites of individual sellers under the same merchant account<br>example:<br><code>by Google</code> |[optional]|
**MarketplaceUrl** | **string** | <em>relevant marketplace URL</em><br>URL of the page on the marketplace website where the product is hosted |[optional]|
**Url** | **string** | <em>source URL</em> |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals <code>null</code> |[optional]|