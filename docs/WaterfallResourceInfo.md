# WaterfallResourceInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ResourceType** | **string** |  |[optional]|
**Url** | **string** | <em>resource URL</em> |[optional]|
**Initiator** | **string** | <em>resource initiator</em> |[optional]|
**DurationTime** | **int?** | <em>total time it takes until a browser receives a complete response from a server (in milliseconds)</em> |[optional]|
**FetchStart** | **int?** | <em>time to start downloading the HTML resource</em><br>the amount of time the browser needs to start downloading a page |[optional]|
**FetchEnd** | **int?** | <em>time to complete downloading the HTML resource</em><br>the amount of time the browser needs to complete downloading a page |[optional]|
**Location** | **OnPageResourceLocationInfo** | <em>location of the resource in the document</em><br>parameters defining the location of the specific resource within the document's HTML |[optional]|
**IsRenderBlocking** | **bool?** | <em>indicates whether the resource blocks rendering</em> |[optional]|