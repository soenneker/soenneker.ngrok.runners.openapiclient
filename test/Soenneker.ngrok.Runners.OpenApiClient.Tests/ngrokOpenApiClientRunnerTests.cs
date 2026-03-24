using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ngrok.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ngrokOpenApiClientRunnerTests : FixturedUnitTest
{
    public ngrokOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
