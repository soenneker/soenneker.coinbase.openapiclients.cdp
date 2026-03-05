using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Coinbase.OpenApiClients.Cdp.Tests;

[Collection("Collection")]
public sealed class CoinbaseCdpOpenApiClientTests : FixturedUnitTest
{
    public CoinbaseCdpOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
