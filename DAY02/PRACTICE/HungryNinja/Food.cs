public class Food
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public bool IsSpicy { get; set; }

    public bool IsSweety { get; set; }

    public Food (string name, int calories, bool isSpicy, bool isSweety)
    {
        Name = name;
        Calories = calories;
        IsSpicy = isSpicy;
        IsSweety = isSweety;

    }

}