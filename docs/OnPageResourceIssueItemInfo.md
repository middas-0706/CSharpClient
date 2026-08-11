# OnPageResourceIssueItemInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Line** | **int?** | <em>line where the error was found</em> |[optional]|
**Column** | **int?** | <em>column where the error was found</em> |[optional]|
**Message** | **string** | <em>text message of the error</em><br>the full list of possible HTML errors can be found <a href='https://github.com/AngleSharp/AngleSharp/blob/3968eb050e142b1d94550fba407afe772232b126/src/AngleSharp/Html/Parser/HtmlParseError.cs'>here</a> |[optional]|
**StatusCode** | **int?** | <i>general status code</i><br>you can find the full list of the response codes <a href='/v3/appendix/errors'>here</a><br><strong>Note:</strong> we strongly recommend designing a necessary system for handling related exceptional or error conditions |[optional]|