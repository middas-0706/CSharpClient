# AiOptimizationApi

Knowledge base for `dfsClient.AiOptimizationApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Data for AI search optimization (GEO): answers of large language models such as ChatGPT, Claude, Gemini and Perplexity to your prompts, results scraped from the web interfaces of AI assistants, search volume of keywords in AI tools, and how often brands, domains and pages are mentioned in AI-generated answers.

## Use it when you need

- To send a prompt to an LLM through one API and get its answer, the sources it cites and the usage cost, for example to benchmark several models.
- What end users actually see in an AI assistant for a query, including cited sources and mentioned brands.
- How popular a keyword or topic is among AI assistant users.
- Brand visibility in AI answers: where a brand or domain is mentioned, for which queries, how often, compared with competitors and over time.

## Use another API when

- You need classic search engine results, including AI answers embedded in search results pages: `SerpApi`.
- You need keyword metrics for classic search: `KeywordsDataApi` or `DataforseoLabsApi`.
- You need brand mentions on regular web pages: `ContentAnalysisApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### GeminiLlmScraperTaskGetAdvancedAsync

`GET /v3/ai_optimization/gemini/llm_scraper/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AiOptimizationApi.GeminiLlmScraperTaskGetAdvancedAsync(id);
```

### ChatGptLlmScraperTaskGetAdvancedAsync

`GET /v3/ai_optimization/chat_gpt/llm_scraper/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperTaskGetAdvancedAsync(id);
```

### ChatGptLlmScraperTaskPostAsync

`POST /v3/ai_optimization/chat_gpt/llm_scraper/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperTaskPostAsync(new List<AiOptimizationChatGptLlmScraperTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "what is chatgpt",
    }
});
```

### GeminiLlmScraperTaskPostAsync

`POST /v3/ai_optimization/gemini/llm_scraper/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.GeminiLlmScraperTaskPostAsync(new List<AiOptimizationGeminiLlmScraperTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
    }
});
```

### ChatGptLlmScraperTasksReadyAsync

`GET /v3/ai_optimization/chat_gpt/llm_scraper/tasks_ready`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperTasksReadyAsync();
```

### ChatGptLlmScraperLiveAdvancedAsync

`POST /v3/ai_optimization/chat_gpt/llm_scraper/live/advanced`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperLiveAdvancedAsync(new List<AiOptimizationChatGptLlmScraperLiveAdvancedRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
    }
});
```

### PerplexityLlmResponsesLiveAsync

`POST /v3/ai_optimization/perplexity/llm_responses/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.PerplexityLlmResponsesLiveAsync(new List<AiOptimizationPerplexityLlmResponsesLiveRequestInfo>()
{
    new()
    {
        SystemMessage = "communicate as if we are in a business meeting",
        MessageChain = new List<LlmMessageChainItem>()
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what\u2019s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I\u2019m doing well, thank you. How can I assist you today? Are there any specific topics or projects you\u2019d like to discuss in our meeting?",
            },
        },
        MaxOutputTokens = 200,
        Temperature = 0.3,
        TopP = 0.5,
        WebSearchCountryIsoCode = "FR",
        ModelName = "sonar",
        UserPrompt = "provide information on how relevant the amusement park business is in France now",
    }
});
```

### GeminiLlmScraperLiveAdvancedAsync

