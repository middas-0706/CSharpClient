# DictionarySerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br><br>            position within a group of elements with identical <code>type</code> values<br><br>            positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br><br>            absolute position among all the elements in SERP |[optional]|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Url** | **string** | <em> relevant URL of the Ad element in SERP</em> |[optional]|
**Domain** | **string** | <em>domain in SERP</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb of the Ad element in SERP</em> |[optional]|
**Keyword** | **string** | <em>keyword highlighted in the result</em> |[optional]|
**Snippet** | **string** | <em>snippet of the element</em> |[optional]|
**Text** | **string** | <em>description of the results element in SERP</em> |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>sitelinks</em><br><br>            the links shown below some of search results<br><br>            if there are none, equals <code>null</code> |[optional]|