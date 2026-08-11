# BaseKeywordDataGoogleTrendsItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Position** | **int?** | <em>the alignment of the element in Google Trends</em><br>can take the following values: <code>1</code>, <code>2</code>, <code>3</code>, <code>4</code>, etc. |[optional]|
**Title** | **string** | <em>title of the element in Google Trends</em> |[optional]|
**Keywords** | **IEnumerable<string>** | <em>relevant keywords</em><br>the data included in the <code>google_trends_graph</code> element is based on the keywords listed in this array |[optional]|