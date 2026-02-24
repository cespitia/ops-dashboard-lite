
### `docs/ARCHITECTURE.md` (paste)
```md
# Architecture

Blazor Server UI uses EF Core (DbContext) to persist operational data in SQL Server.

Blazor Server → EF Core DbContext → SQL Server

## Features
- Dashboard: monitored services + current status + last check timestamp
- Run Check: simulate checks and write statuses + events to DB
- Event Log: display recent events stored in DB

## Tables
- MonitoredService
- ServiceStatus
- EventLog