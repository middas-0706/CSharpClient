# SerpApiGoogleImagesCarouselElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Page** | **int?** |  |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values:<br><code>left</code>, <code>right</code> |[optional]|
**Title** | **string** | <em>title of the element</em> |[optional]|
**Items** | **IEnumerable<SerpApiCarouselElement>** | <em>items of the element</em> |[optional]|
**Rectangle** | **AiModeRectangleInfo** | <em>rectangle parameters</em><br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br><strong>note: </strong>calculate_rectangles parameter is not yet available when setting tasks for this search engine type, that’s why <code>rectangle</code> always equals <code>null</code> |[optional]|