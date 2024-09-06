using OpenClosedPrinciple.Encryption;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Encryption aesEncrypt = new AESEncryption();
            Console.WriteLine(aesEncrypt.Encrypt(""));

            Encryption rsaEncrypt = new RSAEncryption();
            Console.WriteLine(rsaEncrypt.Encrypt(""));

            // new encryption type    
            Encryption eccEncrypt = new ECCEncryption();
            Console.WriteLine(eccEncrypt.Encrypt(""));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}