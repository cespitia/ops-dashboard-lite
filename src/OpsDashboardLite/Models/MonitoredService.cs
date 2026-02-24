using System.ComponentModel.DataAnnotations;

namespace OpsDashboardLite.Models;

public class MonitoredService
{
    public int Id { get; set; }

    [Required, StringLength(80)]
    public string Name { get; set; } = string.Empty;

    [StringLength(200)]
    public string EndpointUrl { get; set; } = string.Empty;

    public ICollection<ServiceStatus> Statuses { get; set; } = new List<ServiceStatus>();
    public ICollection<EventLog> Events { get; set; } = new List<EventLog>();
}