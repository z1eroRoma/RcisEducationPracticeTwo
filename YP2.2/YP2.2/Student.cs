using System;

namespace ConsoleApp3
{
    class Student {
        public string surname;
        public DateTime birthdate;
        public string group;
        public int[] grades = new int[5];

        public Student(string surname, DateTime birthdate, string group, int[] grades) {
            this.surname = surname;
            this.birthdate = birthdate;
            this.group = group;
            this.grades = grades;
        }

        public void PrintInfo() 
        {
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Дата рождения: {birthdate.ToShortDateString()}");
            Console.WriteLine($"Номер группы: {group}");
            Console.WriteLine($"Успеваемость: {string.Join(", ", grades)}");
        }

        public static Student ReadStudent() 
        {
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения (в формате дд.мм.гггг): ");
            DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            Console.Write("Введите номер группы: ");
            string group = Console.ReadLine();
            int[] grades = new int[5];
            for (int i = 0; i < 5; i++) {
                Console.Write($"Введите оценку за предмет {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            return new Student(surname, birthdate, group, grades);
        }
    }
}