# EF Core useful commands

All Commands in here are meant to be run from the command line, from one of the project folders.
## Running migrations 

You can run command using `Command-line` or `Terminal` from:
1. `Interview/RL.Backend/`
2. `Interview/RL.Data/`

```
oec-interview
    Interview 
        RL.Backend      <-- Run commands from here
        RL.BackendUnitTests
        RL.Data         <-- Run commands from here
```

## Add Migration

Command allows you to create a new migration based on the changes made to the data model
```shell
dotnet ef migrations add InitialCreate --startup-project ../RL.Backend/RL.Backend.csproj --project ..\RL.Data\RL.Data.csproj --context RLContext --output-dir Migrations
```

## Apply Migration
Command applies the latest migration to the SQL Lite database found in the RL.Backend project 
```shell
dotnet ef database update --startup-project ../RL.Backend/RL.Backend.csproj --project ../RL.Data/RL.Data.csproj --context RLContext 
```
