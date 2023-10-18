string expectedHash = "f4c4ebdaa684b2f7cee1b0034749dcde2a6c8b9a5e45fe4b6f1ff4c918367b6e59d23ec1f70a2db3a7ec9867f85507615aa0467a35406b08ed925ec5abf4b49a";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.100-rc.2.23502.2-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);