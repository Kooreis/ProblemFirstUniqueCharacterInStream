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
    }