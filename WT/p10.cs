// Assignment No .: 10

// Q.C# program to swap two numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
classProgram
    {
staticvoid Main(string[] args)
        {
            int a, b, temp;
            a = 1;
            b = 3;

Console.WriteLine("\nBefore swapping:");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

            temp = a;
            a = b;
            b = temp;

Console.WriteLine("\nAfter swapping:");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

        }
    }
}
