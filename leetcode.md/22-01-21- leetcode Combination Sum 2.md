class Solution:

    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        if not candidates or not target:
            return []
    
        candidates.sort()
        res = []
        def dfs(i, cur, total ):
            if i > len(candidates) or total > target:
                return 
            if target == total and cur not in res:
                res.append(cur.copy())
                return 
            for j in range(i, len(candidates)):
                if candidates[j] > target:
                    continue
                if candidates[j] + total > target:
                    break
                if j > 0 and j > i and candidates[j]==candidates[j-1]:
                    continue
                dfs(j+1 , cur + [candidates[j]], total+candidates[j])
                    
            return 
        dfs(0,[],0)
        return res
