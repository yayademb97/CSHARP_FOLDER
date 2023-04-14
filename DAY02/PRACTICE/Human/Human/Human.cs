class Program
{
    static void Main(string[] args)
    {
        // Create two Human objects using different constructors
        Human johnDoe = new Human("John Doe");
        Human janeDoe = new Human("Jane Doe", 5, 4, 3, 80);

        // Attack John Doe using Jane Doe's Attack method
        int remainingHealth = janeDoe.Attack(johnDoe);

        Console.WriteLine($"{janeDoe.Name} attacked {johnDoe.Name} for {janeDoe.Strength * 3} damage!");
        Console.WriteLine($"{johnDoe.Name} has {remainingHealth} health remaining.");
    }
}
