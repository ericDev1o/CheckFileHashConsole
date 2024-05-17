string expectedHash = "8f0c9a65095750bd5356871d7fbb123a439e92eb10f4bdb1af894d1e7c3ad087d1bf7706def0bd39cda55f8251f45d245122dd2b19c28fb39e260e9ded735a6c";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.300-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);