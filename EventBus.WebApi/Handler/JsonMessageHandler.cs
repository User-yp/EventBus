
namespace EventBus.WebApi.Handler;

[EventName("JsonMsgListening")]
public class JsonMessageHandler : JsonIntegrationEventHandler<JsonMessage>
{
    public override Task HandleJson(string eventName, JsonMessage? eventData)
    {
        Console.WriteLine(eventData);
        return Task.CompletedTask;
    }
}
