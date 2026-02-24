using Microsoft.EntityFrameworkCore;
using OpsDashboardLite.Models;

namespace OpsDashboardLite.Data;

public class OpsDbContext : DbContext
{
    public OpsDbContext(DbContextOptions<OpsDbContext> options) : base(options) { }

    public DbSet<MonitoredService> Services => Set<MonitoredService>();
    public DbSet<ServiceStatus> ServiceStatuses => Set<ServiceStatus>();
    public DbSet<EventLog> EventLogs => Set<EventLog>();
}