class Solution:
    def wordPattern(self, pattern: str, s: str) -> bool:
        word = s.split(" ");
        if len(pattern) != len(word):
            return False;
        
        char = {};
        wordchar = {};
        
        for i,j in zip(pattern, word):
            if i in char and char[i] != j:
                return False;
            if j in wordchar and wordchar[j] != i:
                return False;
            char[i] = j;
            wordchar[j] = i;
        return True;
