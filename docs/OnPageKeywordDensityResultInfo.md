# OnPageKeywordDensityResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | <em>status of the crawling session</em><br>possible values: <code>in_progress</code>, <code>finished</code> |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | <em>details of the crawling session</em> |[optional]|
**TotalItemsCount** | **long?** | <em>total number of relevant items</em><br>total number of keywords on the specified website or web page matching the set <code>keyword_length</code> and <code>filters</code> |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**Items** | **IEnumerable<OnPageKeywordDensityItem>** | <em>items array</em> |[optional]|