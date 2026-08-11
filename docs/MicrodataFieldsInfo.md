# MicrodataFieldsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Name** | **string** | <em>field name</em><br>name of the data field |[optional]|
**Types** | **IEnumerable<string>** | list of microdata types |[optional]|
**Value** | **string** | microdata value<br>microdata value specified on a target web page |[optional]|
**TestResults** | **MessageInfo** | <em>microdata validation test results</em><br>sub-type microdata test results that contain detected errors and related messages |[optional]|
**Fields** | **IEnumerable<MicrodataFieldsInfo>** | <em>microdata fields</em><br>an array of objects containing data fields related to the certain microdata type |[optional]|