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
        for (int i = 0; i < Size; i++) {
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
        Console.WriteLine("Generating a C according to your size specifications...\n");

        string result = "";
        int size = 0;

        switch (args.Length) {
            case 0:
                Console.WriteLine("No argument provided, using default size of 1:\n");
                size = 1;
                break;
            case 1:
            if (int.TryParse(args[0], out size)) {
                    Console.WriteLine($"Using size of {size}:\n");
                } else {
                    Console.WriteLine("Invalid size provided. Please provide a valid integer.\n");
                    Environment.Exit(1);
                }
                
                size = int.Parse(args[0]);
                break;
            default:
                Console.WriteLine("Too many arguments provided. Please only use the size of the C to generate. \n");
                Environment.Exit(1);
                break;
        }

        switch (size)
        {
            case 0:
                Console.WriteLine("Using default size of 1:\n");
                result = Kata.GenerateC(1);
                break;
            case >10:
                Console.WriteLine("We are here to print a C, not an ocean! Please provide a size less than 10.\n");
                break;
            default:
                result = Kata.GenerateC(size);
                break;
        }
        Console.WriteLine($"\n{result}");
        Console.WriteLine("\nProgram finished.");

    }
}
