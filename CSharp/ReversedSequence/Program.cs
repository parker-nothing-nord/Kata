using System;
using System.Linq;

public class Kata
{
    public static int[] ReverseSeq(int n)
    {
        // TODO: Implement the solution
        // Build a function that returns an array of integers from n to 1 where n > 0
        // Example: n = 5 --> [5, 4, 3, 2, 1]
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Running tests for ReverseSeq...\n");

        int passed = 0;
        int failed = 0;

        // Test 1: n = 5
        int[] expected1 = new int[] { 5, 4, 3, 2, 1 };
        int[] result1 = Kata.ReverseSeq(5);
        if (result1.SequenceEqual(expected1))
        {
            Console.WriteLine("✓ Test 1 passed: ReverseSeq(5)");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 1 failed: ReverseSeq(5)");
            Console.WriteLine($"Expected: [{string.Join(", ", expected1)}]");
            Console.WriteLine($"Got: [{string.Join(", ", result1)}]");
            failed++;
        }

        // Test 2: n = 1
        int[] expected2 = new int[] { 1 };
        int[] result2 = Kata.ReverseSeq(1);
        if (result2.SequenceEqual(expected2))
        {
            Console.WriteLine("✓ Test 2 passed: ReverseSeq(1)");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 2 failed: ReverseSeq(1)");
            Console.WriteLine($"Expected: [{string.Join(", ", expected2)}]");
            Console.WriteLine($"Got: [{string.Join(", ", result2)}]");
            failed++;
        }

        // Test 3: n = 3
        int[] expected3 = new int[] { 3, 2, 1 };
        int[] result3 = Kata.ReverseSeq(3);
        if (result3.SequenceEqual(expected3))
        {
            Console.WriteLine("✓ Test 3 passed: ReverseSeq(3)");
            passed++;
        }
        else
        {
            Console.WriteLine("✗ Test 3 failed: ReverseSeq(3)");
            Console.WriteLine($"Expected: [{string.Join(", ", expected3)}]");
            Console.WriteLine($"Got: [{string.Join(", ", result3)}]");
            failed++;
        }

        Console.WriteLine($"\n{passed} passed, {failed} failed");

        if (failed > 0)
        {
            Environment.Exit(1);
        }
    }
}
