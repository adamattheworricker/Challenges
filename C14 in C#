using System.Diagnostics;
using System.Formats.Asn1;
using System.Net.Sockets;
using System.Security.Cryptography;
internal class Program
{
    private static void Main(string[] args)
    {
       string shape;
       int length;
       int height;
       int area;

       Console.WriteLine("I can help you calculate the area of a square or a triangle. Which would you like me to do? Please enter square or triangle");
       shape = Console.ReadLine();
       shape = shape.ToLower();

       Console.WriteLine("What is the length of the object in centimetres?");
       length = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("What is the height of the object in centimetres?");
       height = Convert.ToInt32(Console.ReadLine());
       {
            if (shape == "triangle")
            {
                area = length * height / 2;
                Console.WriteLine("The area of the triangle is " + area + " centimetres squared");
            }
            else if (shape == "square")
            {
                area = length * height;
                Console.WriteLine("The area of the square is " + area + " centimetres squared");
            }
            else
            {
                Console.WriteLine("Please select a valid shape");
            }
       }
    }
}
