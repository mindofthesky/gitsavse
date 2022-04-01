class Solution:
    def findClosestElements(self, arr: List[int], k: int, x: int) -> List[int]:
        i, j = 0, len(arr) - k
        
        while i < j:
            m = (i + j) // 2
            if x - arr[m] > arr[m + k] - x:
                i = m + 1
            else: 
                j = m
        return arr[i:i+k]
