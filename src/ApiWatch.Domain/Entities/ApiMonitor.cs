using ApiWatch.Domain.Enums;

namespace ApiWatch.Domain.Entities
{
    public class ApiMonitor
    {
        public Guid Id { get; set; }
        public Guid OrganizationId{ get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public HttpMethodType Method { get; set; }
        public int IntervalSeconds { get; set; }
        public int TimeoutMs { get; set; }
        public bool Enabled { get; set; }
        public DateTimeOffset NextRunAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }


    }
}
