class Solution:

    def threeSumClosest(self, nums: List[int], target: int) -> int:
        nums.sort();
        res = sum(nums[:3]);
        
        for i in range(len(nums) -2 ):
            s = i + 1;
            e = len(nums) - 1;
            
            
            while s < e:
                sum_num = nums[i] + nums[s] + nums[e];
                if abs(sum_num - target ) < abs(res - target ):
                    res = sum_num;
                if sum_num < target :
                    s += 1;
                else:
                    e -= 1;
        return res;
                
