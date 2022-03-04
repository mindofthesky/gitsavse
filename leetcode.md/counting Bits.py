class Solution:
    def countBits(self, n: int) -> List[int]:
        dp = [0] * (n + 1);
        set1 = 1;
        
        for i in range(1, n + 1 ):
            if set1 * 2 == i:
                set1 = i ;
            dp[i] = 1 + dp[i - set1];
        return dp
