using Soenneker.Tests.HostedUnit;

namespace Soenneker.Coinbase.OpenApiClients.Cdp.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CoinbaseCdpOpenApiClientTests : HostedUnitTest
{
    public CoinbaseCdpOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
