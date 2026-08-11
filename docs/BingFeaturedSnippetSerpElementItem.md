# BingFeaturedSnippetSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | <em>domain of the ad element in SERP</em> |[optional]|
**Title** | **string** | <em>title of the ad element in SERP</em> |[optional]|
**Description** | **string** | <em>description of the ad element in SERP</em> |[optional]|
**Url** | **string** | <em>relevant URL of the ad element in SERP</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb of the ad element in SERP</em> |[optional]|
**FeaturedTitle** | **string** | <em>the title of the featured snippets source page</em> |[optional]|
**Timestamp** | **string** | <em>date and time when the result was published</em><br>            in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>            example:<br>            <code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the element</em><br>            if there are none, equals <code>null</code> |[optional]|
**Table** | **Table** | <em>results table</em><br>            if there are none, equals <code>null</code> |[optional]|