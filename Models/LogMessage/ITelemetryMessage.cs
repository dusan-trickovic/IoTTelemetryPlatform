namespace IoTTelemetryPlatform.Models.LogMessage
{
    public interface ITelemetryMessage
    {
        public string Id { get; set; }
        public string DeviceId { get; set; }
        public DateTime Timestamp { get; set; }
        public string DataType { get; set; }
        public float Value { get; set; }
        public string Metadata { get; set; }
    }
}
