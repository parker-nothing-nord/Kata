using System;

public class Kata
{
    public static int Size { get; set; }
    public static string GenerateC(int size)
    {
        Size = size;
        string output = "";
        int lineCount = calcLine();
        foreach (int i in Enumerable.Range(0, lineCount)) {
            
        output += lineOne(size);
    }
    
        return output;
    }


    static string lineOne(int size) {
        string line = "";
        for (int i = 0; i < 5 * size; i++) {
            line += "C";
        }
        return line;
    }

    static int calcLine()
    {
        return 5 * Size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running simple test...\n");

        string result = "";
    // @todo Add switch statment for size > 3 - to short circuit calculation if it will be too large.
        if (args.Length > 0)
        {
            int size = int.Parse(args[0]);
            Console.WriteLine($"Testing with size = {size}:\n");
            result = Kata.GenerateC(size);
        }
        else
        {
            Console.WriteLine("No argument provided, using default size of 1:\n");
            result = Kata.GenerateC(1);
        }
        Console.WriteLine($"\n'{result}'");
        Console.WriteLine("\nProgram finished.");

    }
}
