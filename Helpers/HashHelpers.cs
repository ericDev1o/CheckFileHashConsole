namespace CheckFileHash.Helpers;
/*
<summary>
    This class is used to check a downloaded file's hash:
        1) use a given hash algorithm. SHA512 by default down to SHA256,
        2) compute the downloaded file's hash at the given absolute path,
        3) match and format the comparison output.
    It displays OK or KO with the hash value.
</summary>
*/
public class HashHelpers
{
    /*
    <summary>
        Displays the result with details: OK or KO match and hash.
    </summary>
    <param name="expectedHash">Hash given by download source.</param>
    <param name="computedHash">Hash computed by Compute helper tool.</param>
    <returns>A sentence with the result: OK or KO and value for verbose double check.</returns>
    */
    public static void MatchHashes(string expectedHash, string computedHash)
    {
        if(computedHash == expectedHash)
            Console.WriteLine($"OK: expected hash is {expectedHash}, computed hash is {computedHash}");
        else Console.WriteLine($"KO: expected is {expectedHash}, computed hash is {computedHash}");
    }

    /*
    <summary>
        Helper tool that formats the computed hash.
    </summary>
    <param name="path">absolute downloaded file's path</param>
    <param name="SHA">user's HashAlgorithm that computes, by default SHA512.</param>
    */
    public static string Compute(string path, string SHA)
    {
        using(FileStream fs = new FileStream(path, FileMode.Open))
        {
            using(HashAlgorithm SHAalg = HashToUse(SHA))
            {
                return BitConverter.ToString(SHAalg.ComputeHash(fs)).ToLower().Replace("-", "");
            }
        }
    }

    /*
    <summary>
        Best possible commonly used security level. By default SHA512. 
    </summary>
    <param name="SHA">Main method user's SHA.</param>
    <returns>The HashAlgorithm SHA for computing.</returns>
    */
    public static HashAlgorithm HashToUse(string SHA)
    {
        HashAlgorithm SHAalg;
        {
            if(SHA == "SHA512")
                SHAalg = SHA512.Create();//SHA3_512.Create();
            else if(SHA == "SHA384")
                SHAalg = SHA384.Create();//SHA3_384.Create();
            else if(SHA == "SHA256")
                SHAalg = SHA256.Create();//SHA3_256.Create();
            else throw new ArgumentException("Accepted SHAs are at least SHA512 or else SHA384 or else SHA256");
            return SHAalg;
        }
    }
}