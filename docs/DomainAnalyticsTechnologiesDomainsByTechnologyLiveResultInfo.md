# DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total number of relevant items in the database</em> |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**Offset** | **int?** | <em>specified offset value</em> |[optional]|
**OffsetToken** | **string** | <em>token for subsequent requests</em><br>by specifying the unique <code>offset_token</code> when setting a new task, you will get the subsequent results of the initial task;<br><code>offset_token</code> values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<DomainAnalyticsTechnologiesDomainsByLiveItem>** | <em>items array</em> |[optional]|