class Solution:
    def minCost(self, colors: str, neededTime: List[int]) -> int:
        n = len(colors);
        ans = 0;
        max_cost = 0;

        for i in range(n):
            ans += neededTime[i];
            max_cost = max(max_cost, neededTime[i]);

            if i == n - 1 or colors[i] != colors[i+1]:
                ans -= max_cost;
                max_cost = 0;
        
        return ans;
