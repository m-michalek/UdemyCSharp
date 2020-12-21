# Setup 

## Database:

- Download and run myscql server in docker container:

```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<sql-user-password>!234' -p 1433:1433 -v </path/to/db/directory>/data:/var/opt/mssql/data -v </path/to/db/directory>/log:/var/opt/mssql/log -v </path/to/db/directory>/secrets:/var/opt/mssql/secrets -d mcr.microsoft.com/mssql/server:2019-latest
```

## Project

- Created via Rider as `ASP .NET Core Web Application > Web API`

- Add to following code to `.csproj`
```xml
<ItemGroup>
    <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="2.0.0" />
</ItemGroup>
```

- Run `dotnet restore`

- From now on start the project via `dotnet watch run`
    - In Rider: Navigate to Edit Configurations at Runtime Arguments add `watch run`  