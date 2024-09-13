
namespace EventBus.WebApi.Handler;

[EventName("DynamicMsgListening")]
public class DynamicMessageHandler : DynamicIntegrationEventHandler
{
    public override Task HandleDynamic(string eventName, dynamic eventData)
    {
        var id=(int) eventData.Id;
        var message=(string)eventData.Message;
        var getTime=(DateTime)eventData.GetTime;
        Console.WriteLine($"{id}-{message}-{getTime}");
        return Task.CompletedTask;
    }
}
