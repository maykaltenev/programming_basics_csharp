using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int sugar = 950;
            int flour = 750;

            int maxFlour = int.MinValue;
            int maxSugar = int.MinValue;
            double totalSugar = 0;
            double totalFlour = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int usedSugar = int.Parse(Console.ReadLine());
                int usedFlour = int.Parse(Console.ReadLine());

                if (usedSugar > maxSugar)
                {
                    maxSugar = usedSugar;
                }
                if (usedFlour > maxFlour)
                {
                    maxFlour = usedFlour;
                }
                totalSugar += usedSugar;
                totalFlour += usedFlour;
            }

            double finalSugar = Math.Ceiling(((double)totalSugar / sugar));
            double finalFlour = Math.Ceiling(((double)totalFlour / flour));
            Console.WriteLine($"Sugar: {finalSugar}");
            Console.WriteLine($"Flour: {finalFlour}");
            Console.WriteLine(
                $"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams."
            );
        }
    }
}
