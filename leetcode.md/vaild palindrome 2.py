class Solution:
    def validPalindrome(self, s: str) -> bool:
        i, j = 0 , len(s) - 1;
        
        while i < j :
            if s[i] != s[j]:
                skip1, skip2 = s[i + 1 : j + 1], s[i:j];
                return (skip1 == skip1[::-1] or skip2 == skip2[::-1])
            i,j = i+1, j -1;
        return True;
