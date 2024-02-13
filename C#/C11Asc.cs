using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
       int height;
       Console.WriteLine("How tall would you like your steps?");
       height = Convert.ToInt32(Console.ReadLine());
       for(int i = 1; i <= height;)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('#', i));
            i++;
        }
    }
}
