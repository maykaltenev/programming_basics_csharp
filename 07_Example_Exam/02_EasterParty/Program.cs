using System;

namespace EasterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberGuests = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cake = budget * 0.10;
            double discount = 1;
            if (numberGuests >= 10 && numberGuests <= 15)
            {
                discount = 0.85;
            }
            else if (numberGuests >= 16 && numberGuests <= 20)
            {
                discount = 0.80;
            }
            else if (numberGuests > 20)
            {
                discount = 0.75;
            }

            double pricePerPerson = price * discount;

            double totalPeople = pricePerPerson * numberGuests;
            double total = totalPeople + cake;

            if (budget >= total)
            {
                Console.WriteLine($"It is party time! {(budget - total):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {(total - budget):f2} leva needed.");
            }
        }
    }
}
