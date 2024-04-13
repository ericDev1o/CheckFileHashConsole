string expectedHash = "9c3bf9c027131a3ad9f66667c609b19e8846af795fa5a88558b49c6d6011d571aa1faea76f7b6a2dc5f5eb30d9ab5db7a4a9bea2348642b23c9968a4b73f3c11";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.204-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);