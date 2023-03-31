namespace ConsoleApp6;

public class WeatherResponse
{
    public TemperatureInfo Main { get; set; }
    public String Name { get; set; }
    public TemperatureInfo[] Weather { get; set; }
    public TemperatureInfo wind { get; set; }

    public int visibility { get; set; }
    

}


