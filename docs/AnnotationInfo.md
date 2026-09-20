# AnnotationInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>the domain name or title of the quoted source</em> |[optional]|
**Url** | **string** | <em>redirect URL to the quoted source</em><br>contains a Vertex AI redirect that leads to the original source |[optional]|
**DirectUrl** | **string** | <em>direct URL to the quoted source</em><br>contains the original source URL that the Vertex AI redirect in the `url` field leads to |[optional]|
**StartIndex** | **int?** | <em>start of the annotation indexing</em> |[optional]|
**EndIndex** | **int?** | <em>end of the annotation indexing</em> |[optional]|
**Text** | **string** | <em>text of the reasoning chain section</em><br>text of the reasoning chain  section summarizing the model's thought process |[optional]|