# SerpApiKnowledgeGraphRowItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | <em>title of the link</em> |[optional]|
**DataAttrid** | **string** | <em>google defined data attribute ID</em><br>example:<br><code>kc:/common/topic:social media presence</code> |[optional]|
**Text** | **string** | <em>reference text</em><br>text snippet from the page that was used to generate the <code>ai_overview_element</code> |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>sitelinks</em><br>the links shown below some of Google's search results<br>if there are none, equals <code>null</code> |[optional]|