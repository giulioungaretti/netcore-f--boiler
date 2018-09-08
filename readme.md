# Fix type providers on net core with mono yolo!
Do this to avoid typing a lot 

`dotnet new sln -n MyApp`

` dotnet sln add src/MyConsoleApp/MyConsoleApp.fsproj `

1- install mono
follow this https://github.com/Thorium/SqlProvider/tree/master/tests/SqlProvider.Core.Tests/Postgres
2- install f# compiler

2- 
```shell
cd  src/MyConsoleApp
dotnet add package System.Console
dotnet add package System.Data.Common
dotnet add package System.Runtime
dotnet add package System.Runtime.Extensions
dotnet add package System.Reflection
dotnet add package System.Reflection.TypeExtensions
dotnet add package System.Runtime.Serialization.Formatters
dotnet add package System.Threading.Tasks.Extensions
mkdir libraries
cp
~/.nuget/packages/system.threading.tasks.extensions/4.5.1/lib/portable-net45+win8+wp8+wpa81/System.Threading.Tasks.Extensions.dll
~/src/netcore-fsharp-boiler/src/MyConsoleApp/libraries
cp ~/.nuget/packages/npgsql/4.0.2/lib/net451/Npgsql.dll  ~/src/netcore-fsharp-boiler/src/MyConsoleApp/libraries/
```






# dotnet cli

init:

`dotnet new console -lang F# -o src/MyConsoleApp`

add suave

` dotnet add src/MyConsoleApp/MyConsoleApp.fsproj package suave `

build:

` dotnet build src/MyConsoleApp/MyConsoleApp.fsproj `

run:

` dotnet run -p src/MyConsoleApp/MyConsoleApp.fsproj `

# vs code setup

requires some manual labor

NOTE: the paths that need to point to ther right spots

## launch.json

```json5
{
  // Use IntelliSense to learn about possible attributes.
  // Hover to view descriptions of existing attributes.
  // For more information, visit: https://go.microsoft.com/fwlink/?linkid=830387
  "version": "0.2.0",
  "configurations": [
    {
      "name": ".NET Core Launch (console)",
      "type": "coreclr",
      "request": "launch",
      "preLaunchTask": "build",
      // PROGRAM needs to be updated to maktch the location and framweork
      // netcore and .dll1
      "program": "${workspaceFolder}/src/MyConsoleApp/bin/Debug/netcoreapp2.0/MyConsoleApp.dll",
      "args": [],
      "cwd": "${workspaceFolder}",
      "console": "internalConsole",
      "stopAtEntry": false,
      "internalConsoleOptions": "openOnSessionStart"
    },
    {
      "name": ".NET Core Launch (web)",
      "type": "coreclr",
      "request": "launch",
      "preLaunchTask": "build",
      "program": "${workspaceFolder}/src/MyConsoleApp/bin/Debug/netcoreapp2.0/MyConsoleApp.dll",
      "args": [],
      "cwd": "${workspaceFolder}",
      "stopAtEntry": false,
      "internalConsoleOptions": "openOnSessionStart",
      "launchBrowser": {
        "enabled": true,
        "args": "${auto-detect-url}",
        "windows": {
          "command": "cmd.exe",
          "args": "/C start ${auto-detect-url}"
        },
        "osx": {
          "command": "open"
        },
        "linux": {
          "command": "xdg-open"
        }
      },
      "env": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      },
      "sourceFileMap": {
        "/Views": "${workspaceFolder}/Views"
      }
    },
    {
      "name": ".NET Core Attach",
      "type": "coreclr",
      "request": "attach",
      "processId": "${command:pickProcess}"
    }
  ]
}
```

## task.json

```json5
{
  // See https://go.microsoft.com/fwlink/?LinkId=733558
  // for the documentation about the tasks.json format
  "version": "2.0.0",
  "tasks": [
    {
      "label": "build",
      // COMMAND needs to be updated obvs
      "command": "dotnet build src/MyConsoleApp/MyConsoleApp.fsproj",
      "type": "shell",
      "group": "build",
      "presentation": {
        "reveal": "silent"
      },
      "problemMatcher": "$msCompile"
    }
  ]
}
```
