using System;

namespace ConsoleApp4
{
    class Worker
    {
        public string name = "";
        public string surname = "";
        public int rate;
        public int days;

        public int GetSalary()
        {
            return this.rate * this.days;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Информация о рабочем:");
            Console.WriteLine($"Имя и фамилия: {name} {surname} ");
            Console.WriteLine($"Ставка: {rate}");
            Console.WriteLine($"Отработанно:{days} Дней");
            Console.WriteLine($"ЗП:{GetSalary()} руб.");
        }
    }
}