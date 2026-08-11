# SerpApiBingAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>            can take the following values:<br>            <code>left</code>, <code>right</code> |[optional]|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Text** | **string** | <em>text or description of the element in SERP</em> |[optional]|
**Markdown** | **string** | <em>content of the element in markdown format</em> |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>sitelinks</em><br>            the links shown below some search results<br>            if there are none, equals <code>null</code> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the element</em> |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | <em>references relevant to the element</em><br>            includes references to webpages that were used to generate the <code>ai_overview_element</code> |[optional]|