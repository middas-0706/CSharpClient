# AppDataApi

Knowledge base for `dfsClient.AppDataApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Mobile application data from app stores such as Google Play and the App Store: app search results, top charts and collections, detailed app information and user reviews, plus a searchable database of app listings.

Results are collected for the requested location and language, the same way a store user would see them.

## Use it when you need

- Which apps rank in a store for a search query (app store optimization, competitor discovery).
- Which apps are in top charts or collections of a category.
- Details of a specific app: description, rating, installs, price, developer, versions.
- User reviews of an app for review monitoring, sentiment or product feedback analysis.
- Apps that match a category or text, found in a database without querying the store.

## Use another API when

- You need keywords an app ranks for, app competitors or app keyword gaps: `DataforseoLabsApi`.
- You need physical products on marketplaces: `MerchantApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### GoogleAppSearchesTaskPostAsync

`POST /v3/app_data/google/app_searches/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppSearchesTaskPostAsync(new List<AppDataGoogleAppSearchesTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "vpn",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 30,
    }
});
```

### GoogleAppSearchesTaskGetAdvancedAsync

`GET /v3/app_data/google/app_searches/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppSearchesTaskGetAdvancedAsync(id);
```

### AppleAppSearchesTaskGetAdvancedAsync

`GET /v3/app_data/apple/app_searches/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.AppleAppSearchesTaskGetAdvancedAsync(id);
```

### AppleAppSearchesTaskPostAsync

`POST /v3/app_data/apple/app_searches/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppSearchesTaskPostAsync(new List<AppDataAppleAppSearchesTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "vpn",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 200,
    }
});
```

### GoogleAppInfoTaskGetAdvancedAsync

`GET /v3/app_data/google/app_info/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppInfoTaskGetAdvancedAsync(id);
```

### GoogleAppInfoTaskPostAsync

