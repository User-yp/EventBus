namespace EventBus.WebApi.Handler;

[EventName("CommonMsgListening")]
public class CommonMsgHandler : IIntegrationEventHandler
{
    public Task Handle(string eventName, string eventData)
    {
        Console.WriteLine(eventData);
        return Task.CompletedTask;
    }
}
