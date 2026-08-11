# BaseOnPageResourceItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ResourceType** | **string** | <em>type of the returned resource = <strong>'html'</strong></em> |[optional]|
**StatusCode** | **int?** | <i>general status code</i><br>you can find the full list of the response codes <a href='/v3/appendix/errors'>here</a><br><strong>Note:</strong> we strongly recommend designing a necessary system for handling related exceptional or error conditions |[optional]|
**Location** | **string** | <em>location header</em><br>indicates the URL to redirect a page to |[optional]|
**Url** | **string** | <em>page URL</em> |[optional]|
**ResourceErrors** | **OnPageResourceIssueInfo** | <em>resource errors and warnings</em> |[optional]|
**Size** | **int?** | <em>resource size</em><br>indicates the size of a given page measured in bytes |[optional]|
**EncodedSize** | **int?** | <em>page size after encoding</em><br>indicates the size of the encoded page measured in bytes |[optional]|
**TotalTransferSize** | **long?** | <em>compressed page size</em><br>indicates the compressed size of a given page |[optional]|
**FetchTime** | **string** | <em>date and time when a resource was fetched</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**CacheControl** | **CacheControl** | <em>instructions for caching</em> |[optional]|
**Checks** | **IDictionary<string, bool?>** | <em>website checks</em><br>on-page check-ups related to the page |[optional]|
**ContentEncoding** | **string** | <em>type of encoding</em> |[optional]|
**MediaType** | **string** | <em>types of media used to display a page</em> |[optional]|
**Server** | **string** | <em>server version</em> |[optional]|
**LastModified** | **LastModified** | <em>contains data on changes related to the resource</em><br>if there is no data, the value will be <code>null</code> |[optional]|