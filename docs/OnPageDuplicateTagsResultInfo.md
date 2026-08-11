# OnPageDuplicateTagsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | <em>status of the crawling session</em><br>possible values: <code>in_progress</code>, <code>finished</code> |[optional]|
**CrawlStatus** | **CrawlStatusInfo** | <em>details of the crawling session</em> |[optional]|
**TotalPagesCount** | **long?** | <em>total number of pages with duplicate tags</em><br>displays the total number of pages with duplicate tags of the target website |[optional]|
**PagesCount** | **long?** | <em>number of pages with duplicate tags in the response</em><br>displays the number of pages with duplicate tags returned in the response |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**Items** | **IEnumerable<OnPageDuplicateTagsItem>** | <em>items array</em> |[optional]|