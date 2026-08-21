# DataforseoLabsGoogleKeywordSuggestionsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**SeedKeyword** | **string** | <em>keyword in a POST array</em> |[optional]|
**SeedKeywordData** | **KeywordDataInfo** | <em>keyword data for the seed keyword</em><br>fields in this object are identical to those of the <code>items</code> array |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Offset** | **int?** | <em>current offset value</em> |[optional]|
**OffsetToken** | **string** | <em>offset token for subsequent requests</em><br>you can use the string provided in this field to get the subsequent results of the initial task;<br><strong>note:</strong> <code>offset_token</code> values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<KeywordDataInfo>** | <em>contains keywords and related data</em> |[optional]|