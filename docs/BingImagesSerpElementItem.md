# BingImagesSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the item</em> |[optional]|
**Url** | **string** | <em>URL</em> |[optional]|
**Items** | **IEnumerable<AiModeImagesElementInfo>** | <em>contains results featured in the 'hotels_pack' element of SERP</em> |[optional]|
**RelatedImageSearches** | **IEnumerable<RelatedImageSearchesElement>** | <em>contains keywords and images related to the specified search term</em><br>            if there are none, equals <code>null</code> |[optional]|