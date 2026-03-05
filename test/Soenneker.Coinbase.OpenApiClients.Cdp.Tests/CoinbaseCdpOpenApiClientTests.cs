using Soenneker.Coinbase.OpenApiClients.Cdp.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Coinbase.OpenApiClients.Cdp.Tests;

[Collection("Collection")]
public sealed class CoinbaseCdpOpenApiClientTests : FixturedUnitTest
{
    private readonly ICoinbaseCdpOpenApiClient _openapiclient;

    public CoinbaseCdpOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _openapiclient = Resolve<ICoinbaseCdpOpenApiClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
