# GoogleReviewsSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**ReviewsCount** | **long?** | <i>the number of reviews</i> |[optional]|
**Rating** | **RatingInfo** | <em>the element's rating</em><br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals <code>null</code> |[optional]|
**PlaceId** | **string** | <em>the identifier of a place</em> |[optional]|
**Feature** | **string** | <i>the additional feature of the review</i> |[optional]|
**Cid** | **string** | <em>google-defined client id</em> |[optional]|