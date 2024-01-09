string expectedHash = "5de43de4f468dbaeb1b0bca6cf4774daf2c4ef8594451f1674a9a4a65149335ee956abaad4492be636161ed3d3eb5072099aafd344f94b0b55e04acba255d246";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.101-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);