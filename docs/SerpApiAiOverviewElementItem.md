# SerpApiAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the element</em> |[optional]|
**Text** | **string** | <em>additional text of the element in SERP</em> |[optional]|
**Markdown** | **string** | <em>content of the element in markdown format</em> |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>website links featured in the element</em> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the element</em><br>if there is none, equals <code>null</code> |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | <em>references relevant to the element</em><br>includes references to webpages that were used to generate the <code>ai_overview_element</code> |[optional]|