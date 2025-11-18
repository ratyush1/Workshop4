public class Player
{
    // Instance fields
    public string playerName;
    public int level;
    public int health;

    // Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // Parameterized constructor
    public Player(string name, int level, int health)
    {
        this.playerName = name;
        this.level = level;
        this.health = health;
    }
}
