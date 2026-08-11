# OnPageResourceLocationInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Line** | **int?** | <em>line number</em><br>the number of the line on which the resource is located |[optional]|
**OffsetLeft** | **int?** | <em>position in line</em><br>the number of line characters before the resource;<br>sometimes referred to as <em>column</em><br><strong>Note:</strong> counts from 1, i.e. if the resource doesn't have any characters to the left, the value will be 1 |[optional]|
**OffsetTop** | **int?** | <em>position in the document</em><br>the total number of characters between the resource and the top of HTML |[optional]|