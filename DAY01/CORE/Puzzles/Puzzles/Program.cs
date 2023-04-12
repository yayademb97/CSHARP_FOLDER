//********************************************Required*************************************


static int[] RandomArray()
{
//-----------------------------------------------------Create a function called RandomArray() that returns an integer array-------------------------------------------
//-----------------------------Create an empty array that will hold 10 integer values.-----------------------------------------------
    Random rand = new Random();
    int[] arr = new int[10];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(5, 26); // Génère un entier aléatoire compris entre 5 et 25
    }

    return arr;
}



int[] myArray = new int[10];
int sum = 0;
Random rand = new Random();

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(5, 26); // Génère un entier aléatoire compris entre 5 et 25 et l'assigne à l'index actuel
    sum += myArray[i]; // Ajoute la valeur actuelle à la somme totale
}

int min = myArray.Min();
int max = myArray.Max();

Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");




Console.WriteLine("*************************************************************************************************************************");
RandomArray();



//**************************************************************Coin Flip******************************************************************


static string TossCoin()
{

    //------------------Required:------------------------------------------------------------------------------
// Create a function called TossCoin() that returns a string

// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin
// Have the function print either "Heads" or "Tails"
// Finally, return the result
    Console.WriteLine("Tossing a Coin!");
    Random random = new Random();
    int result = random.Next(0, 2);
    if (result == 0)
    {
        Console.WriteLine("Heads");
        return "Heads";
    }
    else
    {
        Console.WriteLine("Tails");
        return "Tails";
    }
}

Console.WriteLine("*************************************************************************************************************************");
TossCoin();

//**************************************************************Optional****************************************************************************************


static List<string> Names()
{
    // Create a list with the names
    List<string> names = new List<string>() { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };

    // Filter the list to only include names longer than 5 characters
    List<string> filteredNames = names.Where(name => name.Length > 5).ToList();

    // Shuffle the list
    Random rng = new Random();
    int n = filteredNames.Count;
    while (n > 1)
    {
        n--;
        int k = rng.Next(n + 1);
        string temp = filteredNames[k];
        filteredNames[k] = filteredNames[n];
        filteredNames[n] = temp;
    }

    // Print the values in the new order
    Console.WriteLine("Filtered and shuffled names:");
    foreach (string name in filteredNames)
    {
        Console.WriteLine(name);
    }

    return filteredNames;
}

Names();