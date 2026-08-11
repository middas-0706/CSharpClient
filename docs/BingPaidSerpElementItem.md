# BingPaidSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | <em>domain of the ad element in SERP</em> |[optional]|
**Title** | **string** | <em>title of the ad element in SERP</em> |[optional]|
**Description** | **string** | <em>description of the ad element in SERP</em> |[optional]|
**Url** | **string** | <em>relevant URL of the ad element in SERP</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb of the ad element in SERP</em> |[optional]|
**WebsiteName** | **string** | <em>website name in SERP</em> |[optional]|
**IsImage** | **bool?** | <em>indicates whether the element contains an <code class='prettyprint'>image</code></em> |[optional]|
**IsVideo** | **bool?** | <em>indicates whether the element contains a <code class='prettyprint'>video</code></em> |[optional]|
**Checks** | **IEnumerable<string>** |  |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the element</em><br>            if there are none, equals <code>null</code> |[optional]|
**Highlighted** | **IEnumerable<string>** | <em>words highlighted in bold within the results <code>description</code></em> |[optional]|
**Extra** | **IDictionary<string, string>** | <em>additional information about the result</em> |[optional]|
**DescriptionRows** | **IEnumerable<string>** | <em>extended description</em><br>            if there is none, equals <code>null</code> |[optional]|
**Links** | **IEnumerable<AdLinkElement>** | <em>links featured in the organic result</em> |[optional]|
**Price** | **PriceInfo** | <em>price of booking a place for the specified dates of stay</em> |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>            the popularity rate based on reviews and displayed in SERP |[optional]|