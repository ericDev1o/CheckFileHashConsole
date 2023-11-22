string expectedHash = "248acec95b381e5302255310fb9396267fd74a4a2dc2c3a5989031969cb31f8270cbd14bda1bc0352ac90f8138bddad1a58e4af1e56cc4a1613b1cf2854b518e";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.100-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);