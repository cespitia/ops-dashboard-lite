# Ops Dashboard Lite

Blazor Server reliability dashboard MVP demonstrating:
- service status tracking (health state + last check)
- event log stored in SQL Server
- “Run Check” action simulating checks and persisting results

## Tech
- Blazor Server
- C# / .NET
- EF Core
- SQL Server (Docker)
- GitHub + docs

## Run Local

### 1) Start SQL Server (Docker)
```bash
docker rm -f odl-sqlserver 2>/dev/null || true

docker run \
  -e "ACCEPT_EULA=Y" \
  -e "MSSQL_SA_PASSWORD=Str0ngPassw0rd" \
  -p 1434:1433 \
  --name odl-sqlserver \
  -d mcr.microsoft.com/mssql/server:2022-latest