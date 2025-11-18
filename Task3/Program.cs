using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Create object
        ParameterDemo demo = new ParameterDemo();

        //  Calling Increase(ref)
        int value = 20;
        Console.WriteLine("Original value: " + value);
        demo.Increase(ref value);
        Console.WriteLine("After Increase(ref): " + value);

        //  Calling GetFullName(out)
        string fullName;
        demo.GetFullName(out fullName);
        Console.WriteLine("Full Name (out): " + fullName);

        //  Calling SumAll(params)
        int total = demo.SumAll(5, 10, 20, 3, 2);
        Console.WriteLine("Sum of all numbers: " + total);

        Console.ReadLine();
    }
}
