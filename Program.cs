string expectedHash = "53a429eec91b4335d2ff1822bd2b41c826b06a53d187d24645a991066f28498d93f06557bd1c471a9334dc02bcdb3b6d075cfa9d6c894bdfc0f29c0b6e0d7a02";
string path = @"C:\softwareDownloads\dotnet-sdk-9.0.100-preview.7.24407.12-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);