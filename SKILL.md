---
name: dataforseo-csharp-client
description: Use the DataForSEO C# client (NuGet package DataForSeo.Client) to call DataForSEO API v3 (SERP, Keywords Data, DataForSEO Labs, Backlinks, OnPage, AI Optimization, etc.). Read this before exploring the code; it explains the layout, naming rules and how to find an endpoint without reading the huge generated files.
---

# DataForSEO C# client

Generated, strongly typed .NET client for DataForSEO API v3.
Every API endpoint is one async method; every request/response body is one DTO class.

- Package: `dotnet add package DataForSeo.Client`
- Targets: `netstandard2.0`, `netstandard2.1`; JSON: `Newtonsoft.Json`
- Root namespace: `DataForSeo.Client`
- Base URL: `https://api.dataforseo.com` (sandbox with free dummy data: `https://sandbox.dataforseo.com`)
- Auth: HTTP Basic with the DataForSEO API login and password (not the dashboard password)

## Do not read generated code in full

The client is generated from an OpenAPI spec and is very large (thousands of DTO classes, `Api/*.cs` files of several hundred KB). Never open files whole. Derive names with the rules below and use targeted search (grep) only to confirm them.

## Knowledge base: start here

`knowledge-base/` (next to this file) has one Markdown file per API section, i.e. per property of `DataForSeoClient`. Each file explains what data the section provides and when to use another section instead, gives ready-to-run examples and lists every endpoint with its method name. Open only the file of the section you need: it is much cheaper than searching the generated code.

| API class | Use it for |
|---|---|
| [`SerpApi`](knowledge-base/SerpApi.md) | Search engine results pages (SERP) collected on request: what a search engine shows for a query in a given location, language and device, from engines such as Google, Bing, YouTube, Yahoo and others, including search verticals such as maps, news, images, jobs and AI search modes. |
| [`DataforseoLabsApi`](knowledge-base/DataforseoLabsApi.md) | Keyword research, competitor analysis and search analytics from DataForSEO's own databases of keywords, search results and rankings, for search engines and platforms such as Google, Amazon, Google Play and the App Store. |
| [`DomainAnalyticsApi`](knowledge-base/DomainAnalyticsApi.md) | Information about websites as such: the technologies a site is built with (CMS, analytics, frameworks, advertising and other tools), which sites use a given technology, statistics of technology usage, and domain registration (Whois) data enriched with search and backlink metrics. |
| [`KeywordsDataApi`](knowledge-base/KeywordsDataApi.md) | Keyword metrics from advertising platforms and trend services: search volume, cost per click, competition and their monthly dynamics, keyword ideas, ad traffic forecasts and keyword popularity trends, from sources such as Google Ads, Bing Ads, Google Trends, DataForSEO Trends and clickstream data. |
| [`BacklinksApi`](knowledge-base/BacklinksApi.md) | Backlink data for any domain, subdomain or web page from DataForSEO's continuously updated link index: inbound links, referring domains, pages and networks, anchor texts, link-based authority (rank) and spam score, how the link profile changes over time, and how it compares with other sites. |
| [`AiOptimizationApi`](knowledge-base/AiOptimizationApi.md) | Data for AI search optimization (GEO): answers of large language models such as ChatGPT, Claude, Gemini and Perplexity to your prompts, results scraped from the web interfaces of AI assistants, search volume of keywords in AI tools, and how often brands, domains and pages are mentioned in AI-generated answers. |
| [`OnPageApi`](knowledge-base/OnPageApi.md) | Technical SEO audit of websites with a configurable crawler: crawl a site and get per-page checks, resources, internal and external links, duplicates, redirects, indexability issues, keyword density and page speed data; or analyze individual pages instantly, extract their content, take screenshots and run Google Lighthouse. |
| [`ContentAnalysisApi`](knowledge-base/ContentAnalysisApi.md) | Brand monitoring and sentiment analysis across the web: pages that mention (cite) a keyword or brand, with the sentiment polarity and emotional connotations of each mention, content ratings and categories, and aggregated trends of mentions over time. |
| [`MerchantApi`](knowledge-base/MerchantApi.md) | E-commerce data from marketplaces and shopping search engines such as Amazon and Google Shopping: product listings for a search query, product details, product variations, sellers and their offers, with prices, ratings, reviews count and paid placements. |
| [`AppDataApi`](knowledge-base/AppDataApi.md) | Mobile application data from app stores such as Google Play and the App Store: app search results, top charts and collections, detailed app information and user reviews, plus a searchable database of app listings. |
| [`BusinessDataApi`](knowledge-base/BusinessDataApi.md) | Publicly available data about businesses and local places: business profiles, reviews, questions and answers, hotel data and a database of business listings, from sources such as Google, Trustpilot and Tripadvisor. |
| [`AppendixApi`](knowledge-base/AppendixApi.md) | Account and service information that applies to the whole DataForSEO API rather than to a data source: account balance, spending, limits and prices, the current status of the APIs, the list of error codes, and re-sending webhooks (pingbacks and postbacks) of completed tasks. |

