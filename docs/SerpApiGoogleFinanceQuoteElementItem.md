# SerpApiGoogleFinanceQuoteElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Quote** | **BaseSerpApiGoogleFinanceElementItem** | <em>quoted market indexes</em> |[optional]|
**GraphItems** | **IEnumerable<GraphItems>** | <em>values on graph</em> |[optional]|