using System;
using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        // Create object using default constructor
        Player p1 = new Player();

        // Set values manually for default constructor object
        p1.playerName = "Default Player";
        p1.level = 1;
        p1.health = 100;

        // 2. Create object using parameterized constructor
        Player p2 = new Player("Pratyush", 5, 250);

        // Print values from both objects
        Console.WriteLine("\n--- Player 1 Details ---");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        Console.WriteLine("\n--- Player 2 Details ---");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);

        Console.ReadLine();
    }
}
