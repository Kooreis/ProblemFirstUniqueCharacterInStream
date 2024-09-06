Here is a Java console application that finds the first unique character in a stream:

```java
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a string:");
        String input = scanner.nextLine();
        System.out.println("First unique character: " + findFirstUniqueCharacter(input));
    }

    private static Character findFirstUniqueCharacter(String input) {
        Map<Character, Integer> counts = new LinkedHashMap<>();
        for (char c : input.toCharArray()) {
            counts.put(c, counts.getOrDefault(c, 0) + 1);
        }
        for (Map.Entry<Character, Integer> entry : counts.entrySet()) {
            if (entry.getValue() == 1) {
                return entry.getKey();
            }
        }
        return null;
    }
}
```

This program reads a string from the console, then finds and prints the first unique character in the string. If no unique character is found, it prints "null".