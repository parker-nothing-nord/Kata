using System;

public class CisforCodewars {
   
    public static string GenerateC(int size)
    {
      string output = "";
      string longLine = new String('C', size * 5);
      string shortLine = new string('C', size);
      longLine += "\n";
      shortLine += "\n";
      output += string.Concat(Enumerable.Repeat(longLine, size));
      output += string.Concat(Enumerable.Repeat(shortLine, size * 3));
      output += string.Concat(Enumerable.Repeat(longLine, size));
      output = output.TrimEnd('\n');
      
      return output;
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
                result = CisforCodewars.GenerateC(1);
                break;
            case >10:
                Console.WriteLine("We are here to print a C, not an ocean! Please provide a size less than 10.\n");
                break;
            default:
                result = CisforCodewars.GenerateC(size);
                break;
        }
        Console.WriteLine($"\n{result}");
        Console.WriteLine("\nProgram finished.");

    }

    public class AlternateSoulution {
   
    public static string GenerateC(int size)
    {
   
        string output = "";
        string line = "";
        for (int i = 0; i < 5 * size; i++) {
          line = "";
            if (i < size || i > 4 * size -1)
            {      
               // Long line
               for (int l = 0; l < 5 * size; l++) {
               line += "C";
               }
            }  
            else
            {
              // Short line.
                for (int l = 0; l < size; l++) {
                   line += "C";
                } 
            }
            output += line;
            if (i == 5 * size -1) {
              continue;
            }
            
            output += "\n";
        }
    
        return output;
    }

}
}
