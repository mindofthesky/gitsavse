class Solution:
    def getMoneyAmount(self, n: int) -> int:
        dp = [[0] * (n+2) for _ in range(n+2)];
        
        for len in range(2, n+1):
            for i in range(1, n - len + 2):
                j = i + len - 1;
                
                dp[i][j] = sys.maxsize;
                
                for k in range(i, j + 1):
                    next_step = max(dp[i][k-1], dp[k+1][j]);
                    dp[i][j] = min(dp[i][j], k + next_step);
                    
        return dp[1][n];
