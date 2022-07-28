class Solution:
    def minPatches(self, nums: List[int], n: int) -> int:
        i, out, upto = 0,0,0;
        m = len(nums);
        while upto<n:
            if i<m and nums[i]<= upto+1:
                upto += nums[i];
                i +=1;
            else:
                out +=1;
                upto += (upto + 1);
        return out;
