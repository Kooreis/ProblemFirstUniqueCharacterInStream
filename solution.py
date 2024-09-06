Here is a Python console application that implements a system to find the first unique character in a stream:

```python
class Stream:
    def __init__(self):
        self.stream = []
        self.count = {}

    def add(self, char):
        self.stream.append(char)
        if char in self.count:
            self.count[char] += 1
        else:
            self.count[char] = 1

    def first_unique(self):
        for char in self.stream:
            if self.count[char] == 1:
                return char
        return None

def main():
    s = Stream()
    while True:
        print("Enter a character (or 'exit' to quit): ")
        char = input()
        if char == 'exit':
            break
        s.add(char)
        print("First unique character so far: ", s.first_unique())

if __name__ == "__main__":
    main()
```

This console application continuously asks the user to input a character. It adds the character to the stream and then prints the first unique character in the stream so far. The user can stop the program by typing 'exit'.