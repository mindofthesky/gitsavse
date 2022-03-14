class Solution:
    def guessNumber(self, n: int) -> int:
        i, j = 1, n;
        
        while True:
            m = ( i + j ) // 2;
            res = guess(m);
            if res > 0:
                i = m + 1;
            elif res < 0:
                j = m - 1;
            else:
                return m;
