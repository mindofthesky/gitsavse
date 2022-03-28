class Solution:
    def longestCommonSubsequence(self, text1: str, text2: str) -> int:
        n, m = len(text1), len(text2);
        
        dp = [[0] * (m + 1) for _ in range(n + 1)];
        
        for r in range(1, n + 1):
            for c in range(1, m + 1):
                if text1[r-1] == text2[c-1]:
                    dp[r][c] = 1 + dp[r-1][c-1];
                else:
                    dp[r][c] = max(dp[r-1][c], dp[r][c-1]);
        return dp[-1][-1];
