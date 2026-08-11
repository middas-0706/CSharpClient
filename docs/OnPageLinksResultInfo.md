# OnPageLinksResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | <em>status of the crawling session</em><br>possible values: <code>in_progress</code>, <code>finished</code> |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | <em>details of the crawling session</em> |[optional]|
**SearchAfterToken** | **string** |  |[optional]|
**CurrentOffset** | **int?** |  |[optional]|
**TotalItemsCount** | **long?** | <em>total number of relevant items in the database</em> |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**Items** | **IEnumerable<BaseOnPageLinkItem>** | <em>items array</em> |[optional]|