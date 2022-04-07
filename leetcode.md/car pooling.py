class Solution:
    def carPooling(self, trips: List[List[int]], capacity: int) -> bool:
        
        pch  = [0] * 1001;
        
        for i in trips:
            numpass, start, end = i;
            pch[start] += numpass;
            pch[end] -= numpass;
        
        cur = 0;
        
        for i in range(1001):
            cur += pch[i];
            if cur > capacity:
                return False;
        return True;
