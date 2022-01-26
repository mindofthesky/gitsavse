class Solution:

    def myPow(self, x: float, n: int) -> float:
        if n == 0: return 1
        if n < 0: n, x = -n, 1 / x
            
        lower = self.myPow(x, n//2)
        return lower * lower * x if n % 2 else lower * lower
                
