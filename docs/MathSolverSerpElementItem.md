# MathSolverSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values;<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code>;<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP<br>always equals <code>0</code> for <code>desktop</code> |[optional]|
**Title** | **string** | <em>title of the row</em> |[optional]|
**Result** | **string** | <em>solution to the equation</em><br>solution to the mathematical equation specified in the <code>keyword</code> field when setting a task |[optional]|
**Items** | **IEnumerable<MathSolverElement>** | <em>contains arrays of elements available in the list</em> |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>sitelinks</em><br>the links shown below some of Google's search results<br>if there are none, equals <code>null</code> |[optional]|