# MerchantApi

Knowledge base for `dfsClient.MerchantApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

E-commerce data from marketplaces and shopping search engines such as Amazon and Google Shopping: product listings for a search query, product details, product variations, sellers and their offers, with prices, ratings, reviews count and paid placements.

Results are collected for the requested location and language, the same way a real shopper would see them, and are returned as parsed data or raw HTML.

## Use it when you need

- Which products appear for a search query on a marketplace, in which order, and which of them are sponsored.
- Details of a specific product: description, specifications, price, rating, variations.
- Who sells a product and at what price and conditions, for price monitoring and competitor analysis.

## Use another API when

- You need keyword metrics or ranked keywords for marketplace products: `DataforseoLabsApi`.
- You need shopping elements that appear inside regular search results: `SerpApi`.
- You need mobile apps rather than products: `AppDataApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### GoogleSellersTaskGetAdvancedAsync

`GET /v3/merchant/google/sellers/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.MerchantApi.GoogleSellersTaskGetAdvancedAsync(id);
```

### GoogleSellersTaskPostAsync

`POST /v3/merchant/google/sellers/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.MerchantApi.GoogleSellersTaskPostAsync(new List<MerchantGoogleSellersTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        ProductId = "1113158713975221117",
    }
});
```

### GoogleProductsTaskGetAdvancedAsync

`GET /v3/merchant/google/products/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.MerchantApi.GoogleProductsTaskGetAdvancedAsync(id);
```

### GoogleProductsTaskPostAsync

`POST /v3/merchant/google/products/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.MerchantApi.GoogleProductsTaskPostAsync(new List<MerchantGoogleProductsTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "iphone",
        PriceMin = 5,
    }
});
```

### AmazonProductsTaskGetAdvancedAsync

`GET /v3/merchant/amazon/products/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.MerchantApi.AmazonProductsTaskGetAdvancedAsync(id);
```

### AmazonProductsTaskPostAsync

`POST /v3/merchant/amazon/products/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.MerchantApi.AmazonProductsTaskPostAsync(new List<MerchantAmazonProductsTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en_US",
        LocationCode = 2840,
        Keyword = "shoes",
    }
});
```

### GoogleProductInfoTaskGetAdvancedAsync

`GET /v3/merchant/google/product_info/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.MerchantApi.GoogleProductInfoTaskGetAdvancedAsync(id);
```

### GoogleProductInfoTaskPostAsync

`POST /v3/merchant/google/product_info/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.MerchantApi.GoogleProductInfoTaskPostAsync(new List<MerchantGoogleProductInfoTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        ProductId = "1113158713975221117",
    }
});
```

### AmazonSellersTaskGetAdvancedAsync

`GET /v3/merchant/amazon/sellers/task_get/advanced/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.MerchantApi.AmazonSellersTaskGetAdvancedAsync(id);
```

## Endpoints

All methods of `MerchantApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `MerchantIdListAsync` | POST | `/v3/merchant/id_list` |
| `MerchantErrorsAsync` | POST | `/v3/merchant/errors` |
| `MerchantGoogleLanguagesAsync` | GET | `/v3/merchant/google/languages` |
| `MerchantGoogleLocationsAsync` | GET | `/v3/merchant/google/locations` |
| `MerchantGoogleLocationsCountryAsync` | GET | `/v3/merchant/google/locations/{country}` |
| `GoogleProductsTaskPostAsync` | POST | `/v3/merchant/google/products/task_post` |
| `GoogleProductsTasksReadyAsync` | GET | `/v3/merchant/google/products/tasks_ready` |
| `MerchantTasksReadyAsync` | GET | `/v3/merchant/tasks_ready` |
| `GoogleProductsTaskGetAdvancedAsync` | GET | `/v3/merchant/google/products/task_get/advanced/{id}` |
| `GoogleProductsTaskGetHtmlAsync` | GET | `/v3/merchant/google/products/task_get/html/{id}` |
| `GoogleSellersTaskPostAsync` | POST | `/v3/merchant/google/sellers/task_post` |
| `GoogleSellersTasksReadyAsync` | GET | `/v3/merchant/google/sellers/tasks_ready` |
| `GoogleSellersTaskGetAdvancedAsync` | GET | `/v3/merchant/google/sellers/task_get/advanced/{id}` |
| `GoogleProductInfoTaskPostAsync` | POST | `/v3/merchant/google/product_info/task_post` |
| `GoogleProductInfoTasksReadyAsync` | GET | `/v3/merchant/google/product_info/tasks_ready` |
| `GoogleProductInfoTaskGetAdvancedAsync` | GET | `/v3/merchant/google/product_info/task_get/advanced/{id}` |
| `GoogleSellersAdUrlAsync` | GET | `/v3/merchant/google/sellers/ad_url/{shop_ad_aclk}` |
| `AmazonLocationsAsync` | GET | `/v3/merchant/amazon/locations` |
| `AmazonLocationsCountryAsync` | GET | `/v3/merchant/amazon/locations/{country}` |
| `AmazonLanguagesAsync` | GET | `/v3/merchant/amazon/languages` |
| `AmazonProductsTaskPostAsync` | POST | `/v3/merchant/amazon/products/task_post` |
| `AmazonProductsTasksReadyAsync` | GET | `/v3/merchant/amazon/products/tasks_ready` |
| `AmazonProductsTaskGetAdvancedAsync` | GET | `/v3/merchant/amazon/products/task_get/advanced/{id}` |
| `AmazonProductsLiveAdvancedAsync` | POST | `/v3/merchant/amazon/products/live/advanced` |
| `AmazonProductsTaskGetHtmlAsync` | GET | `/v3/merchant/amazon/products/task_get/html/{id}` |
| `AmazonProductsLiveHtmlAsync` | POST | `/v3/merchant/amazon/products/live/html` |
| `AmazonAsinTaskPostAsync` | POST | `/v3/merchant/amazon/asin/task_post` |
| `AmazonAsinTasksReadyAsync` | GET | `/v3/merchant/amazon/asin/tasks_ready` |
| `AmazonAsinTaskGetAdvancedAsync` | GET | `/v3/merchant/amazon/asin/task_get/advanced/{id}` |
| `AmazonAsinLiveAdvancedAsync` | POST | `/v3/merchant/amazon/asin/live/advanced` |
| `AmazonAsinTaskGetHtmlAsync` | GET | `/v3/merchant/amazon/asin/task_get/html/{id}` |
| `AmazonAsinLiveHtmlAsync` | POST | `/v3/merchant/amazon/asin/live/html` |
| `AmazonSellersTaskPostAsync` | POST | `/v3/merchant/amazon/sellers/task_post` |
| `AmazonSellersTasksReadyAsync` | GET | `/v3/merchant/amazon/sellers/tasks_ready` |
| `AmazonSellersTaskGetAdvancedAsync` | GET | `/v3/merchant/amazon/sellers/task_get/advanced/{id}` |
| `AmazonSellersLiveAdvancedAsync` | POST | `/v3/merchant/amazon/sellers/live/advanced` |
| `AmazonSellersTaskGetHtmlAsync` | GET | `/v3/merchant/amazon/sellers/task_get/html/{id}` |
| `AmazonSellersLiveHtmlAsync` | POST | `/v3/merchant/amazon/sellers/live/html` |