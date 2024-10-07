double hourOfExam = double.Parse(Console.ReadLine());
double minutesOfExam = double.Parse(Console.ReadLine());
double hourOfArrival = double.Parse(Console.ReadLine());
double minutesOfArrival = double.Parse(Console.ReadLine());
double result = 0.0;

// // Convert hours to minutes
double totalTimeOfExam = hourOfExam * 60 + minutesOfExam;
double totalTimeOfArrival = hourOfArrival * 60 + minutesOfArrival;

if (totalTimeOfArrival >= totalTimeOfExam)
{
    result = totalTimeOfArrival - totalTimeOfExam;
    Console.WriteLine(result);
    double minutesResult = (int)result % 60;
    double hoursResult = (int)result / 60;
    hoursResult = hoursResult < 1 ? 0 : hoursResult;
    if (result >= 1)
    {
        Console.WriteLine("Late");
        if (hoursResult > 0)
        {
            if (minutesResult < 10)
            {
                Console.WriteLine($"{hoursResult}:0{minutesResult} hours after the start");
            }
            else
            {
                Console.WriteLine($"{hoursResult}:{minutesResult} hours after the start");
            }
        }
        else
        {
            if (minutesResult < 10)
            {
                Console.WriteLine($"{minutesResult} minutes after the start");
            }
            else
            {
                Console.WriteLine($"{minutesResult} minutes after the start");
            }
        }
    }
    else if (result == 0)
    {
        Console.WriteLine("On Time");
    }
}
else if (totalTimeOfExam >= totalTimeOfArrival)
{
    result = totalTimeOfExam - totalTimeOfArrival;
    double minutesResult = (int)result % 60;
    double hoursResult = (int)result / 60;
    hoursResult = hoursResult < 1 ? 0 : hoursResult;
    if (result == 0 || result <= 30)
    {
        Console.WriteLine("On time");
        if (hoursResult > 0)
        {
            if (minutesResult < 10)
            {
                Console.WriteLine($"{hoursResult}:0{minutesResult} before the start");
            }
            else
            {
                Console.WriteLine($"{hoursResult}:{minutesResult} before the start");
            }
        }
        else
        {
            if (minutesResult < 10)
            {
                Console.WriteLine($"{minutesResult} minutes before the start");
            }
            else
            {
                Console.WriteLine($"{minutesResult} minutes before the start");
            }
        }
    }
    else if (result > 30)
    {
        Console.WriteLine("Early");
        if (hoursResult > 0)
        {
            if (minutesResult < 10)
            {
                Console.WriteLine($"{hoursResult}:0{minutesResult} hours before the start");
            }
            else
            {
                Console.WriteLine($"{hoursResult}:{minutesResult} hours before the start");
            }
        }
        else
        {
            if (minutesResult < 10)
            {
                Console.WriteLine($"{minutesResult} minutes before the start");
            }
            else
            {
                Console.WriteLine($"{minutesResult} minutes before the start");
            }
        }
    }
}
