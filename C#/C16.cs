using System.Net.Sockets;
using System.Runtime.InteropServices;
internal class Program
{
    private static void Main(string[] args)
    {
       string sport;
       Console.WriteLine("Please enter your favorite sport; EPL, NFL, NBA, MLB or NHL");
       sport = Console.ReadLine();
       sport = sport.ToUpper();
       switch (sport)
       {
        case "EPL":
            Console.WriteLine("Awesome, you're a soccer fan! The current EPL champions are Manchester City");
            break;
        case "NFL":
            Console.WriteLine("Great, a football lover. The current Superbowl champions are the Kansas City Chiefs");
            break;
        case "NBA":
            Console.WriteLine("Hey basketball fan! Current NBA champions are the Denver City Nuggets");
            break;
        case "MLB":
            Console.WriteLine("Oh hi there baseball fanatic! The current MLB champions are the Texas Rangers");
            break;
        case "NHL":
            Console.WriteLine("Howdy hockey fan! The current Stanley Cup holders are the Vegas Golden Knights");
            break;
        default:
            Console.WriteLine("Hmm, I dont know anything about that sport, please select another one");
            break;
       }  
    }
}

