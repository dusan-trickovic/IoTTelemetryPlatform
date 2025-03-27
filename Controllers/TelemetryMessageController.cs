
namespace IoTTelemetryPlatform.Controllers
{
    using IoTTelemetryPlatform.Models.LogMessage;
    using Microsoft.AspNetCore.Mvc;

    public class TelemetryMessageController : Controller
    {
        [HttpGet]
        public IActionResult GetTelemetryMessages()
        {
            // Simulate fetching telemetry messages from a database or service
            var telemetryMessages = new List<TelemetryMessage>
            {
                new TelemetryMessage("1", "Device1", DateTime.UtcNow, "Temperature", 22.5f, "Room1"),
                new TelemetryMessage("2", "Device2", DateTime.UtcNow, "Humidity", 45.0f, "Room2")
            };
            return Ok(telemetryMessages);
        }
        [HttpPost]
        public IActionResult PostTelemetryMessage([FromBody] TelemetryMessage message)
        {
            if (message == null)
            {
                return BadRequest("Invalid telemetry message.");
            }
            // Simulate saving the telemetry message to a database or service
            // ...
            return CreatedAtAction(nameof(GetTelemetryMessages), new { id = message.Id }, message);
        }
    }
}
