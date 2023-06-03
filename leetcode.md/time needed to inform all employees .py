class Solution:
    def numOfMinutes(self, n: int, headID: int, manager: List[int], informTime: List[int]) -> int:
        mge = collections.defaultdict(list)
        for i in range(n):
            mge[manager[i]].append(i)

        q = deque([(headID, 0)])
        res = 0 
        while q :
            i ,  time = q.popleft()
            res = max(res, time)
            for emp in mge[i]:
                q.append((emp, time + informTime[i]))
        
        return res
