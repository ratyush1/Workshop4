using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Create object of Calculator
        Calculator calc = new Calculator();

        // Call void method
        calc.PrintWelcome();

        // Call Add method
        int addition = calc.Add(100, 200);
        Console.WriteLine("Addition Result: " + addition);

        // Call Multiply method (both parameters)
        int multiply1 = calc.Multiply(50, 40);
        Console.WriteLine("Multiplication (50 * 40): " + multiply1);

        // Call Multiply method (optional parameter)
        int multiply2 = calc.Multiply(7);  // num2 uses default = 1
        Console.WriteLine("Multiplication (7 * default): " + multiply2);

        Console.ReadLine();
    }
}
