class Solution:
    def titleToNumber(self, s: str) -> int:
        mul = 1;
        col = 0;
        for i in range(len(s)-1, -1, -1):
            col += (ord(s[i])-64) * mul;
            mul *= 26;
            
        return col
