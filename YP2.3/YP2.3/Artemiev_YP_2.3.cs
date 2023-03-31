﻿using System;

namespace ConsoleApp4
{
// Задание 1
/*
 namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Worker people = new Worker();
            Console.WriteLine("Введите имя рабочего");
            people.name = Console.ReadLine();
            
            Console.WriteLine("Введите фамилию рабочего");
            people.surname = Console.ReadLine();
                
                Console.WriteLine("Введите ставку за день");
                people.rate = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Введите кол-во отработанных дней");
                people.days = int.Parse(Console.ReadLine());
                people.PrintInfo();



        }
    }
}
*/

// Задание 2 - модифицированный класс ModifyWorker.cs


// Задание 3

    class Program
    {
        static void Main()
        {
            Calculation symbol = new Calculation();
            while (true)
            {
                Console.WriteLine("Нажмите 0, чтобы завершить работу программы.");
                Console.WriteLine("Нажмите 1, чтобы внести измененени.");
                Console.WriteLine("Нажмите 2, чтобы добавить символ в конце строки.");
                Console.WriteLine("Нажмите 3, чтобы вывести значения.");
                Console.WriteLine("Нажмите 4, чтобы Вывести последний символ.");
                Console.WriteLine("Нажмите 5, чтобы удалить последний символ.");
                Console.Write("Введите номер операции: ");
                int unswer = Convert.ToInt32(Console.ReadLine());
                switch (unswer)
                {
                    case 0:
                        Console.WriteLine("Вы завершили программу");
                        return;
                    case 1:
                        Console.WriteLine("Введите измененный вариант: ");
                        symbol.SetCalculationLine = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Новый символ: ");
                        string newSymbol = Console.ReadLine();
                        symbol.SetLastSymbolCalculationLine(newSymbol);
                        break;
                    case 3:
                        Console.WriteLine("Предложение: ");
                        string justSentence = symbol.calculationLine;
                        Console.WriteLine(symbol.GetCalculationLine);
                        break;
                    case 4:
                        Console.WriteLine("Последний символ: ");
                        Console.WriteLine(symbol.GetLastSymbol());
                        break;
                    case 5:
                        Console.WriteLine("Предложение после удаления: ");
                        Console.WriteLine(symbol.DeleteLastSymbol());
                        break;
                }
            }
        }
    }
}
