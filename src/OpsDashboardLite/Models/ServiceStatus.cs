using System.ComponentModel.DataAnnotations;

namespace OpsDashboardLite.Models;

public class ServiceStatus
{
    public int Id { get; set; }

    public int MonitoredServiceId { get; set; }
    public MonitoredService? MonitoredService { get; set; }

    [Required, StringLength(20)]
    public string State { get; set; } = "Unknown"; // Healthy | Degraded | Unhealthy | Unknown

    public DateTime CheckedAtUtc { get; set; } = DateTime.UtcNow;

    [StringLength(400)]
    public string Message { get; set; } = string.Empty;
}