

namespace IoTTelemetryPlatform.Controllers
{
    using IoTTelemetryPlatform.Models.Device;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private static readonly List<Device> Devices = new List<Device>
        {
            new Device("1", "Sensor", "1.0", "Active"),
            new Device("2", "Actuator", "1.0", "Inactive"),
            new Device("3", "Gateway", "1.0", "Active")
        };

        [HttpGet]
        public IEnumerable<Device> Get()
        {
            return Devices;
        }

        [HttpGet("{id}")]
        public ActionResult<Device> Get(string id)
        {
            var device = Devices.FirstOrDefault(d => d.Id == id);
            if (device == null)
            {
                return NotFound();
            }
            return device;
        }

        [HttpPost]
        public ActionResult<Device> Post([FromBody] Device device)
        {
            if (device == null)
            {
                return BadRequest();
            }
            Devices.Add(device);
            return CreatedAtAction(nameof(Get), new { id = device.Id }, device);
        }
    }
}
