# SerpApi

Knowledge base for `dfsClient.SerpApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Search engine results pages (SERP) collected on request: what a search engine shows for a query in a given location, language and device, from engines such as Google, Bing, YouTube, Yahoo and others, including search verticals such as maps, news, images, jobs and AI search modes.

Results are collected at the moment of the request and emulate a real, non-personalized user in the chosen location. They are returned either as parsed, typed elements of the page (organic results, ads, featured snippets, AI answers, local packs, videos and other SERP features) or as raw HTML.

## Use it when you need

- The current ranking of a website, page or product for a keyword in a specific location, language or device (rank tracking).
- The composition of a results page: which SERP features appear and what they contain.
- Fresh results of a search vertical: local businesses on maps, news articles, images, videos, autocomplete suggestions and similar.
- Search results as a raw input for your own processing (parsing, screenshots, summaries).

## Use another API when

- You need keyword metrics such as search volume, CPC or difficulty: `KeywordsDataApi` or `DataforseoLabsApi`.
- You need many keywords or domains at once, historical rankings or the keywords a domain ranks for, without crawling each SERP: `DataforseoLabsApi`.
- You need marketplace product data (Amazon, Google Shopping): `MerchantApi`; app store data: `AppDataApi`; business profiles and reviews: `BusinessDataApi`.
- You need answers of LLM chat assistants rather than search engines: `AiOptimizationApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### GoogleOrganicTaskPostAsync

`POST /v3/serp/google/organic/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicTaskPostAsync(new List<SerpGoogleOrganicTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
    }
});
```

### GoogleOrganicTaskGetAdvancedAsync

`GET /v3/serp/google/organic/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleOrganicTaskGetAdvancedAsync(id);
```

### GoogleOrganicTaskGetHtmlAsync

`GET /v3/serp/google/organic/task_get/html/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleOrganicTaskGetHtmlAsync(id);
```

### GoogleMapsTaskGetAdvancedAsync

`GET /v3/serp/google/maps/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleMapsTaskGetAdvancedAsync(id);
```

### GoogleMapsTaskPostAsync

`POST /v3/serp/google/maps/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleMapsTaskPostAsync(new List<SerpGoogleMapsTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
    }
});
```

### GoogleOrganicTaskGetRegularAsync

`GET /v3/serp/google/organic/task_get/regular/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleOrganicTaskGetRegularAsync(id);
```

### GoogleOrganicLiveAdvancedAsync

`POST /v3/serp/google/organic/live/advanced`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicLiveAdvancedAsync(new List<SerpGoogleOrganicLiveAdvancedRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
        CalculateRectangles = true,
    }
});
```

### GoogleOrganicTasksReadyAsync

`GET /v3/serp/google/organic/tasks_ready`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicTasksReadyAsync();
```

### GoogleAiModeTaskPostAsync

`POST /v3/serp/google/ai_mode/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAiModeTaskPostAsync(new List<SerpGoogleAiModeTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "what is google ai mode",
    }
});
```

## Endpoints