`POST /v3/app_data/google/app_info/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppInfoTaskPostAsync(new List<AppDataGoogleAppInfoTaskPostRequestInfo>()
{
    new()
    {
        AppId = "org.telegram.messenger",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### AppleAppInfoTaskGetAdvancedAsync

`GET /v3/app_data/apple/app_info/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.AppleAppInfoTaskGetAdvancedAsync(id);
```

### AppleAppInfoTaskPostAsync

`POST /v3/app_data/apple/app_info/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppInfoTaskPostAsync(new List<AppDataAppleAppInfoTaskPostRequestInfo>()
{
    new()
    {
        AppId = "835599320",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### GoogleAppReviewsTaskPostAsync

`POST /v3/app_data/google/app_reviews/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppReviewsTaskPostAsync(new List<AppDataGoogleAppReviewsTaskPostRequestInfo>()
{
    new()
    {
        AppId = "org.telegram.messenger",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 150,
    }
});
```

### GoogleAppReviewsTaskGetAdvancedAsync

`GET /v3/app_data/google/app_reviews/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppReviewsTaskGetAdvancedAsync(id);
```

## Endpoints

All methods of `AppDataApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `AppDataIdListAsync` | POST | `/v3/app_data/id_list` |
| `AppDataErrorsAsync` | POST | `/v3/app_data/errors` |
| `GoogleCategoriesAsync` | GET | `/v3/app_data/google/categories` |
| `AppDataGoogleLocationsAsync` | GET | `/v3/app_data/google/locations` |
| `AppDataGoogleLocationsCountryAsync` | GET | `/v3/app_data/google/locations/{country}` |
| `AppDataGoogleLanguagesAsync` | GET | `/v3/app_data/google/languages` |
| `GoogleAppSearchesTaskPostAsync` | POST | `/v3/app_data/google/app_searches/task_post` |
| `GoogleAppSearchesTasksReadyAsync` | GET | `/v3/app_data/google/app_searches/tasks_ready` |
| `AppDataTasksReadyAsync` | GET | `/v3/app_data/tasks_ready` |
| `GoogleAppSearchesTaskGetAdvancedAsync` | GET | `/v3/app_data/google/app_searches/task_get/advanced/{id}` |
| `GoogleAppSearchesTaskGetHtmlAsync` | GET | `/v3/app_data/google/app_searches/task_get/html/{id}` |
| `GoogleAppListTaskPostAsync` | POST | `/v3/app_data/google/app_list/task_post` |
| `GoogleAppListTasksReadyAsync` | GET | `/v3/app_data/google/app_list/tasks_ready` |
| `GoogleAppListTaskGetAdvancedAsync` | GET | `/v3/app_data/google/app_list/task_get/advanced/{id}` |
| `GoogleAppListTaskGetHtmlAsync` | GET | `/v3/app_data/google/app_list/task_get/html/{id}` |
| `GoogleAppInfoTaskPostAsync` | POST | `/v3/app_data/google/app_info/task_post` |
| `GoogleAppInfoTasksReadyAsync` | GET | `/v3/app_data/google/app_info/tasks_ready` |
| `GoogleAppInfoTaskGetAdvancedAsync` | GET | `/v3/app_data/google/app_info/task_get/advanced/{id}` |
| `GoogleAppInfoTaskGetHtmlAsync` | GET | `/v3/app_data/google/app_info/task_get/html/{id}` |
| `GoogleAppReviewsTaskPostAsync` | POST | `/v3/app_data/google/app_reviews/task_post` |
| `GoogleAppReviewsTasksReadyAsync` | GET | `/v3/app_data/google/app_reviews/tasks_ready` |
| `GoogleAppReviewsTaskGetAdvancedAsync` | GET | `/v3/app_data/google/app_reviews/task_get/advanced/{id}` |
| `GoogleAppReviewsTaskGetHtmlAsync` | GET | `/v3/app_data/google/app_reviews/task_get/html/{id}` |
| `GoogleAppListingsCategoriesAsync` | GET | `/v3/app_data/google/app_listings/categories` |
| `GoogleAppListingsSearchLiveAsync` | POST | `/v3/app_data/google/app_listings/search/live` |
| `AppleCategoriesAsync` | GET | `/v3/app_data/apple/categories` |
| `AppleLocationsAsync` | GET | `/v3/app_data/apple/locations` |
| `AppleLanguagesAsync` | GET | `/v3/app_data/apple/languages` |
| `AppleAppSearchesTaskPostAsync` | POST | `/v3/app_data/apple/app_searches/task_post` |
| `AppleAppSearchesTasksReadyAsync` | GET | `/v3/app_data/apple/app_searches/tasks_ready` |
| `AppleAppSearchesTaskGetAdvancedAsync` | GET | `/v3/app_data/apple/app_searches/task_get/advanced/{id}` |
| `AppleAppInfoTaskPostAsync` | POST | `/v3/app_data/apple/app_info/task_post` |
| `AppleAppInfoTasksReadyAsync` | GET | `/v3/app_data/apple/app_info/tasks_ready` |
| `AppleAppInfoTaskGetAdvancedAsync` | GET | `/v3/app_data/apple/app_info/task_get/advanced/{id}` |
| `AppleAppListTaskPostAsync` | POST | `/v3/app_data/apple/app_list/task_post` |
| `AppleAppListTasksReadyAsync` | GET | `/v3/app_data/apple/app_list/tasks_ready` |
| `AppleAppListTaskGetAdvancedAsync` | GET | `/v3/app_data/apple/app_list/task_get/advanced/{id}` |
| `AppleAppReviewsTaskPostAsync` | POST | `/v3/app_data/apple/app_reviews/task_post` |
| `AppleAppReviewsTasksReadyAsync` | GET | `/v3/app_data/apple/app_reviews/tasks_ready` |
| `AppleAppReviewsTaskGetAdvancedAsync` | GET | `/v3/app_data/apple/app_reviews/task_get/advanced/{id}` |
| `AppleAppListingsCategoriesAsync` | GET | `/v3/app_data/apple/app_listings/categories` |
| `AppleAppListingsSearchLiveAsync` | POST | `/v3/app_data/apple/app_listings/search/live` |