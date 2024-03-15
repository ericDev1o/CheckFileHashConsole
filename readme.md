# checkFileHashConsole
## usage
### 06/03/2024 09:21
This tool's usage is on stand-by.
C:\softwareDownloads>winget update Microsoft.DotNet.SDK.8
Found Microsoft .NET SDK 8.0 [Microsoft.DotNet.SDK.8] Version 8.0.201
This application is licensed to you by its owner.
Microsoft is not responsible for, nor does it grant any licenses to, third-party packages.
Downloading https://dotnetcli.azureedge.net/dotnet/Sdk/8.0.201/dotnet-sdk-8.0.201-win-x64.exe
  ██████████████████████████████   221 MB /  221 MB
Successfully verified installer hash
Starting package install...
Successfully installed

C:\softwareDownloads>

PS C:\Users\ericf\source\repos\CheckFileHashConsole> dotnet --version
8.0.201
PS C:\Users\ericf\source\repos\CheckFileHashConsole> 

No further check is planned.
### 15/03/2024 17:30
8.0.203 SDK isn't found by winget update Microsoft.DotNet.SDK.8
    => cold to warm tool usage
        download the installer and note the SHA512 hash
        update the Program.cs file
        dotnet clean .\CheckFileHash.csproj
        dotnet build -c release .\CheckFileHash.csproj
        dotnet run --no-build --no-restore .\CheckFileHAsh.csproj
### used
* after download and check a file for viruses,
* to checksum the file integrity with this hash tool.
### how
in the terminal
* change in Program.cs the checksum and directory values
* dotnet build -c release ./CheckFileHash.csproj
* dotnet run -c release --no-build --no-restore ./CheckFileHash.csproj