using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
        string name1 = "David";
        int age1 = 12;
        string name2 = "Cindy";
        int age2 = 38;
        int combinedage = age1 + age2;
        Console.WriteLine("This is " + name1 + " and his mom, " + name2 + " they have a combined age of " + combinedage);
    }
}
