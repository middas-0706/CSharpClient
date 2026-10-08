# OnPageApi

Knowledge base for `dfsClient.OnPageApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Technical SEO audit of websites with a configurable crawler: crawl a site and get per-page checks, resources, internal and external links, duplicates, redirects, indexability issues, keyword density and page speed data; or analyze individual pages instantly, extract their content, take screenshots and run Google Lighthouse.

A full site audit is a crawl task: it is started once and its reports can be read while the crawl is running or after it finishes. Single-page analysis returns results immediately.

## Use it when you need

- A site health check: broken pages and resources, duplicate titles, descriptions or content, redirect chains, pages blocked from indexing and other on-page issues.
- The structure of a site: its pages, resources and the links between them.
- On-page data of a single URL: meta tags, headings, checks, parsed main content or the raw HTML.
- Performance, accessibility and best-practice scores of a page.

## Use another API when

- You need inbound links from other sites: `BacklinksApi`.
- You need how pages rank in search: `SerpApi` or `DataforseoLabsApi`.
- You need which technologies a site uses: `DomainAnalyticsApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### InstantPagesAsync

`POST /v3/on_page/instant_pages`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.InstantPagesAsync(new List<OnPageInstantPagesRequestInfo>()
{
    new()
    {
        Url = "https://dataforseo.com/blog",
        EnableJavascript = true,
        CustomJs = "meta = {}; meta.url = document.URL; meta;",
    }
});
```

### RawHtmlAsync

`POST /v3/on_page/raw_html`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.RawHtmlAsync(new List<OnPageRawHtmlRequestInfo>()
{
    new()
    {
        Id = "07281559-0695-0216-0000-c269be8b7592",
        Url = "https://dataforseo.com/apis",
    }
});
```

### SummaryAsync

`GET /v3/on_page/summary/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.OnPageApi.SummaryAsync(id);
```

### PagesAsync

`POST /v3/on_page/pages`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.PagesAsync(new List<OnPagePagesRequestInfo>()
{
    new()
    {
        Id = "07281559-0695-0216-0000-c269be8b7592",
        Filters = new List<object>()
        {
            new List<object>()
            {
                "resource_type",
                "=",
                "html",
            },
            "and",
            new List<object>()
            {
                "meta.scripts_count",
                ">",
                40,
            },
        },
        OrderBy = new List<string>()
        {
            "meta.content.plain_text_word_count,desc",
        },
        Limit = 10,
    }
});
```

### ContentParsingLiveAsync

`POST /v3/on_page/content_parsing/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.ContentParsingLiveAsync(new List<OnPageContentParsingLiveRequestInfo>()
{
    new()
    {
        Url = "https://dataforseo.com/blog/a-versatile-alternative-to-google-trends-exploring-the-power-of-dataforseo-trends-api",
    }
});
```

### TaskPostAsync

`POST /v3/on_page/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.TaskPostAsync(new List<OnPageTaskPostRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        MaxCrawlPages = 10,
        LoadResources = true,
        EnableJavascript = true,
        CustomJs = "meta = {}; meta.url = document.URL; meta;",
        Tag = "some_string_123",
        PingbackUrl = "https://your-server.com/pingscript?id=$id&tag=$tag",
    }
});
```

### LinksAsync

`POST /v3/on_page/links`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.LinksAsync(new List<OnPageLinksRequestInfo>()
{
    new()
    {
        Id = "07281559-0695-0216-0000-c269be8b7592",
        PageFrom = "/apis/google-trends-api",
        Filters = new List<object>()
        {
            new List<object>()
            {
                "dofollow",
                "=",
                true,
            },
            "and",
            new List<object>()
            {
                "direction",
                "=",
                "external",
            },
        },
        Limit = 10,
    }
});
```

### MicrodataAsync

`POST /v3/on_page/microdata`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.MicrodataAsync(new List<OnPageMicrodataRequestInfo>()
{
    new()
    {
        Id = "02241700-1535-0216-0000-034137259bc1",
        Url = "https://dataforseo.com/apis",
    }
});
```

### OnPageTasksReadyAsync

`GET /v3/on_page/tasks_ready`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.OnPageApi.OnPageTasksReadyAsync();
```

## Endpoints

All methods of `OnPageApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `OnPageIdListAsync` | POST | `/v3/on_page/id_list` |
| `OnPageErrorsAsync` | POST | `/v3/on_page/errors` |
| `ForceStopAsync` | POST | `/v3/on_page/force_stop` |
| `OnPageAvailableFiltersAsync` | GET | `/v3/on_page/available_filters` |
| `TaskPostAsync` | POST | `/v3/on_page/task_post` |
| `OnPageTasksReadyAsync` | GET | `/v3/on_page/tasks_ready` |
| `SummaryAsync` | GET | `/v3/on_page/summary/{id}` |
| `PagesAsync` | POST | `/v3/on_page/pages` |
| `PagesByResourceAsync` | POST | `/v3/on_page/pages_by_resource` |
| `ResourcesAsync` | POST | `/v3/on_page/resources` |
| `DuplicateTagsAsync` | POST | `/v3/on_page/duplicate_tags` |
| `DuplicateContentAsync` | POST | `/v3/on_page/duplicate_content` |
| `LinksAsync` | POST | `/v3/on_page/links` |
| `RedirectChainsAsync` | POST | `/v3/on_page/redirect_chains` |
| `NonIndexableAsync` | POST | `/v3/on_page/non_indexable` |
| `WaterfallAsync` | POST | `/v3/on_page/waterfall` |
| `KeywordDensityAsync` | POST | `/v3/on_page/keyword_density` |
| `MicrodataAsync` | POST | `/v3/on_page/microdata` |
| `UncrawlableResourcesAsync` | POST | `/v3/on_page/uncrawlable_resources` |
| `RawHtmlAsync` | POST | `/v3/on_page/raw_html` |
| `PageScreenshotAsync` | POST | `/v3/on_page/page_screenshot` |
| `ContentParsingAsync` | POST | `/v3/on_page/content_parsing` |
| `ContentParsingLiveAsync` | POST | `/v3/on_page/content_parsing/live` |
| `InstantPagesAsync` | POST | `/v3/on_page/instant_pages` |
| `LighthouseLanguagesAsync` | GET | `/v3/on_page/lighthouse/languages` |
| `LighthouseAuditsAsync` | GET | `/v3/on_page/lighthouse/audits` |
| `LighthouseVersionsAsync` | GET | `/v3/on_page/lighthouse/versions` |
| `LighthouseTaskPostAsync` | POST | `/v3/on_page/lighthouse/task_post` |
| `LighthouseTasksReadyAsync` | GET | `/v3/on_page/lighthouse/tasks_ready` |
| `LighthouseTaskGetJsonAsync` | GET | `/v3/on_page/lighthouse/task_get/json/{id}` |
| `LighthouseLiveJsonAsync` | POST | `/v3/on_page/lighthouse/live/json` |