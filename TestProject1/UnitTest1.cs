using Demo_Landing_Page_GitHubActions.Services;

namespace Demo_Landing_Page_GitHubActions.Tests;

public class GreetingServiceTests
{
    [Fact]
    public void GetGreeting_WithName_ReturnsCorrectGreeting()
    {
        // Arrange
        var service = new GreetingService();

        // Act
        var result = service.GetGreeting("Mario");

        // Assert
        Assert.Equal(
            "Ciao Mario! Benvenuto!",
            result);
    }
}