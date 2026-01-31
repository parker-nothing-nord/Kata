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

