class Solution:
    def rotate(self, nums: List[int], k: int) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        k = k % len(nums);
        i, j = 0 , len(nums) - 1;
        
        while i < j:
            nums[i] , nums[j] = nums[j], nums[i];
            i,j = i + 1 , j -1;
        i,j = 0 , k - 1;
        while i < j :
            nums[i] , nums[j] = nums[j], nums[i];
            i, j = i + 1, j - 1;
        
        i,j = k, len(nums) -1;
        while i < j :
            nums[i], nums[j] = nums[j], nums[i];
            i,j = i+1, j-1;
            
