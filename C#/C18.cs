using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Reflection.Metadata;
class Program
{
    static async Task Main(string[] args)
    {
        string baseURL = "https://restcountries.com/v3.1/name/";
        
        Console.WriteLine("Please enter the name of a country");
        string userCountry = Console.ReadLine();
        Console.WriteLine("Please select one of the following options to learn about " + userCountry + ":\nCapital\nPopulation\nTimezone\nContinent" );
        string userSelection = Console.ReadLine();
        userSelection = userSelection.ToLower();
        string searchParam = "";
        switch (userSelection)
        {
            case "capital":
                searchParam = "?fields=capital";
                break;
            case "population":
                searchParam = "?fields=population";
                break;
            case "timezone":
                searchParam = "?fields=timezones";
                break;
            case "continent":
                searchParam = "?fields=continents";
                break;
            default:
                Console.WriteLine("You didnt select a valid option");
                break;
        }  
        string apiUrl = baseURL + userCountry + searchParam;
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                
                string cleanOutput = responseData.Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "");
                Console.WriteLine(cleanOutput);
            }
            else
            {
                Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
            }
           
        }
    }
}
