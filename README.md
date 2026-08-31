[![](https://img.shields.io/nuget/v/soenneker.coinbase.openapiclients.cdp.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.coinbase.openapiclients.cdp/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.coinbase.openapiclients.cdp/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.coinbase.openapiclients.cdp/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.coinbase.openapiclients.cdp.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.coinbase.openapiclients.cdp/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.coinbase.openapiclients.cdp/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.coinbase.openapiclients.cdp/actions/workflows/codeql.yml)

# Soenneker.Coinbase.OpenApiClients.Cdp

A generated .NET client for Coinbase Developer Platform APIs, including payments, wallets, transfers, onchain operations, and x402 endpoints.

## Installation

```bash
dotnet add package Soenneker.Coinbase.OpenApiClients.Cdp
```

## Usage

The client uses a Kiota request adapter. For an endpoint that does not require authentication, construct it with `AnonymousAuthenticationProvider`:

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Coinbase.OpenApiClients.Cdp;

var authenticationProvider = new AnonymousAuthenticationProvider();
using var adapter = new HttpClientRequestAdapter(authenticationProvider);
var client = new CoinbaseCdpOpenApiClient(adapter);

var supportedPayments = await client.V2.X402.Supported.GetAsync(
    cancellationToken: cancellationToken);
```

The request adapter defaults to `https://api.cdp.coinbase.com/platform`. Set `adapter.BaseUrl` before constructing the client if you need a different endpoint.

## Authentication

Authentication varies by CDP API. Supply an `IAuthenticationProvider` that adds the credential required by the endpoints you call, such as a CDP JWT, an end-user token, or an OAuth bearer token. Avoid placing a short-lived token in `HttpClient.DefaultRequestHeaders` when the client is long-lived; an authentication provider can generate or retrieve the correct token for every request.

## Calling endpoints

Kiota exposes the API as nested request builders. Path values are selected with `By...` methods or indexers, request bodies use types from `Soenneker.Coinbase.OpenApiClients.Cdp.Models`, and request-specific headers or query parameters are supplied through the optional request-configuration callback. Generated methods accept a `CancellationToken`.
