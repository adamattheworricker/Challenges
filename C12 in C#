using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
       using (StreamReader file = new StreamReader("employeelist.txt"))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
            Console.WriteLine(line.Remove(line.Length - 4));
            }
        }
    }
}
