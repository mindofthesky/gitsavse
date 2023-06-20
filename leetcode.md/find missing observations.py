class Solution:
    def missingRolls(self, rolls: List[int], mean: int, n: int) -> List[int]:
        m = len(rolls)
        ntotal = (mean * (n + m )) - sum(rolls)

        if ntotal < n or ntotal > n * 6:
            return []

        res = []
        while ntotal:
            dice = min(ntotal - n + 1, 6)
            res.append(dice)
            ntotal -= dice
            n -= 1

        return res
