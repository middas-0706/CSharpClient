# DataLabsMathSolverSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Result** | **string** | <em>solution to the equation</em><br>            solution to the mathematical equation specified in the <code>keyword</code> field when setting a task |[optional]|
**Items** | **IEnumerable<MathSolverElement>** | <em>historical SERPs and related data found in the database</em> |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>sitelinks</em><br>            the links shown below some of Google's search results<br>            if there are none, equals <code>null</code> |[optional]|