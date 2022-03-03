class Solution:
    def lengthOfLIS(self, nums: List[int]) -> int:
        list1 = [1] * len(nums);
        
        for i in range(len(nums) -1 , -1, -1):
            for j in range(i+1, len(nums)):
                if nums[i] < nums[j]:
                    list1[i] = max(list1[i], 1+ list1[j]);
        return max(list1);
