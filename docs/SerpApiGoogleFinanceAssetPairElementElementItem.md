# SerpApiGoogleFinanceAssetPairElementElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**BaseSymbol** | **string** | <em>identifier of the base asset in a pair</em><br>example: <code>EUR</code> |[optional]|
**QuoteSymbol** | **string** | <em>identifier of the quote asset in a pair</em><br>example: <code>USD</code> |[optional]|
**BaseDisplayName** | **string** | <em>full name of the base asset in a pair</em><br>example: <code>Euro</code> |[optional]|
**QuoteDisplayName** | **string** | <em>full name of the base asset in a pair</em><br>example: <code>Euro</code> |[optional]|
**Price** | **double?** | <em>value of the base asset compared to the quote asset</em> |[optional]|
**PriceDelta** | **double?** | <em>change in price</em><br>change in <code>price</code> at a given <code>timestamp</code> |[optional]|
**Identifier** | **string** | <em>identifier of the element</em><br>full identifier of the element that consists from <code>ticker</code> and <code>market_identifier</code><br>example: <code>PX1:INDEXDB</code> |[optional]|
**DisplayedName** | **string** | <em>name of the market index as displayed on Google Finance</em><br>example: <code>CAC 40</code> |[optional]|
**Url** | **string** | <em>URL to the page of the market index on Google Finance</em> |[optional]|
**Location** | **string** | <em>location of the market index</em><br>example: <code>Europe/Paris</code> |[optional]|
**Trend** | **string** | <em>growth trend of the market index</em><br>possible values: <code>up</code>, <code>down</code>, <code>stable</code> |[optional]|
**Timestamp** | **string** | <em>date and time of the value readout</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code class='long-string'>2025-02-10 09:40:00 +00:00</code> |[optional]|
**PercentageDelta** | **double?** | <em>percentage of change in value of the market index</em> |[optional]|