class Solution:
    def isPowerOfThree(self, n: int) -> bool:
        mx = 3**19;
        
        return n > 0 and mx%n == 0;
