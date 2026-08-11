# FeaturedSnippetSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em> absolute rank in SERP</em><br>absolute position among all the elements found in SERP<strong>note</strong> values are returned in the ascending order, with values corresponding to advanced SERP features omitted from the results;<br>to get all items (including SERP features and rich snippets) with their positions, please refer to the <a href='https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?php'>Google Organiс Advanced SERP</a> endpoint |[optional]|
**Domain** | **string** | <em>domain of the ad element in SERP</em> |[optional]|
**Title** | **string** | <em>title of the ad element in SERP</em> |[optional]|
**Description** | **string** | <em>description of the ad element in SERP</em> |[optional]|
**Url** | **string** | <em>relevant URL of the ad element in SERP</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb of the ad element in SERP</em> |[optional]|
**FeaturedTitle** | **string** | <em>title</em> |[optional]|
**Timestamp** | **string** | <em>date and time when the result was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the element</em><br>if there are none, equals <code>null</code> |[optional]|
**Table** | **Table** | <em>table present in the element</em><br>the header and content of the table present in the element |[optional]|