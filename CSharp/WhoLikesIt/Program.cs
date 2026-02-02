using System;
using System.Linq;

public class Kata
{
    public static string Likes(string[] names)
    {
        // TODO: Implement the solution
        // Return the appropriate text based on the number of people who like the item
        switch (names.Length)
        {
            case 0:
                return "no one likes this";
            case 1:
                return $"{names[0]} likes this";
            case 2:
                return $"{names[0]} and {names[1]} like this";
            case 3:
                return $"{names[0]}, {names[1]} and {names[2]} like this";
            default:
                return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
        }

        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Running tests for Likes...\n");

        int passed = 0;
        int failed = 0;

        // Test 1: No one likes it
        string expected1 = "no one likes this";
        string result1 = Kata.Likes(new string[] { });
        if (result1 == expected1)
        {
            Console.WriteLine("✓ Test 1 passed: Likes([])");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 1 failed: Likes([])");
            Console.WriteLine($"Expected: \"{expected1}\"");
            Console.WriteLine($"Got: \"{result1}\"");
            failed++;
        }

        // Test 2: One person likes it
        string expected2 = "Peter likes this";
        string result2 = Kata.Likes(new string[] { "Peter" });
        if (result2 == expected2)
        {
            Console.WriteLine("✓ Test 2 passed: Likes([\"Peter\"])");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 2 failed: Likes([\"Peter\"])");
            Console.WriteLine($"Expected: \"{expected2}\"");
            Console.WriteLine($"Got: \"{result2}\"");
            failed++;
        }

        // Test 3: Two people like it
        string expected3 = "Jacob and Alex like this";
        string result3 = Kata.Likes(new string[] { "Jacob", "Alex" });
        if (result3 == expected3)
        {
            Console.WriteLine("✓ Test 3 passed: Likes([\"Jacob\", \"Alex\"])");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 3 failed: Likes([\"Jacob\", \"Alex\"])");
            Console.WriteLine($"Expected: \"{expected3}\"");
            Console.WriteLine($"Got: \"{result3}\"");
            failed++;
        }

        // Test 4: Three people like it
        string expected4 = "Max, John and Mark like this";
        string result4 = Kata.Likes(new string[] { "Max", "John", "Mark" });
        if (result4 == expected4)
        {
            Console.WriteLine("✓ Test 4 passed: Likes([\"Max\", \"John\", \"Mark\"])");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 4 failed: Likes([\"Max\", \"John\", \"Mark\"])");
            Console.WriteLine($"Expected: \"{expected4}\"");
            Console.WriteLine($"Got: \"{result4}\"");
            failed++;
        }

        // Test 5: Four or more people like it
        string expected5 = "Alex, Jacob and 2 others like this";
        string result5 = Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" });
        if (result5 == expected5)
        {
            Console.WriteLine("✓ Test 5 passed: Likes([\"Alex\", \"Jacob\", \"Mark\", \"Max\"])");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 5 failed: Likes([\"Alex\", \"Jacob\", \"Mark\", \"Max\"])");
            Console.WriteLine($"Expected: \"{expected5}\"");
            Console.WriteLine($"Got: \"{result5}\"");
            failed++;
        }

        // Test 6: Five people like it
        string expected6 = "Alice, Bob and 3 others like this";
        string result6 = Kata.Likes(new string[] { "Alice", "Bob", "Charlie", "David", "Eve" });
        if (result6 == expected6)
        {
            Console.WriteLine("✓ Test 6 passed: Likes([\"Alice\", \"Bob\", \"Charlie\", \"David\", \"Eve\"])");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 6 failed: Likes([\"Alice\", \"Bob\", \"Charlie\", \"David\", \"Eve\"])");
            Console.WriteLine($"Expected: \"{expected6}\"");
            Console.WriteLine($"Got: \"{result6}\"");
            failed++;
        }

        Console.WriteLine($"\n{passed} passed, {failed} failed");

        if (failed > 0)
        {
            Environment.Exit(1);
        }
    }
}
