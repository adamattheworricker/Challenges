using System;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the path");
        string fileLocation = Console.ReadLine();
        string[] files = Directory.GetFiles(fileLocation);
        foreach (string file in files)
        {
            string hash = CalculateSHA256(file);
            Console.WriteLine(file + " : " + hash);
        }
    }
    static string CalculateSHA256(string file)
    {
        using (FileStream stream = File.OpenRead(file))
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(stream);
                return BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }
    }
}
