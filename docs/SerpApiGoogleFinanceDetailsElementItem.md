# SerpApiGoogleFinanceDetailsElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Badges** | **IEnumerable<string>** | <em>google finance badges relevant to the element</em><br>example: <code>Futures Contract</code> |[optional]|
**PreviousClose** | **double?** | <em>value of the previous close</em> |[optional]|
**StartDayRange** | **double?** | <em>value of the start day range</em> |[optional]|
**EndDayRange** | **double?** | <em>value of the end day range</em> |[optional]|
**StartYearRange** | **double?** | <em>value of the start year range</em> |[optional]|
**EndYearRange** | **double?** | <em>value of the end year range</em> |[optional]|
**MarketCap** | **double?** | <em>market cap value</em> |[optional]|
**Volume** | **double?** | <em>total volume value</em> |[optional]|
**AvgVolume** | **double?** | <em>average volume value</em> |[optional]|
**PeRatio** | **double?** | <em>price-earnings ratio</em> |[optional]|
**DividendYield** | **double?** | <em>dividend yield value</em> |[optional]|
**PrimaryExchange** | **string** | <em>primary exchange value</em> |[optional]|
**YtdReturn** | **double?** | <em>year-to-date return value</em> |[optional]|
**ExpenseRatio** | **double?** | <em>expense ratio value</em> |[optional]|
**Category** | **string** | <em>category name</em> |[optional]|
**NetAssets** | **double?** |  |[optional]|
**Yield** | **double?** | <em>yield value</em> |[optional]|
**FrontLoad** | **double?** | <em>front load value</em> |[optional]|
**MarketSegment** | **string** | <em>name of the relevant market segment</em> |[optional]|
**OpenInterest** | **double?** | <em>open interest value</em> |[optional]|
**SettlementPrice** | **double?** | <em>settlement price value</em> |[optional]|
**CdpClimateChangeScore** | **string** | <em>climate change score by carbon disclosure project methodology</em> |[optional]|
**MetricsCurrency** | **string** | <em>currency of the metrics</em> |[optional]|