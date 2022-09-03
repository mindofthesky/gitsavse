class Solution:
    def numsSameConsecDiff(self, n: int, k: int) -> List[int]:
        temp = range(10);
        cur = []; 
        for i in range(n-1):
            temp = {x * 10 + y for x in temp for y in [x%10 + k , x% 10 - k] if x and 0 <= y<10}
            
        return list(temp)
