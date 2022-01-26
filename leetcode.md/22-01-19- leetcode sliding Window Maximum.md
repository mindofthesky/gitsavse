class Solution:

    def maxSlidingWindow(self, nums: List[int], k: int) -> List[int]:
        deq, ans = deque(), [];
        
        for i in range(len(nums)):
            if deq and i-deq[0] == k:
                deq.popleft();

            while deq and nums[deq[-1]] <= nums[i]:
                deq.pop();

            deq.append(i) 

            if i+1 >= k:
                ans.append(nums[deq[0]]);

        return ans;
