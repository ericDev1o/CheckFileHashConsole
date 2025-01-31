string expectedHash = "91505782b13937392bd73d1531c01807275ef476f9e37f8ef22c2cee4b19be8282207149b4eb958668dee0c05cef02b0a6bc375b71e8e94864c3d89dea7ba534";
string path = @"C:\softwareDownloads\dotnet-sdk-9.0.102-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);