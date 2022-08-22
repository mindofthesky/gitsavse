class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        
        def reverse (i, j):
            if i < j :
                s[i] , s[j] = s[j] , s[i];
                reverse(i + 1 , j -1);
        reverse(0, len(s) -1);
