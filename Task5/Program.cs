using System;
public enum DayType
{
    Weekday,
    Weekend
}

public record Book(string title, string author, double price);

internal class Program
{
    static void Main(string[] args)
    {
        //  ENUM PART 

        Console.Write("Enter a day: ");
        string day = Console.ReadLine().Trim().ToLower();

        DayType type;

        // Friday and Saturday = Weekend
        if (day == "friday" || day == "saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine("It is: " + type);

        // RECORD PART 

        // Create first Book object
        Book b1 = new Book("Science", "Pratyush", 599.99);

        // Create second object using with-expression
        Book b2 = b1 with { title = "Physics", price = 899.99 };

        // Print first book details
        Console.WriteLine("\n First Book ");
        Console.WriteLine($"Title: {b1.title}");
        Console.WriteLine($"Author: {b1.author}");
        Console.WriteLine($"Price: {b1.price}");

        // Deconstruct second book
        var (title, author, price) = b2;

        Console.WriteLine("\n Second Book (Deconstructed) ");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);

        Console.ReadLine();
    }
}
