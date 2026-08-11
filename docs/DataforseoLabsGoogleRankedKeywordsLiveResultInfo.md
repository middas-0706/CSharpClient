# DataforseoLabsGoogleRankedKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Target** | **string** | <em>target domain or webpage in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em><br>            if there is no data, then the value is <code>null</code> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em><br>            if there is no data, then the value is <code>null</code> |[optional]|
**TotalCount** | **long?** | <em>total number of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Metrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | <em>ranking data relevant to the specified domain or webpage </em><br>            ranking data is provided by the <code>rank_group</code> parameters that show the result’s rank considering only equivalent SERP elements |[optional]|
**MetricsAbsolute** | **IDictionary<string, DataforseoLabsMetricsInfo>** | <em>ranking data relevant to the specified domain or webpage</em><br>            ranking data is provided by the <code>rank_absolute</code> parameters that indicate the result’s position among all SERP elements |[optional]|
**Items** | **IEnumerable<DataforseoLabsGoogleRankedKeywordsLiveItem>** | <em>contains ranked keywords and related data</em> |[optional]|