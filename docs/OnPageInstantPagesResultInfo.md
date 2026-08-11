# OnPageInstantPagesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**CrawlProgress** | **string** | <em>status of the crawling session</em><br>possible values: <code>in_progress</code>, <code>finished</code> |[optional]|
**CrawlStatus** | **object** | <em>details of the crawling session</em><br>in this case the value will be <code>null</code> |[optional]|
**CrawlGatewayAddress** | **string** | <em>crawler ip address</em><br>displays the IP address used by the crawler to initiate the current crawling session<br>you can find the full list of IPs used by our crawler in the <a href='/v3/on_page/overview' target='_blank' rel='noopener noreferrer'>Overview section</a> |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**Items** | **IEnumerable<BaseOnPageResourceItem>** | <em>items array</em> |[optional]|