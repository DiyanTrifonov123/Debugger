using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmnojavaneNaChetniPoNechetni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число: ");
            int num = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvensAndOdds(num);
            Console.WriteLine($"Резултат: {result}");
        }

        private static int GetMultipleOfEvensAndOdds(int num)
        {
            int evens = GetSumOfEvens(num);
            int odds = GetSumOfOdds(num);
            return evens * odds;
        }

        private static int GetSumOfOdds(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum = lastDigit + sum;
                }
                num /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvens(int num)
        {
            int sum = 0;
            while (num>0)
            {
                int lastDigit = num % 10;
                if (lastDigit% 2 == 0)
                {
                    sum = lastDigit + sum;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
