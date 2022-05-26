class Solution:
    def findNthDigit(self, n: int) -> int:
        len = 1;
        count = 9;
        
        while n > len * count:
            n -= len *count;
            len += 1;
            count *= 10;
        start = 10 ** (len-1);
        
        num, remain = divmod(n, len);
        
        if remain == 0:
            return int(str(start + num -1)[-1]);
        else:
            return int(str(start + num)[remain-1]);
