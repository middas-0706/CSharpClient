# KeywordsDataDataforseoTrendsLocationsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | <em>location code</em> |[optional]|
**LocationName** | **string** | <em>full name of the location</em> |[optional]|
**LocationCodeParent** | **int?** | <em>the code of the superordinate location</em><br>example:<br><code>'location_code': 9041134,<br>'location_name': 'Vienna International Airport,Lower Austria,Austria',<br>'location_code_parent': 20044</code><br>where <code>location_code_parent</code> corresponds to:<br><code>'location_code': 20044,<br>'location_name': 'Lower Austria,Austria'</code> |[optional]|
**CountryIsoCode** | **string** | <em>ISO country code of the location</em> |[optional]|
**LocationType** | **string** | <em>location type</em><br>possible values according to <a href='https://developers.google.com/adwords/api/docs/appendix/geotargeting' target='_blank' rel='noopener noreferrer'>Google’s target types</a> |[optional]|
**GeoId** | **string** | <em>DataForSEO trends location identifier</em><br>you can use this field for matching obtained results with the <code>location_code</code> parameter specified in the request |[optional]|