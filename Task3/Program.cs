using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 3. Проверка простого числа
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "Число {0} простое? - {1}";
            Console.WriteLine(pattern,3,IsPrime(3));
            Console.WriteLine(pattern, 7, IsPrime(7));
            Console.WriteLine(pattern, 37, IsPrime(37));
            Console.WriteLine(pattern, 79, IsPrime(79));
            Console.WriteLine(pattern, 173, IsPrime(173));
            Console.WriteLine(pattern, 9, IsPrime(9));
            Console.WriteLine(pattern, 169, IsPrime(169));
            Console.WriteLine(pattern, 529, IsPrime(529));
        }

        /// <summary>
        /// Проверяет число на простату.
        /// </summary>        
        static bool IsPrime(int num)
        {
            int i = 2;
            int sqrt = (int)Math.Sqrt(num);            
            while (i <= sqrt)
            {
                if (num % i == 0)
                    return false;
                ++i;
            }
            return true;
        }
    }
}
