# DataLabsImagesSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Url** | **string** | <em> relevant URL in SERP</em> |[optional]|
**Items** | **IEnumerable<AiModeImagesElementInfo>** | <em>historical SERPs and related data found in the database</em> |[optional]|
**RelatedImageSearches** | **RelatedImageSearchesElement** | <em>contains keywords and images related to the specified search term</em><br>            if there are none, equals <code>null</code> |[optional]|