using System;

//Задание 2. Программа подсчёта суммы карт в игре «21»
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество карт у вас на руках: ");
            int count;
            int.TryParse(Console.ReadLine(), out count);
            string card;
            int totalWeigh = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Введите номинал карты: ");
                card = Console.ReadLine();
                switch (card)
                {
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        totalWeigh += int.Parse(card);
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        totalWeigh += 10;
                        break;
                }
            }
            Console.WriteLine($"\nЗначение суммы карт = {totalWeigh}");
        }
    }
}
