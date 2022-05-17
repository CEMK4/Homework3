using System;

//Задание 1. Приложение по определению чётного или нечётного числа
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, которое хотите проверить на чётность: ");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            string print = IsEven(num) ? "Число " + num + " чётное." : "Число " + num + " нечётное.";
            Console.WriteLine(print);
        }

        /// <summary>
        /// Проверяет число на чётность.
        /// </summary>        
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
