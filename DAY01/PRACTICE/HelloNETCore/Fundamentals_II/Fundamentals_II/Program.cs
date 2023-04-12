/*******************************************Fundamentals_II*************************************************/


//------------------------------------------1. Print 1-255--------------------------------------------------


static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.

    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}
PrintNumbers();

Console.WriteLine("**********************************************************************************************************");



//------------------------------------------2. Print odd numbers between 1-255--------------------------------


static void PrintOddNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}


PrintOddNumbers();

Console.WriteLine("**********************************************************************************************************");


//------------------------------------------3. Print Sum---------------------------------------------------------------


static void PrintSum()
{
    int sum = 0;
    for (int i = 0; i <= 255; i++)
    {
        sum += i;
        Console.WriteLine($"New number: {i} Sum: {sum}");
    }
}


PrintSum();


Console.WriteLine("**********************************************************************************************************");



//------------------------------------------4. Iterating through an Array--------------------------------------------------


static void LoopArray(int[] numbers)
{
    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
}
int[] nums = new int[5];

LoopArray(nums);


Console.WriteLine("**********************************************************************************************************");

//------------------------------------------5. Find Max---------------------------------------------------------------------------


static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("The input array cannot be null or empty.");
    }
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;



}

int[] numbers = { 10, -20, 30, 40, -50 };
int max = FindMax(numbers);
Console.WriteLine("The maximum value in the array is: " + max);  // Output: The maximum value in the array is: 40


Console.WriteLine("***********************************************************************************************************");


//--------------------------------------------------------------------6. Get Average-------------------------------------------------------------


static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("The input array cannot be null or empty.");
    }

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    double average = (double)sum / numbers.Length;
    Console.WriteLine("The average of the values in the array is: " + average);
}



int[] numbers1 = { 2, 10, 3 };
GetAverage(numbers1);  // Output: The average of the values in the array is: 5

Console.WriteLine("***********************************************************************************************************");



//--------------------------------------------------------7. List with Odd Numbers-------------------------------------------------------------


static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
    List<int> oddNumbers = new List<int>();
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            oddNumbers.Add(i);
        }
    }
    return oddNumbers;
}

OddList();


Console.WriteLine("***********************************************************************************************************");



//--------------------------------------------------------8. Greater than Y----------------------------------------------------------------------------------


static int GreaterThanY(List<int> numbers3, int y)
{
    //  Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int count = 0;

    foreach (int number in numbers3)
    {
        if (number > y)
        {
            count++;
        }
    }

    return count;
}



List<int> numbers3 = new List<int> { 1, 3, 5, 7 };
int y = 3;
int count = GreaterThanY(numbers3, y);
Console.WriteLine("There are " + count + " numbers greater than " + y + " in the list.");  // Output: There are 2 numbers greater than 3 in the list.


Console.WriteLine("***********************************************************************************************************");


//----------------------------------------------------------------9. Square the Values-----------------------------------------------------------------


static void SquareArrayValues(List<int> numbers4)
{
     // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    for (int i = 0; i < numbers4.Count; i++)
    {
        numbers4[i] = numbers4[i] * numbers4[i];
    }
}

List<int> numbers4 = new List<int> {1, 5, 10, -10};
SquareArrayValues(numbers4);
Console.WriteLine(string.Join(", ", numbers4));  // Output: 1, 25, 100, 100


Console.WriteLine("***********************************************************************************************************");



//----------------------------------------------------------------10. Eliminate Negative Numbers------------------------------------------------------------

static void EliminateNegatives(List<int> numbers5)
{
    
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

    for (int i = 0; i < numbers5.Count; i++)
    {
        if (numbers5[i] < 0)
        {
            numbers5[i] = 0;
        }
    }
}



List<int> numbers5 = new List<int> {1, 5, 10, -2};
EliminateNegatives(numbers5);
Console.WriteLine(string.Join(", ", numbers5));  // Output: 1, 5, 10, 0

Console.WriteLine("***********************************************************************************************************");




















