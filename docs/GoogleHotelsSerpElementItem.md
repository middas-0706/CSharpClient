# GoogleHotelsSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**HotelIdentifier** | **string** | <em>unique hotel identifier</em><br>unique hotel identifier assigned by Google;<br>example: <code>'CgoIjaeSlI6CnNpVEAE'</code> |[optional]|
**Url** | **string** | <i>URL of the third-party review source</i> |[optional]|
**Cid** | **string** | <em>google-defined client id</em> |[optional]|