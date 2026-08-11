# KnowledgeGraphExpandedElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**FeaturedTitle** | **string** | <em>title of a given element</em> |[optional]|
**Url** | **string** | <em>relevant URL </em> |[optional]|
**Domain** | **string** | <em>domain where a link points</em> |[optional]|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Snippet** | **string** | <em>text alongside the link title</em> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the element</em><br>if there are none, equals <code>null</code> |[optional]|
**Timestamp** | **string** | <em>date and time when the result was published</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Table** | **Table** | <em>table present in the element</em><br>the header and content of the table present in the element |[optional]|