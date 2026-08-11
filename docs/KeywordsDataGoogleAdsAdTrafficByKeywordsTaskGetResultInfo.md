# KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword in a POST array</em><br>metrics are provided for all the keywords specified in the POST array |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**DateInterval** | **string** | <em>forecasting date interval in a POST array</em> |[optional]|
**SearchPartners** | **bool?** | <em>include Google search partners</em><br>the value is always <code>false</code> |[optional]|
**Bid** | **double?** | <em>the maximum custom bid</em><br>the bid you have specified when setting the task<br>represents the price you are willing to pay for an ad<br>the higher value you have specified, the higher metrics and cost you receive in response<br>learn more in <a href='https://dataforseo.com/help-center/configuring-bid'>this help center article</a> |[optional]|
**Match** | **string** | <em>keywords match-type</em><br>can take the following values: <code>exact</code>, <code>broad</code>, <code>phrase</code> |[optional]|
**Impressions** | **int?** | <em>projected number of ad impressions</em><br>number of impressions an ad is projected to get within the specified time period<br><strong>Note:</strong> parameter deprecated, the value is always_<code>null</code>n |[optional]|
**Ctr** | **double?** | <em>projected clickthrough rate (CTR) of the advertisement</em><br>number of clicks an ad is projected to receive divided by the number of ad impressions;<br><strong>Note:</strong> parameter deprecated, the value is always <code>null</code> |[optional]|
**AverageCpc** | **double?** | <em>the average cost-per-click value</em><br>represents the cost-per-click (USD) estimated for a keyword based on the specified time period and historical data;<br>if there is no data, then the value is_<code>null</code>n |[optional]|
**Cost** | **double?** | <em>charge for an ad</em><br>amount that will be charged for running an ad within the specified time period<br>if there is no data, then the value is_<code>null</code>n |[optional]|
**Clicks** | **double?** | <em>number of clicks on an ad</em><br>number of clicks an ad is projected to get within the specified time period<br>if there is no data, then the value is_<code>null</code>n |[optional]|