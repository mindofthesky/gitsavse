이문제도 다시 풀필요가 있다 

class Solution:

    def divide(self, dividend: int, divisor: int) -> int:
        
        neg = ( (dividend < 0) != (divisor < 0) )
        dividend = left = abs(dividend)
        divisor  = div  = abs(divisor)
        count = 1
        ans = 0
        while left >= divisor:
            left -= div
            ans  += count 
            count += count
            div  += div
            if left < div:
                div = divisor           # revert current operation as it is not valid
                count = 1               # revert current count as it is not valid
        if neg:
            return max(-ans, -2147483648)
        else:
            return min(ans, 2147483647)
