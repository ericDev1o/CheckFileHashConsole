string expectedHash = "4fc5817f8bfd86bdb3af924d3ca32e349517710ac5f986ae20f765f79285e00b";
string path = @"/home/utilisateur/Téléchargements/ideaIC-2023.2.5.tar.gz";
string SHA = "SHA256";
CheckFileHash.Helpers.HashHelpers.MatchHashes
(
    expectedHash, 
    CheckFileHash.Helpers.HashHelpers.Compute(path, SHA)
);