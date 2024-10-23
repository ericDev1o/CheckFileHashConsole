string expectedHash = "29091a2b4d08f7fdc77065f2805a82afae0129a6b886caec71124016843a29c6abcec828794aef1c9a73a84df3f7b7258863991f61a780ea362575da0ca6879b";
string path = @"C:\softwareDownloads\dotnet-sdk-9.0.100-rc.2.24474.11-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);