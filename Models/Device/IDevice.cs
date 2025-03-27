namespace IoTTelemetryPlatform.Models.Device
{
    public interface IDevice
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string FirmWareVersion { get; set; }
        public string Status { get; set; }
    }
}
