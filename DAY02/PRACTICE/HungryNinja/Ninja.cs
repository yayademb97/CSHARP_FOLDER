class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            return calorieIntake > 1200;
        }
    }

    // build out the Eat method
    public void Eat(Food item)
    {
        bool full = IsFull;
        if (!full)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine(item.Name);
            if(item.IsSpicy)
            {
                Console.WriteLine("7aaaaaaarrrr");
            }
            if(item.IsSweety)
            {
                Console.WriteLine("yyyy😃");
            }
        }
        else
        {
            Console.WriteLine("Stop !!!!!!!!!!!");
        }
    }
}

