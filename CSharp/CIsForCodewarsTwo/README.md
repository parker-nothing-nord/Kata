# C is for Codewars

**Difficulty:** 7 kyu  
**Link:** https://www.codewars.com/kata/675dc1d3830826975c58a09d

## Task

Build a string representing a capital letter C of a given size out of 'C' characters.

## Examples

### GenerateC(1)
Should return this string:
```
CCCCC
C
C
C
CCCCC
```

### GenerateC(2)
Should be:
```
CCCCCCCCCC
CCCCCCCCCC
CC
CC
CC
CC
CC
CC
CCCCCCCCCC
CCCCCCCCCC
```

## Rules

- Given `size`, the string should have `5*size` lines, following the format above
- `size` is a positive integer ≤ 2000
- Extra spaces after the C's in any line are incorrect
- The last line should not terminate with "\n"

## Inspired By

This kata was inspired by [A for Apple](https://www.codewars.com/kata/55de3f83e92c3e521a00002a), but takes a different approach to generating letters.

---

## How to Compile and Test

### Prerequisites

You need to install the .NET SDK first. Choose one of these methods:

**Option 1: Using apt (Recommended)**
```bash
sudo apt update
sudo apt install dotnet-sdk-8.0
```

**Option 2: Using snap**
```bash
sudo snap install dotnet-sdk --classic
```

**Option 3: Using Mono (Alternative)**
```bash
sudo apt install mono-complete
```

### Quick Test (Simple Method)

Once you have .NET SDK or Mono installed, you can compile and run the tests:

**With Mono:**
```bash
cd CSharp/CIsForCodewars
mcs Solution.cs Tests.cs -out:kata.exe
mono kata.exe
```

**With .NET SDK (csc):**
```bash
cd CSharp/CIsForCodewars
csc Solution.cs Tests.cs -out:kata.exe
./kata.exe
```

### Proper .NET Project Setup (Recommended for larger projects)

If you want a full .NET project structure with proper testing:

```bash
cd CSharp/CIsForCodewars

# Create a class library project
dotnet new classlib -n CIsForCodewars
mv Solution.cs CIsForCodewars/

# Create a test project
dotnet new xunit -n CIsForCodewars.Tests

# Add reference from test project to main project
cd CIsForCodewars.Tests
dotnet add reference ../CIsForCodewars/CIsForCodewars.csproj

# Run tests
dotnet test
```

### Files

- `Solution.cs` - Your implementation goes here
- `Tests.cs` - Simple test runner (works with both Mono and .NET)

