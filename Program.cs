string expectedHash = "696d9b5b931114be12eab8cc81fd7403a5143ada38d8b0f2423e148d85309dc66602c86dfed6dce40f4ce1e0d141d01c774b3d34750f3d294673ca5b7c67649d";
string path = @"C:\softwareDownloads\dotnet-sdk-8.0.200-win-x64.exe";
string SHA = "SHA512";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);