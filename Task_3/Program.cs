using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out n))
            {
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)                             // Заполяем массив
                {
                    try
                    {
                        Console.WriteLine("Введите {0} элемент массива:", i);
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введено неверное значение");
                    }
                }
                foreach (int i in numbers)                               // Просматриваем заполненный массив
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter");
                Console.WriteLine("");
                Console.ReadKey();
                for (int i = 0; i < numbers.Length; i++)                  // Ищем значения кратные 3
                {
                    if (numbers[i] % 3 == 0 && numbers[i] != 0)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }
            Console.ReadKey();

        }
    }
}
