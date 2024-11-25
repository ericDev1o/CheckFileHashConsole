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
### 17/05/2024 13:00
winget update 
    Ok from 8.0.204 to 8.0.205
    Ko to 8.0.300
### 14/06/2024 15:55
PS C:\Users\ericf\source\repos\CheckFileHashConsole> winget update Microsoft.DotNet.SDK.8
No installed package found matching input criteria.
PS C:\Users\ericf\source\repos\CheckFileHashConsole> dotnet --version
8.0.301
PS C:\Users\ericf\source\repos\CheckFileHashConsole> 
### 16/07/2024
0x80070643 error installing dotnet 8.0.303
SHA512 69c7195d859b3ca0757fa1bf367e839c050996ba8e46568130b722d987177d3d3e025dfb9be6ba3da3e83d3c1e7a4ebba6cdaebd31ee4677a8fd4a74971ca0a1
### 21/08/2024
About August 13th SDK 90.100-preview.7 you'll find below this tool's alternatives for possible better use of one'e time on open source project(s):
https://massgrave.dev/genuine-installation-media#verify-authenticity-of-files

The unlinked extract being:
"
You can use the file hashing method to verify if a file is genuine. This can be done using tools like 7-Zip (After installing 7-Zip, right-click on the ISO file and go to 7-Zip > CRC SHA).

There are many places where you can find these checksums for verification. Examples can be found below.

files.rg-adguard (the most complete collection)
MVS dump
genuine-iso-verifier
msdn.rg-adguard
sha1.rg-adguard
Google
Microsoft's Official free links for checksums:

MVS
Windows 11
Windows 10
"

Despite the progress bar no sucess message is displayed.
### 23/10/24
PS C:\Users\ericf\source\repos\CheckFileHashConsole> winget update Microsoft.DotNet.SDK.9
No installed package found matching input criteria.
==> fallback to previous manual hash usage is done.
### 25/11/24
winget is OK and reread.
### used
* after download and check a file for viruses,
* to checksum the file integrity with this hash tool.
### how
in the terminal
* change in Program.cs the checksum and directory values
* dotnet build -c release ./CheckFileHash.csproj
* dotnet run -c release --no-build --no-restore ./CheckFileHash.csproj

#### alternatives for better used open source project time
##### 7-Zip
###### steps
right-click -> 7-Zip -> CRC SHA
###### interest point
consider as means to check for the SHA512 availability:
  - try right-click -> 7-Zip
      - observe the possibly reliable page https://msdn.rg-adguard.net/ 
        - why possibly reliable? C.f. ChatGPT Ad-Guard.net, as the official website of the AdGuard company, seems to be.