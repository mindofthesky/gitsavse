class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        n = len(nums);
        sumExp = n*(n+1)//2;
        sumAct = sum(nums);
        
        return sumExp - sumAct;
