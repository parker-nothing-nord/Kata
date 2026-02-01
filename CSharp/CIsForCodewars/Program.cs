using System;

public class Kata
{
    public static string GenerateC(int size)
    {
        // TODO: Implement the solution
        return "Test output";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Running simple test...\n");

        string result = Kata.GenerateC(1);
        Console.WriteLine($"GenerateC(1) returned: '{result}'");
        Console.WriteLine("\nExpected:");
        Console.WriteLine("CCCCC");
        Console.WriteLine("C");
        Console.WriteLine("C");
        Console.WriteLine("C");
        Console.WriteLine("CCCCC");
    }
}
