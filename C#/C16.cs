using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter the cost of the item");
        int cost = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the amount paid");
        int paid = Convert.ToInt32(Console.ReadLine());
        if (paid < cost)
        {
            Console.WriteLine("The customer has not paid enough to receive any change");
        }
        int change = paid - cost;
        int fifty = 0;
        int twenty = 0;
        int ten = 0;
        int five = 0;
        int one = 0;
        while (change >= 50)
        {
            change = change - 50;
            fifty++;
        }
        while (change >= 20)
        {
            change = change - 20;
            twenty++;
        }
        while (change >= 10)
        {
            change = change - 10;
            ten++;
        }
        while (change >= 5)
        {
            change = change - 5;
            five++;
        }
        while (change >= 1)
        {
            change = change - 1;
            one++;
        }
        Console.WriteLine("Give the following change:" + "\n$50 x " + fifty + "\n$20 x " + twenty + "\n$10 x " + ten + "\n$5 x " + five + "\n$1 x " + one);
    }
}
