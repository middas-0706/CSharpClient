# SerpSeznamOrganicTaskGetRegularResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array</em><br><strong>keyword is returned with decoded %## (plus symbol '+' will be decoded to a space character)</strong> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Spell** | **SpellInfo** | <em>autocorrection of the search engine</em><br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**RefinementChips** | **RefinementChipsInfo** | <em>search refinement chips</em><br>equals <code>null</code> |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results found in SERP</em><br>contains types of all search results (<code>items</code>) found in the returned SERP<br>possible item types:<br><code>images</code>, <code>local_pack</code>, <code>organic</code>, <code>related_searches</code>, <code>top_stories</code>, <code>featured_snippet</code>, <code>video</code><p>note that this array contains all types of search results found in the returned SERP;<br>however, <strong>this endpoint provides data for the <code>organic</code> type only</strong><p>to get all items (inlcuding SERP features and rich snippets) found in the returned SERP, please refer to the <a href='/v3/serp/seznam/organic/task_get/advanced'>Seznam Organiс Advanced SERP endpoint</a> |[optional]|
**SeResultsCount** | **long?** | <em>total number of results in SERP</em> |[optional]|
**PagesCount** | **long?** | <em>total pages retrieved</em><br>total number of retrieved SERPs in the result |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<BaseSerpApiElementItem>** | <em>items in SERP</em> |[optional]|