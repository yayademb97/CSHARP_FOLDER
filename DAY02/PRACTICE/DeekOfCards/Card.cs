public class Example
{
    public Card MyCard { get; set; }
}

public class Card
{
    public string Name { get; set; }
    public string Suit { get; set; }
    public int Val { get; set; }

    public Card(string name, string suit, int val)
    {
        Name = name;
        Suit = suit;
        Val = val;
    }
}
