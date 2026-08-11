# HotelsPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**Title** | **string** | <em>title of the row</em> |[optional]|
**DateFrom** | **string** | <em>starting date of stay</em><br>in the format 'year-month-date'<br>example:<br>2019-11-15 |[optional]|
**DateTo** | **string** | <em>ending date of stay</em><br>in the format 'year-month-date'<br>example:<br>2019-11-17 |[optional]|
**Items** | **IEnumerable<HotelsPackElement>** | <em>contains arrays of elements available in the list</em> |[optional]|