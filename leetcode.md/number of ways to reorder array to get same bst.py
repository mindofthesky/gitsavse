class Solution:
    def numOfWays(self, nums: List[int]) -> int:
        mod = 10 ** 9 + 7

        def combination(l, r):
            return factorial[l+r] // factorial[l] // factorial[r]
        def ways(arr):
            if len(arr) <= 2:
                return 1
            
            root = arr[0]

            left = [num for num in arr if num < root]
            right = [num for num in arr if num > root]

            return ways(left) * ways(right) * combination(len(left), len(right))
        
        n = len(nums)

        factorial = [1] * (n)

        for i in range(1, n):
            factorial[i] = factorial[i-1] * i
        return (ways(nums) -1 ) % mod
