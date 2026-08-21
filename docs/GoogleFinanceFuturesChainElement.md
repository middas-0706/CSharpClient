# GoogleFinanceFuturesChainElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**ExpirationTimestamp** | **string** | <em>futures' date and time of expiration</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code class='long-string'>2025-02-10 09:40:00 +00:00</code> |[optional]|
**Symbol** | **string** | <em>futures' symbol</em> |[optional]|
**Price** | **double?** | <em>price of the market instrument</em><br>price of the market instrument at a given <code>timestamp</code> |[optional]|
**PriceCurrency** | **string** | <em>currency of the price value</em> |[optional]|
**PriceDelta** | **double?** | <em>change in price of the market instrument</em><br>change in <code>price</code> at a given <code>timestamp</code> |[optional]|
**PercentageDelta** | **double?** | <em>percentage of change in value of the market index</em> |[optional]|
**Trend** | **string** | <em>growth trend of the market index</em><br>possible values: <code>up</code>, <code>down</code>, <code>stable</code> |[optional]|