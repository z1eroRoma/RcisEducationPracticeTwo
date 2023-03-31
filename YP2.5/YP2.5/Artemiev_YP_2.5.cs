using System;
using Npgsql;
using System.Collections.Generic;

namespace GarageConsoleApp;
public class Program 
{
    public static void Main(string[] args)
    {
        string AddCheck = Console.ReadLine();
        if (AddCheck == "Добавить")
        {
            AddCheck = Console.ReadLine();
            switch (AddCheck)
            {
                case "тип машины":
                    DatabaseRequests.AddTypeCarQuery(Console.ReadLine());
                    DatabaseRequests.GetTypeCarQuery();
                    break;
                case  "Водитель" :
                    DatabaseRequests.AddDriverQuery(Console.ReadLine(), Console.ReadLine(), DateTime.Parse(Console.ReadLine()));
                    DatabaseRequests.GetDriverQuery();
                    break;
                case "Машина":
                    DatabaseRequests.AddCarQuery(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                    DatabaseRequests.GetCarQuery();
                    break;
                case "Машрут":
                    DatabaseRequests.AddItinerary(Console.ReadLine());
                    DatabaseRequests.GetItinerary();
                    break;
                case "Рейс":
                    DatabaseRequests.AddRoute(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    DatabaseRequests.GetRoute();
                    break;
                case "Категория прав" :
                    DatabaseRequests.AddRightsCategoryQuery(Console.ReadLine());
                    break;
                case "Права" :
                    DatabaseRequests.AddDriverRightsCategoryQuery(Console.ReadLine(), Console.ReadLine());
                    break;
            }
        }
        else if(AddCheck == "Просмотреть")
        {
            AddCheck = Console.ReadLine();
            switch (AddCheck)
            {
                case "тип машины":
                    DatabaseRequests.GetTypeCarQuery();
                    break;
                case  "Водитель" :
                    DatabaseRequests.GetDriverQuery();
                    break;
                case "Машина":
                    DatabaseRequests.GetCarQuery();
                    break;
                case "Машрут":
                    DatabaseRequests.GetItinerary();
                    break;
                case "Рейс":
                    DatabaseRequests.GetRoute();
                    break;
                case "Права":
                    DatabaseRequests.GetDriverRightsCategoryQuery(Console.ReadLine());
                    break;
            }
        }
    }
}
