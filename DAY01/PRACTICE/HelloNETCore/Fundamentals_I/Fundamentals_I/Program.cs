﻿// LOop that prints all values from 1-255

// for (int i = 1; i < 256; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 1; i < 101; i++)
// {
//     // if(i%3 == 0 || i%5 == 0)
//     // {
//     // Console.WriteLine(i);
//     //     Console.WriteLine();
//     // }

//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }
int i = 1;
while (i <= 100)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
    i++;
}