using System;

public class Kata
{
    public static int Size { get; set; }
    public static string GenerateC(int size)
    {
        Size = size;
        // TODO: Implement the solution
    string output = "";
    output += lineOne(size);
    
    

        return output;
    }


    static string lineOne(int size) {
        string line = "";
        for (int i = 0; i < 5 * size; i++) {
            line += "C";
        }
        return line;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running simple test...\n");

        string result = "";
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
