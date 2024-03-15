string expectedHash = "f6f5609134d4006a16b96c2ca3be32acf7492bb7db233690204141a95952077018dc5f1503fd4dedf7ec44253a3427373fa21dab778a3b3d3d3d37df90c11228";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.203-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);