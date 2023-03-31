
using System;

namespace ConsoleApp3
{
    public class Train
    {
        public string Destination;
        public int Number;
        public string DepartureTime;

        public void DisplayTrainInfo()
        {
            Console.WriteLine($"Поезд с номером {Number} следует в {Destination} и отправляется в {DepartureTime}");
        }
    }
}