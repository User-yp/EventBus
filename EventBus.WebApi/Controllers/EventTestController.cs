using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EventBus.WebApi.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class EventTestController : ControllerBase
{
    private readonly IEventBus eventBus;

    public EventTestController(IEventBus eventBus)
    {
        this.eventBus = eventBus;
    }

    [HttpPut]
    public async Task<ActionResult<string>> CommonMsgListeningAsync([FromQuery] string message)
    {
        eventBus.Publish("CommonMsgListening", message);
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<string>> JsonMsgListeningAsync([FromBody] JsonMessage jsonMessage)
    {;
        eventBus.Publish("JsonMsgListening", jsonMessage);
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<string>>DynamicMsgListeningAsync([FromQuery] DynamicMessage dynamicMessage)
    {
        eventBus.Publish("DynamicMsgListening", new {dynamicMessage.Id,dynamicMessage.Message,GetTime=DateTime.Now});
        return Ok();
    }

}
