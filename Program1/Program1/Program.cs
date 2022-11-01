using System;

namespace Program1
{
    internal class Program
    {
       // Здесь программа начинает работу.
       static void Main(string[] args)
        {
            // Приглашение пользователю ввести имя.
            Console.WriteLine("Введите ваше имя:");
            // Чтение введенного имени.
            string name = Console.ReadLine();
            // Приветствие пользователя по имени.
            Console.WriteLine("Привет, " + name);
            // your look
            int m;
            m = 100;
            Console.WriteLine("Вы выглядите на все " + m );
            // Ожидание реакции пользователя.
            Console.WriteLine("Нажмите <Enter>\nдля выхода...");
            Console.Read();
        }
    }
}
