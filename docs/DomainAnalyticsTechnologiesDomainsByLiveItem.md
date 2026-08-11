# DomainAnalyticsTechnologiesDomainsByLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Domain** | **string** | <em>specified domain name</em> |[optional]|
**Title** | **string** | <em>domain meta title</em> |[optional]|
**Description** | **string** | <em>domain meta description</em> |[optional]|
**MetaKeywords** | **IEnumerable<string>** | <em>domain meta keywords</em> |[optional]|
**DomainRank** | **int?** | <em>backlink rank of the target domain</em><br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**LastVisited** | **string** | <em>most recent date when our crawler visited the domain</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2022-10-10 12:57:46 +00:00</code> |[optional]|
**CountryIsoCode** | **string** | <em>domain ISO code</em><br>ISO code of the country that target domain is determined to belong to |[optional]|
**LanguageCode** | **string** | <em>domain language</em><br>code of the language that target domain is determined to be associated with |[optional]|
**ContentLanguageCode** | **string** | <em>content language</em><br>code of the language that content on the target domain is written with |[optional]|
**PhoneNumbers** | **IEnumerable<string>** | <em>phone numbers of the target</em><br>contact phone numbers indicated on the target website |[optional]|
**Emails** | **IEnumerable<string>** | <em>emails of the target</em><br>emails indicated on the target website |[optional]|
**SocialGraphUrls** | **IEnumerable<string>** | <em>social media links and handles</em><br>social media URLs detected in the social graphs of the target website |[optional]|
**Technologies** | **TechnologiesInfo** | <em>technologies used by target domain</em><br>contains objects with the names of technologies used on the website;<br>to get a full list of technologies and their structure, refer to the <a href='/v3/domain_analytics/technologies/technologies/'>technologies endpoint</a> |[optional]|