using System;

namespace NovikRomanForAndersen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num; 
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out num))
            {
                if (num > 7)
                {
                    Console.WriteLine("Привет");
                }
                else
                {
                    Console.WriteLine("Введено неверное число, начните заново");
                }
            }
            else
            {
                Console.WriteLine("Некорректное значение");
            }
            Console.ReadKey();

        }
    }
}
