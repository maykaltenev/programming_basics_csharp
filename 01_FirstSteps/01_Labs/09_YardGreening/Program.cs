double area = double.Parse(Console.ReadLine());
double initialCost = area * 7.61;
double discount = initialCost * 0.18;
double finalCost = initialCost - discount;

Console.WriteLine($"The final price is: {finalCost} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
