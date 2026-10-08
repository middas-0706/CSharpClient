# BusinessDataApi

Knowledge base for `dfsClient.BusinessDataApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Publicly available data about businesses and local places: business profiles, reviews, questions and answers, hotel data and a database of business listings, from sources such as Google, Trustpilot and Tripadvisor.

## Use it when you need

- Details of a business profile: address, phone, website, hours, categories, rating, attributes and posts.
- Reviews of a business on Google or review platforms, for reputation monitoring and sentiment analysis.
- Questions and answers about a place, or hotel search results with prices and hotel details.
- Lists of businesses by category, location, rating and other attributes (lead generation, local market research).

## Use another API when

- You need local rankings in search or maps results for a query: `SerpApi`.
- You need web-wide brand mentions rather than reviews: `ContentAnalysisApi`.
- You need products and sellers on marketplaces: `MerchantApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### GoogleMyBusinessInfoTaskGetAsync

`GET /v3/business_data/google/my_business_info/task_get/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoTaskGetAsync(id);
```

### GoogleMyBusinessInfoTaskPostAsync

`POST /v3/business_data/google/my_business_info/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoTaskPostAsync(new List<BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationName = "New York,New York,United States",
        Keyword = "RustyBrick, Inc.",
    }
});
```

### GoogleReviewsTasksReadyAsync

`GET /v3/business_data/google/reviews/tasks_ready`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleReviewsTasksReadyAsync();
```

### GoogleReviewsTaskGetAsync

`GET /v3/business_data/google/reviews/task_get/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleReviewsTaskGetAsync(id);
```

### GoogleReviewsTaskPostAsync

`POST /v3/business_data/google/reviews/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleReviewsTaskPostAsync(new List<BusinessDataGoogleReviewsTaskPostRequestInfo>()
{
    new()
    {
        LocationName = "London,England,United Kingdom",
        LanguageName = "English",
        Keyword = "hedonism wines",
        Depth = 50,
        SortBy = "highest_rating",
    }
});
```

### GoogleHotelInfoTaskGetAdvancedAsync

`GET /v3/business_data/google/hotel_info/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoTaskGetAdvancedAsync(id);
```

### GoogleHotelInfoTaskPostAsync

`POST /v3/business_data/google/hotel_info/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoTaskPostAsync(new List<BusinessDataGoogleHotelInfoTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationName = "New York,New York,United States",
        HotelIdentifier = "ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE",
        Tag = "some_string_123",
        PostbackUrl = "https://your-server.com/postbackscript.php",
        PostbackData = "advanced",
    }
});
```

### GoogleMyBusinessInfoLiveAsync

`POST /v3/business_data/google/my_business_info/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoLiveAsync(new List<BusinessDataGoogleMyBusinessInfoLiveRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationName = "New York,New York,United States",
        Keyword = "RustyBrick, Inc.",
    }
});
```

### GoogleMyBusinessInfoTasksReadyAsync

`GET /v3/business_data/google/my_business_info/tasks_ready`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoTasksReadyAsync();
```

## Endpoints

