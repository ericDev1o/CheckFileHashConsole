# checkFileHashConsole
## usage
### used
* after download and check a file for viruses,
* to checksum the file integrity with this hash tool.
### how
in the terminal
* change in Program.cs the checksum and directory values
* dotnet build -c release ./CheckFileHash.csproj
* dotnet run -c release --no-build --no-restore ./CheckFileHash.csproj