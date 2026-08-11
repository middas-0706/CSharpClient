# SerpApiKnowledgeGraphHotelsBookingItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | <em>title of a given link element</em> |[optional]|
**DateFrom** | **string** | <em>starting date of stay</em><br>in the format “year-month-date”<br>example:<br>2019-11-15 |[optional]|
**DateTo** | **string** | <em>ending date of stay</em><br>in the format “year-month-date”<br>example:<br>2019-11-17 |[optional]|
**DataAttrid** | **string** | <em>google defined data attribute ID</em><br>example:<br><code>kc:/local:hotel booking</code> |[optional]|
**Items** | **IEnumerable<KnowledgeGraphHotelsBookingElement>** | <em>popular keywords relevant to the initial search query</em><br>if there are none, equals <code>null</code> |[optional]|