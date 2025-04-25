# checkFileHashConsole
## usage
Use case: your needed file version isn't found by 
C:\> winget update

### fallback on manual hash check
### download the installer and read the SHA512/384/256 hash
### check for viruses
### run
1) change in Program.cs the checksum and directory values

* linux
2) dotnet clean ./CheckFileHash.csproj
3) dotnet build -c release ./CheckFileHash.csproj
4) dotnet run -c release --no-build --no-restore ./CheckFileHash.csproj

* Windows
2) dotnet clean .\CheckFileHash.csproj
3) dotnet build -c release .\CheckFileHash.csproj
4) dotnet run --no-build --no-restore .\CheckFileHash.csproj

##### about this topic
https://massgrave.dev/genuine-installation-media#verify-authenticity-of-files
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

##### alternatives for better used open source project time
###### 7-Zip
right-click -> 7-Zip -> CRC SHA
###### interest point
consider this mean to check for the SHA512 availability:
* try right-click -> 7-Zip
* observe the possibly reliable page https://msdn.rg-adguard.net/ 
* why possibly reliable? C.f. ChatGPT Ad-Guard.net, as the official website of the AdGuard company, seems to be.