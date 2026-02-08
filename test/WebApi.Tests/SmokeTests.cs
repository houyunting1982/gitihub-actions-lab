using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApi.Tests;

public class SmokeTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public SmokeTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task WeatherForecast_Works()
    {
        var res = await _client.GetAsync("/weatherforecast");
        res.EnsureSuccessStatusCode();
    }
}
