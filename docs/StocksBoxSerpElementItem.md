# StocksBoxSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**Title** | **string** | <em>title of the row</em> |[optional]|
**Source** | **string** | <i>source of the element</i><br>indicates the source of information included in the <code>recipes_element</code> |[optional]|
**Snippet** | **string** | <em>text alongside the link title</em> |[optional]|
**Price** | **PriceInfo** | <em>price indicated in the element</em> |[optional]|
**Url** | **string** | <i>URL of the third-party review source</i> |[optional]|
**Domain** | **string** | <em>domain of the website hosting the video</em> |[optional]|
**Table** | **Table** | <em>table present in the element</em><br>the header and content of the table present in the element |[optional]|
**Graph** | **Graph** | <em>contains data provided in the graph of the element</em> |[optional]|