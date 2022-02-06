class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        res = [];
        nums.sort();
        
        def ba(i, subset):
            if i == len(nums):
                res.append(subset[::]);
                return
            
            subset.append(nums[i]);
            ba(i + 1, subset);
            subset.pop();
            
            while i + 1 < len(nums) and nums[i] == nums[i + 1]:
                i += 1;
            ba(i + 1, subset);
        ba(0, []);
        return res;
