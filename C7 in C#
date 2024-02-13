using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
       using (StreamReader file = new StreamReader("names.txt"))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
            Console.WriteLine("My name is " + line + ", nice to meet you!");
            }
        }
    }
}
