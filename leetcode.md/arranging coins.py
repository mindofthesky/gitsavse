class Solution:
    def arrangeCoins(self, n: int) -> int:
        i, j = 1, n;
        res = 0;
        
        while i <= j :
            mid = (i + j) // 2;
            coins = (mid / 2) *(mid + 1);
            if coins > n:
                j = mid - 1;
            else:
                i = mid + 1;
                res = max(mid, res);
                
        return res;
