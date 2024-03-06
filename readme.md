# checkFileHashConsole
## usage
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
### used
* after download and check a file for viruses,
* to checksum the file integrity with this hash tool.
### how
in the terminal
* change in Program.cs the checksum and directory values
* dotnet build -c release ./CheckFileHash.csproj
* dotnet run -c release --no-build --no-restore ./CheckFileHash.csproj