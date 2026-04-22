using Soenneker.Tests.HostedUnit;

namespace Soenneker.ngrok.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ngrokOpenApiClientRunnerTests : HostedUnitTest
{
    public ngrokOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
