string expectedHash = "f8f3002242c76b5eb786b8c7788556563a22151a7e09032e7b0edcf4de17c3c69cf7f8dd598b2c5752df62d40798bcc4bc63f6bed8ce377d0938fe8b0ce631d1";
string path = @"C:\softwareDownloads\dotnet-sdk-9.0.100-rc.1.24452.12-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);