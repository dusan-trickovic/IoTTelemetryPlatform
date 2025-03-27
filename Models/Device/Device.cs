namespace IoTTelemetryPlatform.Models.Device
{
    public class Device : IDevice
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string FirmWareVersion { get; set; }
        public string Status { get; set; }

        public Device(string id, string type, string firmWareVersion, string status)
        {
            Id = id;
            Type = type;
            FirmWareVersion = firmWareVersion;
            Status = status;
        }
    }
}
