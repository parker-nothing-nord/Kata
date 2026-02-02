using System;

public class Kata
{
    public static int Size { get; set; }
    public static int LineCount { get; set; }

    public static int shortLineStartIndex { get; set; }
    public static int ShortLineEndIndex { get; set; }
    public static string GenerateC(int size)
    {
        Size = size;
        CalcLineData();
        string output = "\n";
    
        for (int i = 0; i < LineCount; i++) {
            // Long lines then short lines, then long lines.
            if (i < shortLineStartIndex || i > ShortLineEndIndex)
            {
                output += LongLine();
            }
            else
            {
                output += ShortLine();
            }
            output += "\n";
        }
    
        return output;
    }

    static string LongLine()
    {
        string line = "";
        for (int i = 0; i < 5 * Size; i++) {
            line += "C";
        }
        return line;
    }
    static string ShortLine() {
        string line = "";
        for (int i = 0; i < 5 * Size; i++) {
            line += "C";
        }
        return line;
    }

    static void CalcLineData()
    {
        LineCount = 5 * Size;
        shortLineStartIndex = Size;
        ShortLineEndIndex = 4 * Size - 1;
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
