using System.ComponentModel.DataAnnotations;

namespace OpsDashboardLite.Models;

public class EventLog
{
    public int Id { get; set; }

    public int MonitoredServiceId { get; set; }
    public MonitoredService? MonitoredService { get; set; }

    [Required, StringLength(20)]
    public string Severity { get; set; } = "Info"; // Info | Warning | Error

    [Required, StringLength(600)]
    public string Message { get; set; } = string.Empty;

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}