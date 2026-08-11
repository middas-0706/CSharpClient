# SerpApiKnowledgeGraphExpandedItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**DataAttrid** | **string** | <em>google defined data attribute ID</em><br>example:<br><code>kc:/local:place qa</code> |[optional]|
**ExpandedElement** | **IEnumerable<KnowledgeGraphExpandedElement>** | <em>link of the element</em> |[optional]|