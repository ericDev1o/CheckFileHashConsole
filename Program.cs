string expectedHash = "b28a3f288a151a6a6e76ffd28a33ab92712a8308165819d469cacb1c547168a2bf7f78b975346cdf7b3f01b2d9b50070935588adc0ae1d03cfaff0744242423e";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.100-rc.1.23463.5-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);