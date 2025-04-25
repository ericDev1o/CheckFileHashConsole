string expectedHash = "0bbddfce63ff99ef3bcc4d8af9f4c6793af9902470722c018476f04c713e440b";
string path = @"C:\softwareDownloads\gimp-3.0.2-setup-1.exe";
string SHA = "SHA256";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);