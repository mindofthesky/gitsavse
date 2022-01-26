class Solution:
    def getPermutation(self, n: int, k: int) -> str:
        res = [1];
        for i in range(1, n ):
            res.append(res[-1] * i);
        k -=1;
        digits = list(map(str, range(1, n+1)));
        result = [];
        
        while n:
            i, k = divmod(k, res[n-1]);
            result.append(digits.pop(i));
            n -= 1;
            
        return ''.join(result);
