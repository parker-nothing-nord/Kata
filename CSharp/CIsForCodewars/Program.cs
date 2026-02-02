using System;

public class Kata
{
    int size;
    public static string GenerateC(int size)
    {
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

        string result = Kata.GenerateC(1);
        if (args.Length > 0)
        {
            int size = int.Parse(args[0]);
            result = Kata.GenerateC(size);
        }
        else
        {
            Console.WriteLine("No argument provided, using default size of 1");
            result = Kata.GenerateC(1);
        }
        
        Console.WriteLine($"GenerateC(1) returned: \n'{result}'");
        Console.WriteLine("\nExpected:");
        Console.WriteLine("CCCCC");
        Console.WriteLine("C");
        Console.WriteLine("C");
        Console.WriteLine("C");
        Console.WriteLine("CCCCC");

    }
}
