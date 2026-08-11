# PageTiming


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TimeToInteractive** | **int?** | <em><a href='https://web.dev/interactive/'>Time To Interactive (TTI)</a> metric</em><br>the time it takes until the user can interact with a page (in milliseconds) |[optional]|
**DomComplete** | **int?** | <em>time to load resources</em><br>the time it takes until the page and all of its subresources are downloaded (in milliseconds) |[optional]|
**LargestContentfulPaint** | **double?** | <em>Core Web Vitals metric measuring how fast the largest above-the-fold content element is displayed</em><br>The amount of time (in milliseconds) to render the largest content element visible in the viewport, from when the user requests the URL. <a href='https://web.dev/lcp/'>Learn more</a>. |[optional]|
**FirstInputDelay** | **double?** | <em>Core Web Vitals metric indicating the responsiveness of a page</em><br>The time (in milliseconds) from when a user first interacts with your page to the time when the browser responds to that interaction. <a href='https://web.dev/fid/'>Learn more</a>. |[optional]|
**ConnectionTime** | **int?** | <em>time to connect to a server</em><br>the time it takes until the connection with a server is established (in milliseconds) |[optional]|
**TimeToSecureConnection** | **int?** | <em>time to establish a secure connection</em><br>the time it takes until the secure connection with a server is established (in milliseconds) |[optional]|
**RequestSentTime** | **int?** | <em>time to send a request to a server</em><br>the time it takes until the request to a server is sent (in milliseconds) |[optional]|
**WaitingTime** | **int?** | <em>time to first byte <a href='https://en.wikipedia.org/wiki/Time_to_first_byte'>(TTFB)</a> in milliseconds</em> |[optional]|
**DownloadTime** | **int?** | <em>time it takes for a browser to receive a response (in milliseconds)</em> |[optional]|
**DurationTime** | **int?** | <em>total time it takes until a browser receives a complete response from a server (in milliseconds)</em> |[optional]|
**FetchStart** | **int?** | <em>time to start downloading the HTML resource</em><br>the amount of time the browser needs to start downloading a page |[optional]|
**FetchEnd** | **int?** | <em>time to complete downloading the HTML resource</em><br>the amount of time the browser needs to complete downloading a page |[optional]|