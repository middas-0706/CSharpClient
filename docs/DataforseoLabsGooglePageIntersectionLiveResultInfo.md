# DataforseoLabsGooglePageIntersectionLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Pages** | **IDictionary<string, string>** | <em>URLs you specified a POST array</em> |[optional]|
**ExcludePages** | **IEnumerable<string>** | <em>URLs you specified in a POST array that will be excluded from the results</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<DataforseoLabsGooglePageIntersectionLiveItem>** | <em>contains keywords, relevant SERP elements and related data</em> |[optional]|