## Layout

Source code (git repository):

```
DataForSeoClient.cs                 entry point: DataForSeoClient + DataForSeoClientConfiguration
Api/<Section>Api.cs                 one class per API section, one method per endpoint
Models/                             shared/nested DTOs, polymorphic items, ApiException
Models/Requests/*RequestInfo.cs     request bodies
Models/Responses/*ResponseInfo.cs   top-level responses
knowledge-base/<Section>Api.md      per-section guide with examples (see above)
```

NuGet package (`~/.nuget/packages/dataforseo.client/<version>/`): `README.md`, `SKILL.md`, `knowledge-base/`, `lib/<tfm>/DataForSeo.Client.dll` and `lib/<tfm>/DataForSeo.Client.xml`. The package has no source code; the XML documentation file contains the description of every DTO property.

## Naming rules (derive names instead of searching)

Endpoint path `/v3/<section>/<rest>` maps to:

| What | Rule | Example for `/v3/serp/google/organic/live/advanced` |
|---|---|---|
| API class | `<Section>Api` | `SerpApi` (`dfsClient.SerpApi`) |
| Method | PascalCase of `<rest>` + `Async` (usually) | `GoogleOrganicLiveAdvancedAsync` |
| Request DTO | `<Section><Rest>RequestInfo` | `SerpGoogleOrganicLiveAdvancedRequestInfo` |
| Response DTO | `<Section><Rest>ResponseInfo` | `SerpGoogleOrganicLiveAdvancedResponseInfo` |
| Task item | `<Section><Rest>TaskInfo` | `SerpGoogleOrganicLiveAdvancedTaskInfo` |
| Result item | `<Section><Rest>ResultInfo` | `SerpGoogleOrganicLiveAdvancedResultInfo` |

DTO names follow the rule strictly. Method names sometimes keep the section prefix (e.g. `DataforseoLabsIdListAsync`), so confirm the method by its response DTO (source code), or rely on IDE completion / the compiler when only the package is available:

```bash
grep -n "Task<SerpGoogleOrganicLiveAdvancedResponseInfo>" Api/SerpApi.cs   # -> method signature
```

DTO fields and their descriptions (required/optional, allowed values, limits) are XML doc comments on the properties. In the source read only the needed properties of `Models/**/<ClassName>.cs`; with the package search the XML documentation file:

```bash
grep -n -A 2 "P:DataForSeo.Client.Models.Requests.SerpGoogleOrganicLiveAdvancedRequestInfo\." DataForSeo.Client.xml
```

## Method shapes

- `POST` endpoints: `Task<XResponseInfo> XAsync(IEnumerable<XRequestInfo> payload)`, the body is always an array of tasks.
- `GET` endpoints: `Task<XResponseInfo> XAsync()` or `XAsync(string id)` (task id for `TaskGet*`, `country` for locations etc.).

## Setup

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;

