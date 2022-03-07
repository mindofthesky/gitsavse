class Solution:
    def isPerfectSquare(self, num: int) -> bool:
        for i in range(1, num + 1):
            if i * i == num:
                return True;
            if i * i > num:
                return False;
            
            i, j = 1, num;
            while  i <= j :
                mid = (i + j) // 2;
                if mid * mid > num:
                    j = mid - 1;
                elif mid * mid < num:
                    i = mid + 1;
                else:
                    return True;
            return False;
