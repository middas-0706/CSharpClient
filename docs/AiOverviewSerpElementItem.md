# AiOverviewSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**AsynchronousAiOverview** | **bool?** | <em>indicates whether the element is loaded asynchronously</em><br>if <code>true</code>, the <code>ai_overview</code> element is loaded asynchronously;<br>if <code>false</code>, the <code>ai_overview</code> element is loaded from cache;<br>to obtain the content of <code>ai_overview</code> elements, use the <code>load_async_ai_overview</code> parameter in the POST request |[optional]|
**Markdown** | **string** | <em>content of the element in markdown format</em><br>the text of the <code>ai_overview</code> formatted in the <a href='https://en.wikipedia.org/wiki/Markdown' target='_blank'>markdown markup language</a> |[optional]|
**Items** | **IEnumerable<BaseSerpApiAiOverviewElementItem>** | <em>contains arrays of elements available in the list</em> |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | <em>references relevant to the element</em><br>includes references to webpages that were used to generate the <code>ai_overview_element</code> |[optional]|