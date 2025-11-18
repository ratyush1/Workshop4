using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Create 2 objects of Student
        Student s1 = new Student();
        Student s2 = new Student();

        // Assign instance fields for first object
        s1.name = "Pratyush";
        s1.age = 20;
        s1.course = "BIT";

        // Assign instance fields for second object
        s2.name = "Priyanshu";
        s2.age = 20;
        s2.course = "BIT";

        // Display object 1 data
        Console.WriteLine(" Student 1 ");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Course: " + s1.course);

        // Display object 2 data
        Console.WriteLine("\n Student 2 ");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Course: " + s2.course);

        // Display static field
        Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);

        Console.ReadLine();
    }
}
