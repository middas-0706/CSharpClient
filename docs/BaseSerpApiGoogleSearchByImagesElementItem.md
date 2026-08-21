# BaseSerpApiGoogleSearchByImagesElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>            position within a group of elements with identical <code>type</code> values<br>            positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>            absolute position among all the elements in SERP |[optional]|
**Page** | **int?** |  |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>            can take the following values:<br>            <code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath' rel='noopener noreferrer' target='_blank'>XPath</a> of the element</em> |[optional]|
**Title** | **string** | <em>title of the element</em> |[optional]|
**Url** | **string** | <em>search URL with refinement parameters</em> |[optional]|
**Rectangle** | **AiModeRectangleInfo** | <em>rectangle parameters</em><br>            contains cartesian coordinates and pixel dimensions of the result's snippet in SERP<br>            equals <code>null</code> if <code>calculate_rectangles</code> in the POST request is not set to <code>true</code> |[optional]|