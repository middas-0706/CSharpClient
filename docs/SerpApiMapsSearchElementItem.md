# SerpApiMapsSearchElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**OriginalTitle** | **string** | <em>original title of the element</em><br>original title not translated by Google |[optional]|
**ContactUrl** | **string** | <em>URL of the preferred contact page</em> |[optional]|
**ContributorUrl** | **string** | <em>URL of the user's or entity's Local Guides profile, if available</em> |[optional]|
**BookOnlineUrl** | **string** | <em>URL in the 'book online' button of the element</em><br>URL directing users to the online booking or order page of the business entity |[optional]|
**HotelRating** | **double?** | <em>hotel class rating</em><br>class ratings range between 1-5 stars, <a href='https://support.google.com/business/answer/7660515?hl=en' rel='noopener noreferrer' target='_blank'>learn more</a><br>if there is no hotel class rating information, the value will be <code>null</code> |[optional]|
**PriceLevel** | **string** | <em>property price level</em><br>can take values: <code>inexpensive</code>, <code>moderate</code>, <code>expensive</code>, <code>very_expensive</code><br>if there is no price level information, the value will be <code>null</code> |[optional]|
**Snippet** | **string** | <em>element snippet</em><br>contains the address and other information about the local establishment featured in the element |[optional]|
**Address** | **string** | <em>address line</em><br>address of the local establishment featured in the element |[optional]|
**AddressInfo** | **AddressInfo** | <em>object containing address components of the local establishment</em> |[optional]|
**PlaceId** | **string** | <em>unique place identifier</em><br><a href='https://developers.google.com/places/place-id'>place id</a> of the local establishment featured in the element |[optional]|
**Phone** | **string** | <em>phone number</em><br>phone number of the local establishment featured in the element |[optional]|
**MainImage** | **string** | <em>URL of the main image featured in Google My Business profile</em> |[optional]|
**TotalPhotos** | **long?** | <em>total count of images featured in Google My Business profile</em> |[optional]|
**Category** | **string** | <em>business category</em><br>Google My Business general category that best describes the services provided by the business entity |[optional]|
**AdditionalCategories** | **IEnumerable<string>** | <em>additional business categories</em><br>additional Google My Business categories that describe the services provided by the business entity in more detail |[optional]|
**CategoryIds** | **IEnumerable<string>** | <em>global category IDs</em><br>universal category IDs that do not change based on the selected country |[optional]|
**WorkHours** | **WorkHours** | <em>open hours</em><br>information about work hours of the local establishment |[optional]|
**FeatureId** | **string** | <em>the unique identifier of the element in SERP</em> |[optional]|
**Cid** | **string** | <i>google-defined client id</i><br>unique id of a local establishment;<br>can be used with <a href='/v3/reviews/google/overview/?php' rel='noopener noreferrer' target='_blank'>Google Reviews API</a> to get a full list of reviews |[optional]|
**Latitude** | **double?** | <i>latitude coordinate of the local establishments in google maps</i><br>example:<br><code>'latitude': 51.584091</code> |[optional]|
**Longitude** | **double?** | <i>longitude coordinate of the local establishment in google maps</i><br>example:<br><code>'longitude': -0.31365919999999997</code> |[optional]|
**IsClaimed** | **bool?** | <i>indicates whether ownership of this local establishment is claimed</i> |[optional]|
**LocalJustifications** | **IEnumerable<LocalJustificationInfo>** | <i>Google local justifications</i><br>snippets of text that 'justify' why the business is showing up for search query |[optional]|
**IsDirectoryItem** | **bool?** | <i>indicates whether this local establishment is a directory </i> |[optional]|