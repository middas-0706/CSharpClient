# SerpApiGoogleFinanceFuturesChainElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Markets** | **IEnumerable<GoogleFinanceFuturesChainElement>** | <em>financial markets data</em><br>array of items containing market indexes and other financial information related to these indexes |[optional]|