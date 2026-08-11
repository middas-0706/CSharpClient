# LocalPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**Title** | **string** | <em>title of the row</em> |[optional]|
**Description** | **string** | <em>description of the link</em> |[optional]|
**Domain** | **string** | <em>domain of the website hosting the video</em> |[optional]|
**Phone** | **string** | <em>phone number</em> |[optional]|
**BookingUrl** | **string** | <em>URL of the booking page</em> |[optional]|
**Url** | **string** | <i>URL of the third-party review source</i> |[optional]|
**IsPaid** | **bool?** | <em>indicates whether the element is an ad</em> |[optional]|
**Rating** | **RatingInfo** | <em>the element's rating</em><br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals <code>null</code> |[optional]|
**Cid** | **string** | <em>google-defined client id</em> |[optional]|