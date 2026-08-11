# KnowledgeGraphAiOverviewItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AsynchronousAiOverview** | **bool?** | <em>indicates whether the element is loaded asynchronously</em><br>if <code>true</code>, the <code>ai_overview</code> element is loaded asynchronously;<br>if <code>false</code>, the <code>ai_overview</code> element is loaded from cache |[optional]|
**Items** | **IEnumerable<BaseSerpApiAiOverviewElementItem>** | <em>contains arrays of elements available in the list</em> |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | <em>references relevant to the element</em><br>includes references to webpages that were used to generate the <code>ai_overview_element</code> |[optional]|