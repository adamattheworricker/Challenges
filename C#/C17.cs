using System.CodeDom.Compiler;
using System.Net.Sockets;
using System.Xml.XPath;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("I can analyse text for you. Please enter the text you would like me to review");
        string sentence = Console.ReadLine();
        
        string[] words = sentence.Split(" ");
        string charsonly = sentence.Replace(" ", "");   
        double average = Convert.ToDouble(charsonly.Length) / Convert.ToDouble(words.Length);

        int fullstops = sentence.Split(".").Length - 1;  
        Console.WriteLine("Please find below the statistics for your text...\nNumber of words: " + words.Length + "\nAverage word length: " + average + "\nNumber of sentences: " + fullstops);  
    }
}
