using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace ConsoleApp3
{


// УП 2.2
// Задание 1 

    class Program
    {
        static void Main()
        {
            Student student = Student.ReadStudent();
            student.PrintInfo();
            Console.Write("Введите новую фамилию: ");
            student.surname = Console.ReadLine();
            Console.Write("Введите новую дату рождения (в формате дд.мм.гггг): ");
            student.birthdate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            Console.Write("Введите новый номер группы: ");
            student.group = Console.ReadLine();
            student.PrintInfo();
        }
    }
}

// Задание 2

    /*   class Program
       {
           static void Main()
           {
   // Создаем массив объектов Train
               Train[] trains = new Train[]
               {
                   new Train { Number = 101, Destination = "Москва", DepartureTime = "10:00" },
                   new Train { Number = 102, Destination = "Томск", DepartureTime = "14:00" },
                   new Train { Number = 103, Destination = "Новосибирск", DepartureTime = "18:00" },
                   new Train { Number = 104, Destination = "Харьков", DepartureTime = "22:00" }
               };
               Console.Write("Введите номер поезда для вывода информации о нем: ");
               int trainNumber = int.Parse(Console.ReadLine());
               bool trainFound = false;
               foreach (Train train in trains)
               {
                   if (train.Number == trainNumber)
                   {
                       train.DisplayTrainInfo();
                       trainFound = true;
                       break;
                   }
               }
   
               if (!trainFound)
               {
                   Console.WriteLine($" Поезд с таким номером {trainNumber} не был найден");
               }
           }
       }
   }
   */
// Задание 3

/*
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое целое число:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            int second = int.Parse(Console.ReadLine());
            TwoIntegers numbers = new TwoIntegers();
            numbers.PrintIntegers();
            Console.WriteLine("Сумма чисел: " + numbers.SumIntegers());
            Console.WriteLine("Наибольшее число: " + numbers.MaxInteger());
            Console.WriteLine("Введите новое значение первого числа:");
            int newFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение второго числа:");
            int newSecond = int.Parse(Console.ReadLine());
            numbers.ChangeIntegers(newFirst, newSecond);
            numbers.PrintIntegers();
            Console.WriteLine("Сумма чисел: " + numbers.SumIntegers());
            Console.WriteLine("Наибольшее число: " + numbers.MaxInteger());
        }
    }
}
/*

// Задание 4
    /*  class Program
      {
          static void Main()
          {
              counter count = new counter();
              Random rand = new Random();
  
              while (true)
              {
                  Console.WriteLine("Введите число 0, чтобы завершить работу счетсчика.");
                  Console.WriteLine("Введите число 1, чтобы уменьшить значение счетчика.");
                  Console.WriteLine("Введите число 2, чтобы увеличить значение счетчика.");
                  Console.WriteLine("Введите число 3, чтобы вывести значение счетчика.");
                  Console.WriteLine("Введите число 4, чтобы счетчик произвольное значение.");
                  Console.WriteLine("Введите номер операции: ");
                  int num = int.Parse(Console.ReadLine());
                  int number = 0;
  
                  switch (num)
                  {
                      case 0:
                          Console.WriteLine("Вы завершили работу программу.");
                          break;
                      case 1:
                          count.shetchickOfLow();
                          break;
                      case 2:
                          count.shetchickOfSum();
                          break;
                      case 3:
                          Console.WriteLine(count.Output);
                          break;
                      case 4:
                          number = rand.Next();
                          count = new counter(number);
                          break;
                  }
              }
          }
      }
   */
    // Задание 5 
    /* class Program
     {
         static void Main()
         {
             NamesSurname people = new NamesSurname();
             while (true)
             {
                 Console.WriteLine("Введите число 0, чтобы завершить работу программы.");
                 Console.WriteLine("Введите число 1, чтобы ввести имя и фамилию");
                 Console.WriteLine("Введите число 2, чтобы показать данные");
                 Console.Write("Введите номер операции: ");
                 int num = int.Parse(Console.ReadLine());
                 switch (num)
                 {
                     case 0:
                         Console.WriteLine("Вы завершили программу");
                         return;
                     case 1:
                         Console.Write("Введите Имя: ");
                         String name1 = Console.ReadLine();
                         Console.Write("Введите Фамилию: ");
                         String name2 = Console.ReadLine();
                         people = new NamesSurname(name1, name2);
                         break;
                     case 2:
                         Console.WriteLine(people.name);
                         Console.Write(people.surname);
                         break;   
                 }
             }
         }
     }
  }
  
  */



