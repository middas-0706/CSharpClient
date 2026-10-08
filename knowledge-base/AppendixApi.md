# AppendixApi

Knowledge base for `dfsClient.AppendixApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Account and service information that applies to the whole DataForSEO API rather than to a data source: account balance, spending, limits and prices, the current status of the APIs, the list of error codes, and re-sending webhooks (pingbacks and postbacks) of completed tasks.

## Use it when you need

- To check credentials and connectivity, or the remaining balance and limits before running a job.
- To find out whether a problem is on DataForSEO's side.
- The meaning of an error code returned in a response.
- To receive webhooks of finished tasks again, for example after your receiving endpoint was unavailable.

This section returns no SEO or marketing data; for that use the other API classes listed in SKILL.md.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### UserDataAsync

`GET /v3/appendix/user_data`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppendixApi.UserDataAsync();
```

### AppendixStatusAsync

`GET /v3/appendix/status`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppendixApi.AppendixStatusAsync();
```

### ErrorsAsync

`GET /v3/appendix/errors`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppendixApi.ErrorsAsync();
```

## Endpoints

All methods of `AppendixApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `UserDataAsync` | GET | `/v3/appendix/user_data` |
| `ErrorsAsync` | GET | `/v3/appendix/errors` |
| `WebhookResendAsync` | POST | `/v3/appendix/webhook_resend` |
| `AppendixStatusAsync` | GET | `/v3/appendix/status` |