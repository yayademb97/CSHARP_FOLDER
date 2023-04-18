Human player1 = new Human("John", 10, 5, 8, 100);
Human player2 = new Human("Jane", 8, 7, 108, 120);

Console.WriteLine($"Before ATTACk: {player1.Name} have {player1.Health}and point of life and {player2.Name} have {player2.Health} and point of life ");


player1.Attack(player2);

Console.WriteLine($"After ATTACk: {player1.Name} have {player1.Health}and point of life and {player2.Name} have {player2.Health} and point of life ");
