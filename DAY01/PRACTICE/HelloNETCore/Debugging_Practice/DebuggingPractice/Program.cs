// Challenge 1
// bool amProgrammer = "true";
bool amProgrammer = true;
Console.WriteLine(amProgrammer);

// int Age = 27.9;
int Age = 27;
Console.WriteLine(Age);

List<string> Names = new List<string>();
// Names = "Monica";
Names.Add("Monica");

// Dictionary<string, string> MyDictionary = new Dictionary<string, string>();

Dictionary<string, int> MyDictionary = new Dictionary<string, int>();


// MyDictionary.Add("Hello", "0");

MyDictionary.Add("Hello", 0);


MyDictionary.Add("Hi there", 0);

// This is a tricky one! Hint: look up what a char is in C#
// string MyName = 'MyName';

string MyName = "MyName";
Console.WriteLine(MyName);

// Challenge 2


// List<int> Numbers = new List<int>() {2,3,6,7,1,5};
// for(int i = Numbers.Count; i >= 0; i--)
// {
//     Console.WriteLine(Numbers[i]);
// }

List<int> Numbers = new List<int>() { 2, 3, 6, 7, 1, 5 };
for (int i = Numbers.Count - 1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}


// // Challenge 3
List<int> MoreNumbers = new List<int>() { 12, 7, 10, -3, 9 };
foreach (int i in MoreNumbers)
{
    Console.WriteLine(i);
}
// // Challenge 4
List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
for (int i = 0; i < EvenMoreNumbers.Count; i++)
{
    if (EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0;
    }

    foreach (int num in EvenMoreNumbers)
    {
        Console.WriteLine(num);
    }

}
// // Challenge 5
// What can we learn from this error message?
// string MyString = "superduberawesome";
// MyString[7] = "p";


string MyString = "superduberawesome";


// convert string to a char array
char[] charArray = MyString.ToCharArray(); 


// modify the char array
charArray[7] = 'p'; 


// create a new string from the modified char array
// MyString = new string(charArray); 
Console.WriteLine(charArray[7]);
// Challenge 6
// Hint: some bugs don't come with error messages


// Random rand = new Random();
// int randomNum = rand.Next(12);
// if(randomNum == 12)
// {
//     Console.WriteLine("Hello");
// }


Random rand = new Random();

// generate random number between 0 and 12 (inclusive)
int randomNum = rand.Next(13); 
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}

