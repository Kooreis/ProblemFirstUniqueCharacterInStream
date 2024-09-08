def add(self, char):
        self.stream.append(char)
        if char in self.count:
            self.count[char] += 1
        else:
            self.count[char] = 1