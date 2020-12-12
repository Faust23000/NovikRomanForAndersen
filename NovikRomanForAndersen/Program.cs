using System;

namespace NovikRomanForAndersen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");              // Задача №1
            Console.WriteLine("");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 7)
            {
                Console.WriteLine("Привет");
            }

            Console.WriteLine("");                   // Задача №2
            Console.WriteLine("Task2");
            Console.WriteLine("");
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            if (name == "Вячеслав")
            {
                Console.WriteLine($"Привет, {name}");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }

            Console.WriteLine("");                   // Задача №3
            Console.WriteLine("Task3");
            Console.WriteLine("");
            int[] numbers = new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            Console.Write("Массив:");
            foreach (int i in numbers)
            {
                Console.Write(i);
                Console.Write(",");
            }
            Console.WriteLine("");
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.Beep();
            Console.ReadKey();
        }
    }
}
