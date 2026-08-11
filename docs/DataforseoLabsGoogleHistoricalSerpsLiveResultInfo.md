# DataforseoLabsGoogleHistoricalSerpsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type in a POST array</em> |[optional]|
**Keyword** | **string** | <em>keyword received in a POST array</em><br>            <strong>the keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character)</strong> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>the total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveItem>** | <em>historical SERPs and related data found in the database</em> |[optional]|