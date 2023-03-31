using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

namespace ConsoleApp6;

class Program
{
    static void Main()
    {
        Console.Write("Введите название города: ");
        string city = Console.ReadLine();
        string url =
            $"https://api.openweathermap.org/data/2.5/weather?q={city}&lang=ru&appid=ad89a00dd8809a7615a83ab93e12560b&units=metric";
        HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
        string response;
        using (StreamReader streamReader = new StreamReader(Response.GetResponseStream()))
        {
            response = streamReader.ReadToEnd();
        }

        WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
        Console.WriteLine("Температура в {0}:{1} С", weatherResponse.Name, weatherResponse.Main.Temp);
        Console.WriteLine($"Облачность: {weatherResponse.Weather[0].description}");
        Console.WriteLine($"Видимость: {weatherResponse.visibility} м");
        Console.WriteLine($"Влажность: {weatherResponse.Main.humidity}");
        Console.WriteLine($"Скорость ветра : {weatherResponse.wind.speed} м/c");
    }
}
       
    
    