All methods of `SerpApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `IdListAsync` | POST | `/v3/serp/id_list` |
| `ErrorsAsync` | POST | `/v3/serp/errors` |
| `ScreenshotAsync` | POST | `/v3/serp/screenshot` |
| `AiSummaryAsync` | POST | `/v3/serp/ai_summary` |
| `GoogleLocationsAsync` | GET | `/v3/serp/google/locations` |
| `GoogleLocationsCountryAsync` | GET | `/v3/serp/google/locations/{country}` |
| `GoogleLanguagesAsync` | GET | `/v3/serp/google/languages` |
| `GoogleOrganicTaskPostAsync` | POST | `/v3/serp/google/organic/task_post` |
| `GoogleOrganicTasksReadyAsync` | GET | `/v3/serp/google/organic/tasks_ready` |
| `TasksReadyAsync` | GET | `/v3/serp/tasks_ready` |
| `GoogleOrganicTasksFixedAsync` | GET | `/v3/serp/google/organic/tasks_fixed` |
| `GoogleOrganicTaskGetRegularAsync` | GET | `/v3/serp/google/organic/task_get/regular/{id}` |
| `GoogleOrganicTaskGetAdvancedAsync` | GET | `/v3/serp/google/organic/task_get/advanced/{id}` |
| `GoogleOrganicTaskGetHtmlAsync` | GET | `/v3/serp/google/organic/task_get/html/{id}` |
| `GoogleOrganicLiveRegularAsync` | POST | `/v3/serp/google/organic/live/regular` |
| `GoogleOrganicLiveAdvancedAsync` | POST | `/v3/serp/google/organic/live/advanced` |
| `GoogleOrganicLiveHtmlAsync` | POST | `/v3/serp/google/organic/live/html` |
| `GoogleAiModeLanguagesAsync` | GET | `/v3/serp/google/ai_mode/languages` |
| `GoogleAiModeTaskPostAsync` | POST | `/v3/serp/google/ai_mode/task_post` |
| `GoogleAiModeTasksReadyAsync` | GET | `/v3/serp/google/ai_mode/tasks_ready` |
| `GoogleAiModeTasksFixedAsync` | GET | `/v3/serp/google/ai_mode/tasks_fixed` |
| `GoogleAiModeTaskGetAdvancedAsync` | GET | `/v3/serp/google/ai_mode/task_get/advanced/{id}` |
| `GoogleAiModeTaskGetHtmlAsync` | GET | `/v3/serp/google/ai_mode/task_get/html/{id}` |
| `GoogleAiModeLiveAdvancedAsync` | POST | `/v3/serp/google/ai_mode/live/advanced` |
| `GoogleAiModeLiveHtmlAsync` | POST | `/v3/serp/google/ai_mode/live/html` |
| `GoogleMapsTaskPostAsync` | POST | `/v3/serp/google/maps/task_post` |
| `GoogleMapsTasksReadyAsync` | GET | `/v3/serp/google/maps/tasks_ready` |
| `GoogleMapsTasksFixedAsync` | GET | `/v3/serp/google/maps/tasks_fixed` |
| `GoogleMapsTaskGetAdvancedAsync` | GET | `/v3/serp/google/maps/task_get/advanced/{id}` |
| `GoogleMapsLiveAdvancedAsync` | POST | `/v3/serp/google/maps/live/advanced` |
| `GoogleLocalFinderTaskPostAsync` | POST | `/v3/serp/google/local_finder/task_post` |
| `GoogleLocalFinderTasksReadyAsync` | GET | `/v3/serp/google/local_finder/tasks_ready` |
| `GoogleLocalFinderTasksFixedAsync` | GET | `/v3/serp/google/local_finder/tasks_fixed` |
| `GoogleLocalFinderTaskGetAdvancedAsync` | GET | `/v3/serp/google/local_finder/task_get/advanced/{id}` |
| `GoogleLocalFinderTaskGetHtmlAsync` | GET | `/v3/serp/google/local_finder/task_get/html/{id}` |
| `GoogleLocalFinderLiveAdvancedAsync` | POST | `/v3/serp/google/local_finder/live/advanced` |
| `GoogleLocalFinderLiveHtmlAsync` | POST | `/v3/serp/google/local_finder/live/html` |
| `GoogleNewsTaskPostAsync` | POST | `/v3/serp/google/news/task_post` |
| `GoogleNewsTasksReadyAsync` | GET | `/v3/serp/google/news/tasks_ready` |
| `GoogleNewsTasksFixedAsync` | GET | `/v3/serp/google/news/tasks_fixed` |
| `GoogleNewsTaskGetAdvancedAsync` | GET | `/v3/serp/google/news/task_get/advanced/{id}` |
| `GoogleNewsTaskGetHtmlAsync` | GET | `/v3/serp/google/news/task_get/html/{id}` |
| `GoogleNewsLiveAdvancedAsync` | POST | `/v3/serp/google/news/live/advanced` |
| `GoogleNewsLiveHtmlAsync` | POST | `/v3/serp/google/news/live/html` |
| `GoogleImagesTaskPostAsync` | POST | `/v3/serp/google/images/task_post` |
| `GoogleImagesTasksReadyAsync` | GET | `/v3/serp/google/images/tasks_ready` |
| `GoogleImagesTasksFixedAsync` | GET | `/v3/serp/google/images/tasks_fixed` |
| `GoogleImagesTaskGetAdvancedAsync` | GET | `/v3/serp/google/images/task_get/advanced/{id}` |
| `GoogleImagesTaskGetHtmlAsync` | GET | `/v3/serp/google/images/task_get/html/{id}` |
| `GoogleImagesLiveAdvancedAsync` | POST | `/v3/serp/google/images/live/advanced` |
| `GoogleImagesLiveHtmlAsync` | POST | `/v3/serp/google/images/live/html` |
| `GoogleSearchByImageTaskPostAsync` | POST | `/v3/serp/google/search_by_image/task_post` |
| `GoogleSearchByImageTasksReadyAsync` | GET | `/v3/serp/google/search_by_image/tasks_ready` |
| `GoogleSearchByImageTasksFixedAsync` | GET | `/v3/serp/google/search_by_image/tasks_fixed` |
| `GoogleSearchByImageTaskGetAdvancedAsync` | GET | `/v3/serp/google/search_by_image/task_get/advanced/{id}` |
| `GoogleJobsTaskPostAsync` | POST | `/v3/serp/google/jobs/task_post` |
| `GoogleJobsTasksReadyAsync` | GET | `/v3/serp/google/jobs/tasks_ready` |
| `GoogleJobsTasksFixedAsync` | GET | `/v3/serp/google/jobs/tasks_fixed` |
| `GoogleJobsTaskGetAdvancedAsync` | GET | `/v3/serp/google/jobs/task_get/advanced/{id}` |
| `GoogleJobsTaskGetHtmlAsync` | GET | `/v3/serp/google/jobs/task_get/html/{id}` |
| `GoogleAutocompleteTaskPostAsync` | POST | `/v3/serp/google/autocomplete/task_post` |
| `GoogleAutocompleteTasksReadyAsync` | GET | `/v3/serp/google/autocomplete/tasks_ready` |
| `GoogleAutocompleteTasksFixedAsync` | GET | `/v3/serp/google/autocomplete/tasks_fixed` |
| `GoogleAutocompleteTaskGetAdvancedAsync` | GET | `/v3/serp/google/autocomplete/task_get/advanced/{id}` |
| `GoogleAutocompleteLiveAdvancedAsync` | POST | `/v3/serp/google/autocomplete/live/advanced` |
| `GoogleDatasetSearchTaskPostAsync` | POST | `/v3/serp/google/dataset_search/task_post` |
| `GoogleDatasetSearchTasksReadyAsync` | GET | `/v3/serp/google/dataset_search/tasks_ready` |
| `GoogleDatasetSearchTasksFixedAsync` | GET | `/v3/serp/google/dataset_search/tasks_fixed` |
| `GoogleDatasetSearchTaskGetAdvancedAsync` | GET | `/v3/serp/google/dataset_search/task_get/advanced/{id}` |
| `GoogleDatasetSearchLiveAdvancedAsync` | POST | `/v3/serp/google/dataset_search/live/advanced` |
| `GoogleDatasetInfoTaskPostAsync` | POST | `/v3/serp/google/dataset_info/task_post` |
| `GoogleDatasetInfoTasksReadyAsync` | GET | `/v3/serp/google/dataset_info/tasks_ready` |
| `GoogleDatasetInfoTasksFixedAsync` | GET | `/v3/serp/google/dataset_info/tasks_fixed` |
| `GoogleDatasetInfoTaskGetAdvancedAsync` | GET | `/v3/serp/google/dataset_info/task_get/advanced/{id}` |
| `GoogleDatasetInfoLiveAdvancedAsync` | POST | `/v3/serp/google/dataset_info/live/advanced` |
| `GoogleAdsAdvertisersLocationsAsync` | GET | `/v3/serp/google/ads_advertisers/locations` |
| `GoogleAdsAdvertisersTaskPostAsync` | POST | `/v3/serp/google/ads_advertisers/task_post` |
| `GoogleAdsAdvertisersTasksReadyAsync` | GET | `/v3/serp/google/ads_advertisers/tasks_ready` |
| `GoogleAdsAdvertisersTaskGetAdvancedAsync` | GET | `/v3/serp/google/ads_advertisers/task_get/advanced/{id}` |
| `GoogleAdsSearchLocationsAsync` | GET | `/v3/serp/google/ads_search/locations` |
| `GoogleAdsSearchTaskPostAsync` | POST | `/v3/serp/google/ads_search/task_post` |
| `GoogleAdsSearchTasksReadyAsync` | GET | `/v3/serp/google/ads_search/tasks_ready` |
| `GoogleAdsSearchTaskGetAdvancedAsync` | GET | `/v3/serp/google/ads_search/task_get/advanced/{id}` |
| `BingLocationsAsync` | GET | `/v3/serp/bing/locations` |
| `BingLocationsCountryAsync` | GET | `/v3/serp/bing/locations/{country}` |
| `BingLanguagesAsync` | GET | `/v3/serp/bing/languages` |
| `BingOrganicTaskPostAsync` | POST | `/v3/serp/bing/organic/task_post` |
| `BingOrganicTasksReadyAsync` | GET | `/v3/serp/bing/organic/tasks_ready` |
| `BingOrganicTasksFixedAsync` | GET | `/v3/serp/bing/organic/tasks_fixed` |
| `BingOrganicTaskGetRegularAsync` | GET | `/v3/serp/bing/organic/task_get/regular/{id}` |
| `BingOrganicTaskGetAdvancedAsync` | GET | `/v3/serp/bing/organic/task_get/advanced/{id}` |
| `BingOrganicTaskGetHtmlAsync` | GET | `/v3/serp/bing/organic/task_get/html/{id}` |
| `BingOrganicLiveRegularAsync` | POST | `/v3/serp/bing/organic/live/regular` |
| `BingOrganicLiveAdvancedAsync` | POST | `/v3/serp/bing/organic/live/advanced` |
| `BingOrganicLiveHtmlAsync` | POST | `/v3/serp/bing/organic/live/html` |
| `YoutubeLocationsAsync` | GET | `/v3/serp/youtube/locations` |
| `YoutubeLocationsCountryAsync` | GET | `/v3/serp/youtube/locations/{country}` |
| `YoutubeLanguagesAsync` | GET | `/v3/serp/youtube/languages` |
| `YoutubeVideoInfoTaskPostAsync` | POST | `/v3/serp/youtube/video_info/task_post` |
| `YoutubeVideoInfoTasksReadyAsync` | GET | `/v3/serp/youtube/video_info/tasks_ready` |
| `YoutubeVideoInfoTasksFixedAsync` | GET | `/v3/serp/youtube/video_info/tasks_fixed` |
| `YoutubeVideoInfoTaskGetAdvancedAsync` | GET | `/v3/serp/youtube/video_info/task_get/advanced/{id}` |
| `YoutubeVideoInfoLiveAdvancedAsync` | POST | `/v3/serp/youtube/video_info/live/advanced` |
| `YoutubeOrganicTaskPostAsync` | POST | `/v3/serp/youtube/organic/task_post` |
| `YoutubeOrganicTasksReadyAsync` | GET | `/v3/serp/youtube/organic/tasks_ready` |
| `YoutubeOrganicTasksFixedAsync` | GET | `/v3/serp/youtube/organic/tasks_fixed` |
| `YoutubeOrganicTaskGetAdvancedAsync` | GET | `/v3/serp/youtube/organic/task_get/advanced/{id}` |
| `YoutubeOrganicLiveAdvancedAsync` | POST | `/v3/serp/youtube/organic/live/advanced` |
| `YoutubeVideoSubtitlesTaskPostAsync` | POST | `/v3/serp/youtube/video_subtitles/task_post` |
| `YoutubeVideoSubtitlesTasksReadyAsync` | GET | `/v3/serp/youtube/video_subtitles/tasks_ready` |
| `YoutubeVideoSubtitlesTasksFixedAsync` | GET | `/v3/serp/youtube/video_subtitles/tasks_fixed` |
| `YoutubeVideoSubtitlesTaskGetAdvancedAsync` | GET | `/v3/serp/youtube/video_subtitles/task_get/advanced/{id}` |
| `YoutubeVideoSubtitlesLiveAdvancedAsync` | POST | `/v3/serp/youtube/video_subtitles/live/advanced` |
| `YoutubeVideoCommentsTaskPostAsync` | POST | `/v3/serp/youtube/video_comments/task_post` |
| `YoutubeVideoCommentsTasksReadyAsync` | GET | `/v3/serp/youtube/video_comments/tasks_ready` |
| `YoutubeVideoCommentsTasksFixedAsync` | GET | `/v3/serp/youtube/video_comments/tasks_fixed` |
| `YoutubeVideoCommentsTaskGetAdvancedAsync` | GET | `/v3/serp/youtube/video_comments/task_get/advanced/{id}` |
| `YoutubeVideoCommentsLiveAdvancedAsync` | POST | `/v3/serp/youtube/video_comments/live/advanced` |
| `YahooLocationsAsync` | GET | `/v3/serp/yahoo/locations` |
| `YahooLocationsCountryAsync` | GET | `/v3/serp/yahoo/locations/{country}` |
| `YahooLanguagesAsync` | GET | `/v3/serp/yahoo/languages` |
| `YahooOrganicTaskPostAsync` | POST | `/v3/serp/yahoo/organic/task_post` |
| `YahooOrganicTasksReadyAsync` | GET | `/v3/serp/yahoo/organic/tasks_ready` |
| `YahooOrganicTasksFixedAsync` | GET | `/v3/serp/yahoo/organic/tasks_fixed` |
| `YahooOrganicTaskGetRegularAsync` | GET | `/v3/serp/yahoo/organic/task_get/regular/{id}` |
| `YahooOrganicTaskGetAdvancedAsync` | GET | `/v3/serp/yahoo/organic/task_get/advanced/{id}` |
| `YahooOrganicTaskGetHtmlAsync` | GET | `/v3/serp/yahoo/organic/task_get/html/{id}` |
| `YahooOrganicLiveRegularAsync` | POST | `/v3/serp/yahoo/organic/live/regular` |
| `YahooOrganicLiveAdvancedAsync` | POST | `/v3/serp/yahoo/organic/live/advanced` |
| `YahooOrganicLiveHtmlAsync` | POST | `/v3/serp/yahoo/organic/live/html` |
| `BaiduLocationsAsync` | GET | `/v3/serp/baidu/locations` |
| `BaiduLocationsCountryAsync` | GET | `/v3/serp/baidu/locations/{country}` |
| `BaiduLanguagesAsync` | GET | `/v3/serp/baidu/languages` |
| `BaiduOrganicTaskPostAsync` | POST | `/v3/serp/baidu/organic/task_post` |
| `BaiduOrganicTasksReadyAsync` | GET | `/v3/serp/baidu/organic/tasks_ready` |
| `BaiduOrganicTasksFixedAsync` | GET | `/v3/serp/baidu/organic/tasks_fixed` |
| `BaiduOrganicTaskGetRegularAsync` | GET | `/v3/serp/baidu/organic/task_get/regular/{id}` |
| `BaiduOrganicTaskGetAdvancedAsync` | GET | `/v3/serp/baidu/organic/task_get/advanced/{id}` |
| `BaiduOrganicTaskGetHtmlAsync` | GET | `/v3/serp/baidu/organic/task_get/html/{id}` |
| `NaverOrganicTaskPostAsync` | POST | `/v3/serp/naver/organic/task_post` |
| `NaverOrganicTasksReadyAsync` | GET | `/v3/serp/naver/organic/tasks_ready` |
| `NaverOrganicTasksFixedAsync` | GET | `/v3/serp/naver/organic/tasks_fixed` |
| `NaverOrganicTaskGetRegularAsync` | GET | `/v3/serp/naver/organic/task_get/regular/{id}` |
| `NaverOrganicTaskGetAdvancedAsync` | GET | `/v3/serp/naver/organic/task_get/advanced/{id}` |
| `NaverOrganicTaskGetHtmlAsync` | GET | `/v3/serp/naver/organic/task_get/html/{id}` |
| `SeznamLocationsAsync` | GET | `/v3/serp/seznam/locations` |
| `SeznamLocationsCountryAsync` | GET | `/v3/serp/seznam/locations/{country}` |
| `SeznamLanguagesAsync` | GET | `/v3/serp/seznam/languages` |
| `SeznamOrganicTaskPostAsync` | POST | `/v3/serp/seznam/organic/task_post` |
| `SeznamOrganicTasksReadyAsync` | GET | `/v3/serp/seznam/organic/tasks_ready` |
| `SeznamOrganicTasksFixedAsync` | GET | `/v3/serp/seznam/organic/tasks_fixed` |
| `SeznamOrganicTaskGetRegularAsync` | GET | `/v3/serp/seznam/organic/task_get/regular/{id}` |
| `SeznamOrganicTaskGetAdvancedAsync` | GET | `/v3/serp/seznam/organic/task_get/advanced/{id}` |
| `SeznamOrganicTaskGetHtmlAsync` | GET | `/v3/serp/seznam/organic/task_get/html/{id}` |
| `GoogleFinanceExploreTaskPostAsync` | POST | `/v3/serp/google/finance_explore/task_post` |
| `GoogleFinanceExploreTasksReadyAsync` | GET | `/v3/serp/google/finance_explore/tasks_ready` |
| `GoogleFinanceExploreTaskGetAdvancedAsync` | GET | `/v3/serp/google/finance_explore/task_get/advanced/{id}` |
| `GoogleFinanceExploreTaskGetHtmlAsync` | GET | `/v3/serp/google/finance_explore/task_get/html/{id}` |
| `GoogleFinanceExploreLiveAdvancedAsync` | POST | `/v3/serp/google/finance_explore/live/advanced` |
| `GoogleFinanceExploreLiveHtmlAsync` | POST | `/v3/serp/google/finance_explore/live/html` |
| `GoogleFinanceMarketsTaskPostAsync` | POST | `/v3/serp/google/finance_markets/task_post` |
| `GoogleFinanceMarketsTasksReadyAsync` | GET | `/v3/serp/google/finance_markets/tasks_ready` |
| `GoogleFinanceMarketsTaskGetAdvancedAsync` | GET | `/v3/serp/google/finance_markets/task_get/advanced/{id}` |
| `GoogleFinanceMarketsTaskGetHtmlAsync` | GET | `/v3/serp/google/finance_markets/task_get/html/{id}` |
| `GoogleFinanceMarketsLiveAdvancedAsync` | POST | `/v3/serp/google/finance_markets/live/advanced` |
| `GoogleFinanceMarketsLiveHtmlAsync` | POST | `/v3/serp/google/finance_markets/live/html` |
| `GoogleFinanceQuoteTaskPostAsync` | POST | `/v3/serp/google/finance_quote/task_post` |
| `GoogleFinanceQuoteTasksReadyAsync` | GET | `/v3/serp/google/finance_quote/tasks_ready` |
| `GoogleFinanceQuoteTaskGetAdvancedAsync` | GET | `/v3/serp/google/finance_quote/task_get/advanced/{id}` |
| `GoogleFinanceQuoteTaskGetHtmlAsync` | GET | `/v3/serp/google/finance_quote/task_get/html/{id}` |
| `GoogleFinanceQuoteLiveAdvancedAsync` | POST | `/v3/serp/google/finance_quote/live/advanced` |
| `GoogleFinanceQuoteLiveHtmlAsync` | POST | `/v3/serp/google/finance_quote/live/html` |
| `GoogleFinanceTickerSearchTaskPostAsync` | POST | `/v3/serp/google/finance_ticker_search/task_post` |
| `GoogleFinanceTickerSearchTasksReadyAsync` | GET | `/v3/serp/google/finance_ticker_search/tasks_ready` |
| `GoogleFinanceTickerSearchTaskGetAdvancedAsync` | GET | `/v3/serp/google/finance_ticker_search/task_get/advanced/{id}` |
| `GoogleFinanceTickerSearchLiveAdvancedAsync` | POST | `/v3/serp/google/finance_ticker_search/live/advanced` |