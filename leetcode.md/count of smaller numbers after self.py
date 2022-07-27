class BIT:
    def __init__(self, n):
        self.sums = [0]*(n+1);
    def update(self,i,v):
        while i < len(self.sums):
            self.sums[i] += v;
            i += (i&-i);
    def query(self, i):
        res = 0;
        while i > 0:
            res += self.sums[i];
            i -= (i&-i);
        return res
class Solution:
    def countSmaller(self, nums: List[int]) -> List[int]:
        e = {v: i for i, v in enumerate(sorted(set(nums)))};
        b = BIT(len(e));
        out = [];
        indexes = [e[n] for n in nums];
        for i in indexes[::-1]:
            ans = b.query(i);
            out.append(ans);
            b.update(i+1, 1);
        return reversed(out);
