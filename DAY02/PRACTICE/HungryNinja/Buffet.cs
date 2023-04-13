class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Spaghetti", 1000, true, false),
            new Food("Icecream", 1500, false, true),
            new Food("Kafteji", 1100, true, false),
            new Food("Borghol", 1000, true, false),
            new Food("Kamouneya", 2000, true, false),
            new Food("Sauce Blanche", 1000, true, false),
            new Food("Thé", 1000, false, true)
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        return Menu[rand.Next(Menu.Count)];
    }
}

