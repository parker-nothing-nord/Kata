# Who likes it?

**Difficulty:** 6 kyu  
**Link:** https://www.codewars.com/kata/5266876b8f4bf2da9b000362

## Task

You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

## Examples

```
[]                                -->  "no one likes this"
["Peter"]                         -->  "Peter likes this"
["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
```

**Note:** For 4 or more names, the number in `"and 2 others"` simply increases.

## How to Compile and Test

```bash
cd CSharp/WhoLikesIt
dotnet run
```

This will compile and run the tests automatically.

## Files

- `Program.cs` - Your implementation and test runner
- `WhoLikesIt.csproj` - .NET project configuration

