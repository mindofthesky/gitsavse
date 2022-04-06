class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        i = 0;
        
        for a in range(len(nums)):
            if nums[a]:
                nums[i], nums[a] = nums[a], nums[i];
                i += 1;
        return nums;
