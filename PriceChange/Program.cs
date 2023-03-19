using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Брой цена: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Праг на значимост: ");
            double significanceThreshold = double.Parse(Console.ReadLine());
            Console.Write("Предишна цена: ");
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write("Въведи сегашна цена: ");
                double currentPrice = double.Parse(Console.ReadLine());
                double differencePercentage = GetDifferencePercentage(previousPrice, currentPrice);

                bool isSignificant = Math.Abs(differencePercentage) > significanceThreshold;
                string message = GetMessage(currentPrice, previousPrice, differencePercentage, isSignificant);

                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }

        static double GetDifferencePercentage(double previousPrice, double currentPrice)
        {
            return (currentPrice - previousPrice) / previousPrice * 100;
        }

        static string GetMessage(double currentPrice, double previousPrice, double differencePercentage, bool isSignificant)
        {
            if (differencePercentage == 0)
            {
                return string.Format($"Няма промяна: {currentPrice}");
            }
            else if (!isSignificant)
            {
                return string.Format($"Малка разлика: от {previousPrice} до {currentPrice} ({differencePercentage:F2}%)");
            }
            else if (differencePercentage > 0)
            {
                return string.Format($"Голяма разлика нагоре: от {previousPrice} до {currentPrice} ({differencePercentage:F2}%)");
            }
            else
            {
                return string.Format($"Голяма разлика надолу: от {previousPrice} до {currentPrice} ({differencePercentage:F2}%)");
            }
        }
    }
}
