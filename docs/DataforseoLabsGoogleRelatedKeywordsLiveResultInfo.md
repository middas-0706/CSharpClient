# DataforseoLabsGoogleRelatedKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**SeedKeyword** | **string** | <em>keyword in a POST array</em> |[optional]|
**SeedKeywordData** | **KeywordDataInfo** | <em>keyword data for the seed keyword</em><br>fields in the array are identical to that of <code>keyword_data</code> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<DataforseoLabsGoogleRelatedKeywordsLiveItem>** | <em>contains keywords and related data</em> |[optional]|