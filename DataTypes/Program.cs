using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Value Type Example
        int a = 10;
        int b = a; // copy value
        b = 20;

        Console.WriteLine("Value Type:");
        Console.WriteLine("a = " + a); // 10
        Console.WriteLine("b = " + b); // 20

        // Reference Type Example
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1; // reference copy
        arr2[0] = 99;

        Console.WriteLine("\nReference Type:");
        Console.WriteLine("arr1[0] = " + arr1[0]); // 99
        Console.WriteLine("arr2[0] = " + arr2[0]); // 99

        // String (immutable)
        string str1 = "Hello";
        string str2 = str1;
        str2 = "World";

        Console.WriteLine("\nString (Immutable):");
        Console.WriteLine("str1 = " + str1); // Hello
        Console.WriteLine("str2 = " + str2); // World

        // StringBuilder (mutable)
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");

        Console.WriteLine("\nStringBuilder (Mutable):");
        Console.WriteLine("sb = " + sb.ToString()); // Hello World
    }
}