All methods of `BusinessDataApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `BusinessDataIdListAsync` | POST | `/v3/business_data/id_list` |
| `BusinessDataErrorsAsync` | POST | `/v3/business_data/errors` |
| `BusinessListingsLocationsAsync` | GET | `/v3/business_data/business_listings/locations` |
| `BusinessListingsCategoriesAsync` | GET | `/v3/business_data/business_listings/categories` |
| `BusinessListingsAvailableFiltersAsync` | GET | `/v3/business_data/business_listings/available_filters` |
| `BusinessListingsSearchLiveAsync` | POST | `/v3/business_data/business_listings/search/live` |
| `BusinessListingsCategoriesAggregationLiveAsync` | POST | `/v3/business_data/business_listings/categories_aggregation/live` |
| `BusinessDataGoogleLocationsAsync` | GET | `/v3/business_data/google/locations` |
| `BusinessDataGoogleLocationsCountryAsync` | GET | `/v3/business_data/google/locations/{country}` |
| `BusinessDataGoogleLanguagesAsync` | GET | `/v3/business_data/google/languages` |
| `GoogleMyBusinessInfoTaskPostAsync` | POST | `/v3/business_data/google/my_business_info/task_post` |
| `GoogleMyBusinessInfoTasksReadyAsync` | GET | `/v3/business_data/google/my_business_info/tasks_ready` |
| `BusinessDataTasksReadyAsync` | GET | `/v3/business_data/tasks_ready` |
| `GoogleMyBusinessInfoTaskGetAsync` | GET | `/v3/business_data/google/my_business_info/task_get/{id}` |
| `GoogleMyBusinessInfoLiveAsync` | POST | `/v3/business_data/google/my_business_info/live` |
| `GoogleMyBusinessUpdatesTaskPostAsync` | POST | `/v3/business_data/google/my_business_updates/task_post` |
| `GoogleMyBusinessUpdatesTasksReadyAsync` | GET | `/v3/business_data/google/my_business_updates/tasks_ready` |
| `GoogleMyBusinessUpdatesTaskGetAsync` | GET | `/v3/business_data/google/my_business_updates/task_get/{id}` |
| `GoogleHotelSearchesTaskPostAsync` | POST | `/v3/business_data/google/hotel_searches/task_post` |
| `GoogleHotelSearchesTasksReadyAsync` | GET | `/v3/business_data/google/hotel_searches/tasks_ready` |
| `GoogleHotelSearchesTaskGetAsync` | GET | `/v3/business_data/google/hotel_searches/task_get/{id}` |
| `GoogleHotelSearchesLiveAsync` | POST | `/v3/business_data/google/hotel_searches/live` |
| `GoogleHotelInfoTaskPostAsync` | POST | `/v3/business_data/google/hotel_info/task_post` |
| `GoogleHotelInfoTasksReadyAsync` | GET | `/v3/business_data/google/hotel_info/tasks_ready` |
| `GoogleHotelInfoTaskGetAdvancedAsync` | GET | `/v3/business_data/google/hotel_info/task_get/advanced/{id}` |
| `GoogleHotelInfoTaskGetHtmlAsync` | GET | `/v3/business_data/google/hotel_info/task_get/html/{id}` |
| `GoogleHotelInfoLiveAdvancedAsync` | POST | `/v3/business_data/google/hotel_info/live/advanced` |
| `GoogleHotelInfoLiveHtmlAsync` | POST | `/v3/business_data/google/hotel_info/live/html` |
| `GoogleReviewsTaskPostAsync` | POST | `/v3/business_data/google/reviews/task_post` |
| `GoogleReviewsTasksReadyAsync` | GET | `/v3/business_data/google/reviews/tasks_ready` |
| `GoogleReviewsTaskGetAsync` | GET | `/v3/business_data/google/reviews/task_get/{id}` |
| `GoogleExtendedReviewsTaskPostAsync` | POST | `/v3/business_data/google/extended_reviews/task_post` |
| `GoogleExtendedReviewsTasksReadyAsync` | GET | `/v3/business_data/google/extended_reviews/tasks_ready` |
| `GoogleExtendedReviewsTaskGetAsync` | GET | `/v3/business_data/google/extended_reviews/task_get/{id}` |
| `GoogleQuestionsAndAnswersTaskPostAsync` | POST | `/v3/business_data/google/questions_and_answers/task_post` |
| `GoogleQuestionsAndAnswersTasksReadyAsync` | GET | `/v3/business_data/google/questions_and_answers/tasks_ready` |
| `GoogleQuestionsAndAnswersTaskGetAsync` | GET | `/v3/business_data/google/questions_and_answers/task_get/{id}` |
| `GoogleQuestionsAndAnswersLiveAsync` | POST | `/v3/business_data/google/questions_and_answers/live` |
| `TrustpilotSearchTaskPostAsync` | POST | `/v3/business_data/trustpilot/search/task_post` |
| `TrustpilotSearchTasksReadyAsync` | GET | `/v3/business_data/trustpilot/search/tasks_ready` |
| `TrustpilotSearchTaskGetAsync` | GET | `/v3/business_data/trustpilot/search/task_get/{id}` |
| `TrustpilotReviewsTaskPostAsync` | POST | `/v3/business_data/trustpilot/reviews/task_post` |
| `TrustpilotReviewsTasksReadyAsync` | GET | `/v3/business_data/trustpilot/reviews/tasks_ready` |
| `TrustpilotReviewsTaskGetAsync` | GET | `/v3/business_data/trustpilot/reviews/task_get/{id}` |
| `TripadvisorLocationsAsync` | GET | `/v3/business_data/tripadvisor/locations` |
| `TripadvisorLocationsCountryAsync` | GET | `/v3/business_data/tripadvisor/locations/{country}` |
| `TripadvisorLanguagesAsync` | GET | `/v3/business_data/tripadvisor/languages` |
| `TripadvisorSearchTaskPostAsync` | POST | `/v3/business_data/tripadvisor/search/task_post` |
| `TripadvisorSearchTasksReadyAsync` | GET | `/v3/business_data/tripadvisor/search/tasks_ready` |
| `TripadvisorSearchTaskGetAsync` | GET | `/v3/business_data/tripadvisor/search/task_get/{id}` |
| `TripadvisorReviewsTaskPostAsync` | POST | `/v3/business_data/tripadvisor/reviews/task_post` |
| `TripadvisorReviewsTasksReadyAsync` | GET | `/v3/business_data/tripadvisor/reviews/tasks_ready` |
| `TripadvisorReviewsTaskGetAsync` | GET | `/v3/business_data/tripadvisor/reviews/task_get/{id}` |