string bookName = Console.ReadLine();

string searchedBook = bookName;
int count = 0; // 1 //2
bool found = false;
while (bookName != "No More Books")
{
    bookName = Console.ReadLine();

    if (bookName == searchedBook)
    {
        Console.WriteLine($"You checked {count} books and found it.");
        found = true;
        break;
    }
    if (bookName != "No More Books")
    {
        count++;
    }
}
if (!found)
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {count} books.");
}
