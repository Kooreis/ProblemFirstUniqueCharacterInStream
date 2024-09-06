Here is a simple console application in C# that finds the first unique character in a stream:

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine("First unique character: " + GetFirstUniqueCharacter(input));
    }

    static char GetFirstUniqueCharacter(string input)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c]++;
            }
            else
            {
                characterCount[c] = 1;
            }
        }

        foreach (char c in input)
        {
            if (characterCount[c] == 1)
            {
                return c;
            }
        }

        return '\0';
    }
}
```

This program reads a string from the console, then uses a dictionary to count the occurrences of each character in the string. It then iterates over the string again, returning the first character that only appears once. If no such character exists, it returns the null character (`'\0'`).