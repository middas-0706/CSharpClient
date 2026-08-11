# BaseSerpApiKnowledgeGraphElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Page** | **int?** | <em>search results page number</em><br>indicates the number of the SERP page on which the element is located |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values:<br><code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**Rectangle** | **AiModeRectangleInfo** | <em>rectangle parameters</em><br>contains cartesian coordinates and pixel dimensions of the result's snippet in SERP<br>equals <code>null</code> if <code>calculate_rectangles</code> in the POST request is not set to <code>true</code> |[optional]|