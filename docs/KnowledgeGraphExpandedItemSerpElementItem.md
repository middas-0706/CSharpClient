# KnowledgeGraphExpandedItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**Title** | **string** | <em>title of the row</em> |[optional]|
**DataAttrid** | **string** | <em>google defined data attribute ID</em><br>example:<br><code>action:listen_artist</code> |[optional]|
**ExpandedElement** | **IEnumerable<KnowledgeGraphExpandedElement>** | <em>expanded element</em> |[optional]|