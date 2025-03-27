namespace IoTTelemetryPlatform.Models.LogMessage
{
    public class TelemetryMessage : ITelemetryMessage
    {
        public string Id { get; set; }
        public string DeviceId { get; set; }
        public DateTime Timestamp { get; set; }
        public string DataType { get; set; }
        public float Value { get; set; }
        public string Metadata { get; set; }
        public TelemetryMessage(string id, string deviceId, DateTime timestamp, string dataType, float value, string metadata)
        {
            Id = id;
            DeviceId = deviceId;
            Timestamp = timestamp;
            DataType = dataType;
            Value = value;
            Metadata = metadata;
        }
    }
}
