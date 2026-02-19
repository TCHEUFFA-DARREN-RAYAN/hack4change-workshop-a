namespace Hack4Change.API.Tests;

using Xunit;
using Hack4Change.API;

public class MessageProviderTests
{
    private const string WELCOME = "Welcome to the Hack4Change Web Server";

    [Fact]
    public void MessageProvider_WelcomeMessage_ReturnsCorrectMessage()
    {
        Assert.Equal(WELCOME, MessageProvider.WelcomeMessage);
    }
}
