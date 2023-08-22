string expectedHash = "98cbbca364f4a2f36086cf54c218c65fa7de166c8bf04c15dbdd6d8326b6691e738e88d31b6e3b969d36a094c76af007a2d5fe17cdd10a30323ff2c0907b208b";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.100-preview.7.23376.3-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);