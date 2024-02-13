using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = { "John", "Louise", "Clive", "Sherry" };
        using (StreamWriter file = new StreamWriter("names.txt"))
        {
            foreach (string line in lines)
                file.WriteLine(line);               
        }
    }
}
