// 

Deck deck = new Deck();
deck.Shuffle();

Player player = new Player("Alice");
player.Draw(deck);
player.Draw(deck);
player.Draw(deck);

Console.WriteLine("Player's hand:");
foreach (Card card in player.Hand)
{
    Console.WriteLine(card.Name + " of " + card.Suit + " (Value: " + card.Val + ")");
}

player.Discard(1);

Console.WriteLine("Player's hand after discarding:");
foreach (Card card in player.Hand)
{
    Console.WriteLine(card.Name + " of " + card.Suit + " (Value: " + card.Val + ")");
}
