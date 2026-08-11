# KnowledgeGraphSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Subtitle** | **string** | <em>subtitle of the item</em> |[optional]|
**Description** | **string** | <em>description of the results element in SERP</em> |[optional]|
**CardId** | **string** | <em>card id</em> |[optional]|
**Url** | **string** | <em> relevant URL in SERP</em> |[optional]|
**ImageUrl** | **string** | <em>URL of the image</em><br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**LogoUrl** | **string** | <em>URL of the logo from knowledge graph</em> |[optional]|
**Cid** | **string** | <em>google-defined client id</em><br>unique id of a local establishment;<br>can be used with <a href='/v3/reviews/google/overview/?php' target='_blank' rel='noopener noreferrer'>Google Reviews API</a> to get a full list of reviews |[optional]|
**Items** | **IEnumerable<BaseSerpApiKnowledgeGraphElementItem>** | <em>additional items present in the element</em><br>if there are none, equals <code>null</code> |[optional]|