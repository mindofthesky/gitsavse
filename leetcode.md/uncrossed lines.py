class Solution:
    def maxUncrossedLines(self, A: List[int], B: List[int]) -> int:
        N = len(A)
        M = len(B)

        dp = [[0 for n in range(N+1)] for m in range(M+1)]

        for m in range(1, M+1):
            for n in range(1, N+1):
                if A[n-1] == B[m-1]:
                    dp[m][n] = 1 + dp[m-1][n-1]
                else:
                    dp[m][n] = max(dp[m][n-1], dp[m-1][n])
        return dp[m][n]
        print(dp)
