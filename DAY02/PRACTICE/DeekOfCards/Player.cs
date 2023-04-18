public class Player
{
    public string Name { get; set; }
    public List<Card> Hand { get; set; }

    public Player(string name)
    {
        Name = name;
        Hand = new List<Card>();
    }

    public Card Draw(Deck deck)
    {
        Card drawnCard = deck.Deal();
        Hand.Add(drawnCard);
        return drawnCard;
    }

    public Card Discard(int index)
    {
        if (index < 0 || index >= Hand.Count)
        {
            return null;
        }

        Card discardedCard = Hand[index];
        Hand.RemoveAt(index);
        return discardedCard;
    }
}