`POST /v3/ai_optimization/gemini/llm_scraper/live/advanced`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.GeminiLlmScraperLiveAdvancedAsync(new List<AiOptimizationGeminiLlmScraperLiveAdvancedRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
    }
});
```

### ChatGptLlmResponsesLiveAsync

`POST /v3/ai_optimization/chat_gpt/llm_responses/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmResponsesLiveAsync(new List<AiOptimizationChatGptLlmResponsesLiveRequestInfo>()
{
    new()
    {
        SystemMessage = "communicate as if we are in a business meeting",
        MessageChain = new List<LlmMessageChainItem>()
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what\u2019s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I\u2019m doing well, thank you. How can I assist you today? Are there any specific topics or projects you\u2019d like to discuss in our meeting?",
            },
        },
        MaxOutputTokens = 200,
        Temperature = 0.3,
        TopP = 0.5,
        ModelName = "gpt-4.1-mini",
        WebSearch = true,
        WebSearchCountryIsoCode = "FR",
        WebSearchCity = "Paris",
        UserPrompt = "provide information on how relevant the amusement park business is in France now",
    }
});
```

## Endpoints

All methods of `AiOptimizationApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `ChatGptLlmScraperLocationsAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_scraper/locations` |
| `ChatGptLlmScraperLocationsCountryAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_scraper/locations/{country}` |
| `ChatGptLlmScraperLanguagesAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_scraper/languages` |
| `ChatGptLlmScraperTaskPostAsync` | POST | `/v3/ai_optimization/chat_gpt/llm_scraper/task_post` |
| `ChatGptLlmScraperTasksReadyAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_scraper/tasks_ready` |
| `ChatGptLlmScraperTaskGetAdvancedAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_scraper/task_get/advanced/{id}` |
| `ChatGptLlmScraperTaskGetHtmlAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_scraper/task_get/html/{id}` |
| `ChatGptLlmScraperLiveAdvancedAsync` | POST | `/v3/ai_optimization/chat_gpt/llm_scraper/live/advanced` |
| `ChatGptLlmScraperLiveHtmlAsync` | POST | `/v3/ai_optimization/chat_gpt/llm_scraper/live/html` |
| `ChatGptLlmResponsesModelsAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_responses/models` |
| `ChatGptLlmResponsesLiveAsync` | POST | `/v3/ai_optimization/chat_gpt/llm_responses/live` |
| `ChatGptLlmResponsesTaskPostAsync` | POST | `/v3/ai_optimization/chat_gpt/llm_responses/task_post` |
| `ChatGptLlmResponsesTasksReadyAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_responses/tasks_ready` |
| `ChatGptLlmResponsesTaskGetAsync` | GET | `/v3/ai_optimization/chat_gpt/llm_responses/task_get/{id}` |
| `ClaudeLlmResponsesModelsAsync` | GET | `/v3/ai_optimization/claude/llm_responses/models` |
| `ClaudeLlmResponsesLiveAsync` | POST | `/v3/ai_optimization/claude/llm_responses/live` |
| `ClaudeLlmResponsesTaskPostAsync` | POST | `/v3/ai_optimization/claude/llm_responses/task_post` |
| `ClaudeLlmResponsesTasksReadyAsync` | GET | `/v3/ai_optimization/claude/llm_responses/tasks_ready` |
| `ClaudeLlmResponsesTaskGetAsync` | GET | `/v3/ai_optimization/claude/llm_responses/task_get/{id}` |
| `GeminiLlmResponsesModelsAsync` | GET | `/v3/ai_optimization/gemini/llm_responses/models` |
| `GeminiLlmResponsesTaskPostAsync` | POST | `/v3/ai_optimization/gemini/llm_responses/task_post` |
| `GeminiLlmResponsesTasksReadyAsync` | GET | `/v3/ai_optimization/gemini/llm_responses/tasks_ready` |
| `GeminiLlmResponsesTaskGetAsync` | GET | `/v3/ai_optimization/gemini/llm_responses/task_get/{id}` |
| `GeminiLlmResponsesLiveAsync` | POST | `/v3/ai_optimization/gemini/llm_responses/live` |
| `PerplexityLlmResponsesModelsAsync` | GET | `/v3/ai_optimization/perplexity/llm_responses/models` |
| `PerplexityLlmResponsesLiveAsync` | POST | `/v3/ai_optimization/perplexity/llm_responses/live` |
| `GeminiLlmScraperLocationsAsync` | GET | `/v3/ai_optimization/gemini/llm_scraper/locations` |
| `GeminiLlmScraperLanguagesAsync` | GET | `/v3/ai_optimization/gemini/llm_scraper/languages` |
| `GeminiLlmScraperTaskPostAsync` | POST | `/v3/ai_optimization/gemini/llm_scraper/task_post` |
| `GeminiLlmScraperTasksReadyAsync` | GET | `/v3/ai_optimization/gemini/llm_scraper/tasks_ready` |
| `GeminiLlmScraperTaskGetAdvancedAsync` | GET | `/v3/ai_optimization/gemini/llm_scraper/task_get/advanced/{id}` |
| `GeminiLlmScraperTaskGetHtmlAsync` | GET | `/v3/ai_optimization/gemini/llm_scraper/task_get/html/{id}` |
| `GeminiLlmScraperLiveAdvancedAsync` | POST | `/v3/ai_optimization/gemini/llm_scraper/live/advanced` |
| `GeminiLlmScraperLiveHtmlAsync` | POST | `/v3/ai_optimization/gemini/llm_scraper/live/html` |
| `AiKeywordDataAvailableFiltersAsync` | GET | `/v3/ai_optimization/ai_keyword_data/available_filters` |
| `AiKeywordDataLocationsAndLanguagesAsync` | GET | `/v3/ai_optimization/ai_keyword_data/locations_and_languages` |
| `AiKeywordDataKeywordsSearchVolumeLiveAsync` | POST | `/v3/ai_optimization/ai_keyword_data/keywords_search_volume/live` |
| `LlmMentionsAvailableFiltersAsync` | GET | `/v3/ai_optimization/llm_mentions/available_filters` |
| `LlmMentionsLocationsAndLanguagesAsync` | GET | `/v3/ai_optimization/llm_mentions/locations_and_languages` |
| `LlmMentionsSearchMentionsLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/search_mentions/live` |
| `LlmMentionsTargetMetricsLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/target_metrics/live` |
| `LlmMentionsMultiTargetMetricsLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/multi_target_metrics/live` |
| `LlmMentionsTopMentionedDomainsLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_domains/live` |
| `LlmMentionsTopMentionedPagesLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_pages/live` |
| `LlmMentionsTopMentionedBrandsLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_brands/live` |
| `LlmMentionsTopMentionedBrandCategoriesLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_brand_categories/live` |
| `LlmMentionsTargetMetricsLiteLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/target_metrics_lite/live` |
| `LlmMentionsTopMentionedDomainsLiteLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_domains_lite/live` |
| `LlmMentionsTopMentionedPagesLiteLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_pages_lite/live` |
| `LlmMentionsTopMentionedBrandsLiteLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_brands_lite/live` |
| `LlmMentionsTopMentionedBrandCategoriesLiteLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/top_mentioned_brand_categories_lite/live` |
| `LlmMentionsHistoricalLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/historical/live` |
| `LlmMentionsTimeseriesDeltaLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/timeseries_delta/live` |
| `LlmMentionsTimeseriesNewLostLiveAsync` | POST | `/v3/ai_optimization/llm_mentions/timeseries_new_lost/live` |