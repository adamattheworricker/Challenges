using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
       using (StreamReader file = new StreamReader("iplist.txt"))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
            Console.WriteLine(line.Replace(" port 80", ":80"));
            }
        }
    }
}
