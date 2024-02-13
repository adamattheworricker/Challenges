using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What day is it?");
        string day = Console.ReadLine();
        Console.WriteLine("Hello " + name + " Happy " + day + ", I hope you have a great day");
    }
}
