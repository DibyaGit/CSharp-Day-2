using System;

class Program
{
    static void Main()
    {
        // Value type
        int num = 10;

        // Boxing (value type -> object)
        object boxed = num;

        Console.WriteLine("Boxed value: " + boxed);
        Console.WriteLine("Type of boxed: " + boxed.GetType());

        // Unboxing (object -> value type)
        int unboxed = (int)boxed;

        Console.WriteLine("Unboxed value: " + unboxed);
        Console.WriteLine("Type of unboxed: " + unboxed.GetType());
    }
}