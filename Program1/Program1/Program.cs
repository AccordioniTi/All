using System;

namespace Program1
{
    internal class Program
    {
       // program start working
       static void Main(string[] args)
        {
            // insert user name.
            Console.WriteLine("Введите ваше имя:");
            // reading name.
            string name = Console.ReadLine();
            // user greeting.
            int age = 25;
            bool isEmployed = true;
            double weight = 81.54;
            DateTime date1 = new DateTime(1997, 1, 21);
            Console.WriteLine("Привет, " + name);
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Работает: {isEmployed}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Дата рождения: {date1.ToLongDateString()}");
            // waiting user reaction.
            Console.WriteLine("Нажмите <Enter>\nдля выхода...");
            Console.Read();
        }
    }
}
