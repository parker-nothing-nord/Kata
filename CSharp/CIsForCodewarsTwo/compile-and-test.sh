#!/bin/bash

# Simple script to compile and test C# kata solutions

echo "Compiling C# files..."

# Try with Mono first
if command -v mcs &> /dev/null; then
    echo "Using Mono C# compiler (mcs)..."
    mcs Solution.cs Tests.cs -out:kata.exe
    if [ $? -eq 0 ]; then
        echo "Compilation successful! Running tests..."
        mono kata.exe
        exit $?
    else
        echo "Compilation failed!"
        exit 1
    fi
fi

# Try with .NET SDK
if command -v csc &> /dev/null; then
    echo "Using .NET C# compiler (csc)..."
    csc Solution.cs Tests.cs -out:kata.exe
    if [ $? -eq 0 ]; then
        echo "Compilation successful! Running tests..."
        ./kata.exe
        exit $?
    else
        echo "Compilation failed!"
        exit 1
    fi
fi

# Neither found
echo "Error: No C# compiler found!"
echo "Please install either:"
echo "  - .NET SDK: sudo apt install dotnet-sdk-8.0"
echo "  - Mono: sudo apt install mono-complete"
exit 1