var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration
{
    Username = "API_LOGIN",
    Password = "API_PASSWORD",
    // CustomHeaders = new Dictionary<string, string> { ["X-Header"] = "value" },
});

// optional: use sandbox for a specific section
// dfsClient.SerpApi.BaseUrl = "https://sandbox.dataforseo.com";
```

`DataForSeoClient` owns one `HttpClient` (gzip, 1 min timeout). Create it once and reuse it.

## Live request (result in the same call)

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models.Requests;

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

## Task-based request (post -> wait -> get)

```csharp
using System.Diagnostics;
using DataForSeo.Client;
using DataForSeo.Client.Models.Requests;

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
        Priority = 2,
    }
});

var sw = Stopwatch.StartNew();

var id = result.Tasks.First().Id;
while (!await GoogleOrganicTaskReady(id) && sw.Elapsed < TimeSpan.FromMinutes(1))
    await Task.Delay(1_000);

var taskGetResult = await dfsClient.SerpApi.GoogleOrganicTaskGetAdvancedAsync(id);

async Task<bool> GoogleOrganicTaskReady(string id)
{
    var result = await  dfsClient.SerpApi.GoogleOrganicTasksReadyAsync();
    return result.Tasks?.Any(x => x.Result?.Any(xx => xx.Id == id) ?? false) ?? false;
}
```

Instead of polling you can set `PostbackUrl` / `PingbackUrl` in the task request.

## Response envelope (same for every endpoint)

```
XResponseInfo : BaseResponseInfo
  Version, StatusCode, StatusMessage, Time, Cost, TasksCount, TasksError
  Tasks: IEnumerable<XTaskInfo>
    XTaskInfo : BaseResponseTaskInfo
      Id, StatusCode, StatusMessage, Time, Cost, ResultCount, Path, Data (echo of the request)
      Result: IEnumerable<XResultInfo>   // endpoint specific payload, often with Items
```

- `StatusCode == 20000` means OK (both top-level and per task); `20100` = task created; `4xxxx`/`5xxxx` = errors. Always check the per-task `StatusCode`: the HTTP status is usually 200 even when a task failed.
- Unknown JSON fields go to `AdditionalProperties` on every DTO.
- All properties are nullable; null-check collections (`Tasks`, `Result`, `Items`).

## Polymorphic items

Lists like `Items` are typed as a base class (e.g. `BaseSerpApiElementItem`) and deserialized into concrete subclasses by the JSON `type` field (`organic` -> `OrganicSerpElementItem`, `paid` -> `PaidSerpElementItem`, `featured_snippet` -> `FeaturedSnippetSerpElementItem`, ...). Use `OfType<T>()` / `is T`. The mapping is declared with `[JsonInheritance("<type>", typeof(...))]` attributes at the top of the base class file; grep there instead of reading it.

## Errors

Non-200 HTTP responses and deserialization failures throw `DataForSeo.Client.Models.ApiException` with `StatusCode`, `Response` (raw body) and `Headers`.

## Useful facts

- Location / language codes: `LocationCode = 2840` (United States), `LanguageCode = "en"`. Full lists come from endpoints like `SerpApi.GoogleLocationsAsync()` / `GoogleLanguagesAsync()` (and similar per section).
- Most Live endpoints accept one task per request; Task POST endpoints accept many tasks (up to 100) in one call.
- `TaskGet*` has several variants (`Regular`, `Advanced`, `Html`); use the one matching the data you need.
- Field semantics, allowed values and limits: XML doc comments of the request DTO properties (they come from the official API docs).

## External documentation (last resort)

Use https://dataforseo.com/llms.txt only when this file, the knowledge base or the generated code do not answer the question (for example pricing, account limits or endpoint behaviour that is not described locally). Everything needed to write client code is already in this library.

`llms.txt` is a large (~200 KB) index of links to per-endpoint Markdown pages (`https://docs.dataforseo.com/v3/...md`). Do not read it whole: search it for the endpoint path or name and fetch only the linked page.