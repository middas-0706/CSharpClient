# SerpApiGoogleFinanceMarketIndexElementElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Ticker** | **string** | <em>ticker of the market index</em><br>example: <code>DAX</code> |[optional]|
**MarketIdentifier** | **string** | <em>market identifier</em><br>example: <code>INDEXDB</code> |[optional]|
**IndexValue** | **double?** | <em>value of the market index</em><br>numerical value of the index at a given <code>timestamp</code> |[optional]|
**IndexValueDelta** | **double?** | <em>change in value of the market index</em><br>change in the <code>index_value</code> at a given <code>timestamp</code> |[optional]|
**Identifier** | **string** | <em>identifier of the element</em><br>full identifier of the element that consists from <code>ticker</code> and <code>market_identifier</code><br>example: <code>PX1:INDEXDB</code> |[optional]|
**DisplayedName** | **string** | <em>name of the market index as displayed on Google Finance</em><br>example: <code>CAC 40</code> |[optional]|
**Url** | **string** | <em>URL to the page of the market index on Google Finance</em> |[optional]|
**Location** | **string** | <em>location of the market index</em><br>example: <code>Europe/Paris</code> |[optional]|
**Trend** | **string** | <em>growth trend of the market index</em><br>possible values: <code>up</code>, <code>down</code>, <code>stable</code> |[optional]|
**Timestamp** | **string** | <em>date and time of the value readout</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code class='long-string'>2025-02-10 09:40:00 +00:00</code> |[optional]|
**PercentageDelta** | **double?** | <em>percentage of change in value of the market index</em> |[optional]|