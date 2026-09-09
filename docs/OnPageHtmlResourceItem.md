# OnPageHtmlResourceItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Meta** | **PageMetaInfo** | page propertiesthe value depends on the resource_type |[optional]|
**PageTiming** | **PageTiming** | object of page load metrics |[optional]|
**OnpageScore** | **double?** | shows how page is optimized on a 100-point scalethis field shows how page is optimized considering critical on-page issues and warnings detected;100 is the highest possible score that means the page does not have any critical on-page issues and important warnings;learn more about how the metric is calculated in this help center article |[optional]|
**TotalDomSize** | **long?** | total DOM size of a page |[optional]|
**CustomJsResponse** | **object** | the result of executing a specified JS scriptnote that you should specify a custom_js field when setting a task to receive this data and the field type and its value will totally depend on the script you specified;you can also filter the results by this value specifying filters in the following way:['custom_js_response.url', 'like', 'pixel'] |[optional]|
**CustomJsClientException** | **string** | error when executing a custom jsif the error occurred when executing the script you specified in the custom_js field, the error message would be displayed here |[optional]|
**BrokenResources** | **bool?** | indicates whether a page contains broken resources |[optional]|
**BrokenLinks** | **bool?** | indicates whether a page contains broken links |[optional]|
**DuplicateTitle** | **bool?** | indicates whether a page has duplicate title tags |[optional]|
**DuplicateDescription** | **bool?** | indicates whether a page has a duplicate description |[optional]|
**DuplicateContent** | **bool?** | indicates whether a page has duplicate content |[optional]|
**ClickDepth** | **int?** | number of clicks it takes to get to the pageindicates the number of clicks from the homepage needed before landing at the target page |[optional]|
**IsResource** | **bool?** | indicates whether a page is a single resource |[optional]|
**UrlLength** | **int?** | page URL length in characters |[optional]|
**RelativeUrlLength** | **int?** | relative URL length in characters |[optional]|