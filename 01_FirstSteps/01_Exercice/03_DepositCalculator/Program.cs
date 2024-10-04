double depositSum = double.Parse(Console.ReadLine());
double depositTerm = double.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double interestRate = depositSum * (annualInterestRate / 100);
double interestRatePerMonth = interestRate / 12;
double totalSum = depositSum + depositTerm * interestRatePerMonth;

Console.WriteLine(totalSum);
