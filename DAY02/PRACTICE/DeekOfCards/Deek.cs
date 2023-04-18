public class Deck
{
    public List<Card> Cards { get; set; }

    public Deck()
    {
        Reset();
    }

    public void Reset()
    {
        Cards = new List<Card>();
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        int numCardsPerSuit = 13;

        foreach (string suit in suits)
        {
            for (int val = 1; val <= numCardsPerSuit; val++)
            {
                Card card = new Card("", suit, val);
                switch (val)
                {
                    case 1:
                        card.Name = "Ace";
                        break;
                    case 11:
                        card.Name = "Jack";
                        break;
                    case 12:
                        card.Name = "Queen";
                        break;
                    case 13:
                        card.Name = "King";
                        break;
                    default:
                        card.Name = val.ToString();
                        break;
                }
                Cards.Add(card);
            }
        }
    }

    public Card Deal()
    {
        if (Cards.Count == 0)
        {
            return null;
        }

        Card topCard = Cards[0];
        Cards.RemoveAt(0);
        return topCard;
    }

    public void Shuffle()
    {
        Random rnd = new Random();
        int n = Cards.Count;

        while (n > 1)
        {
            n--;
            int k = rnd.Next(n + 1);
            Card card = Cards[k];
            Cards[k] = Cards[n];
            Cards[n] = card;
        }
    }

    public void Print()
    {
        foreach (Card card in Cards)
        {
            Console.WriteLine($"{card}");
        }
    }
}
