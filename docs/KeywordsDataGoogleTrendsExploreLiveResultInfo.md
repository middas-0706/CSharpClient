# KeywordsDataGoogleTrendsExploreLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keywords** | **IEnumerable<string>** | <em>keywords in a POST array</em> |[optional]|
**Type** | **string** | type of element |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**CheckUrl** | **string** | <em>direct URL to the Google Trends results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<BaseKeywordDataGoogleTrendsItem>** | <em>items on the Google Trends page</em> |[optional]|