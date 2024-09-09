# Question: How can you implement a system to find the first unique character in a stream? C# Summary

The provided C# code is a console application that solves the problem of finding the first unique character in a stream. The program starts by prompting the user to enter a string. It then calls the `GetFirstUniqueCharacter` method, passing the user's input as an argument. This method uses a dictionary to keep track of the count of each character in the string. It iterates over the string, incrementing the count for each character in the dictionary. After counting the occurrences of each character, the method iterates over the string again, checking the count of each character in the dictionary. The first character that has a count of one is returned as the first unique character. If no unique character is found, the method returns the null character. This approach ensures that the first unique character in the input string is found efficiently, regardless of the string's length.

---

# Python Differences

The Python version of the solution is similar to the C# version in terms of logic. Both versions use a dictionary (or a similar data structure) to keep track of the count of each character in the input. They then iterate over the input to find the first character that appears only once.

However, there are some differences in the implementation due to the differences in the languages:

1. The Python version uses a class to encapsulate the stream and the count dictionary, while the C# version uses a static method in the Program class. This is more of a design choice than a language feature.

2. The Python version uses a list to store the stream of characters, while the C# version uses a string. This is because strings in Python are immutable, so appending to a string would create a new string each time, which is inefficient. Lists in Python are mutable, so appending to a list is efficient.

3. The Python version uses the `input()` function to read a character from the console, while the C# version uses `Console.ReadLine()`. The Python `input()` function returns a string, while `Console.ReadLine()` in C# returns a string as well.

4. The Python version uses a continuous loop to keep asking the user for input until the user types 'exit', while the C# version only asks for input once. This is a difference in the problem requirements rather than a language feature.

5. The Python version returns `None` if there is no unique character, while the C# version returns the null character (`'\0'`). This is a difference in the way the two languages represent the absence of a value. In Python, `None` is used to represent the absence of a value, while in C#, the null character is often used to represent the absence of a character.

---

# Java Differences

The Java version of the solution uses similar logic to the C# version. Both versions read a string from the console, use a dictionary (or Map in Java) to count the occurrences of each character in the string, and then iterate over the string or dictionary again to find the first character that only appears once.

However, there are a few differences in the language features and methods used:

1. Reading Input: In C#, `Console.ReadLine()` is used to read the input string from the console. In Java, a `Scanner` object is used to read the input string.

2. Dictionary/Map: In C#, a `Dictionary<char, int>` is used to store the character counts. In Java, a `LinkedHashMap<Character, Integer>` is used. The `LinkedHashMap` in Java maintains the insertion order, which is important for finding the first unique character.

3. Checking and Updating Counts: In C#, the `ContainsKey` method is used to check if a character is already in the dictionary, and if it is, the count is incremented. If it's not, the character is added to the dictionary with a count of 1. In Java, the `getOrDefault` method is used to get the current count of a character (or 0 if it's not in the map), and then the count is incremented.

4. Iterating Over Characters: In C#, the input string is iterated over again to find the first unique character. In Java, the `entrySet` of the map is iterated over. This is possible because a `LinkedHashMap` was used, which maintains the insertion order.

5. Return Value: If no unique character is found, the C# version returns the null character (`'\0'`), while the Java version returns `null`.

---
