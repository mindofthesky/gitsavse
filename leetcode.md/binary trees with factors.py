class Solution:
    def numFactoredBinaryTrees(self, arr: List[int]) -> int:
        arr.sort();
        l = defaultdict(int);
        for a in arr:
            temp = 1;
            for b in arr:
                if b > a: break
                temp += (l[b] * l[a/b]);
            l[a] = temp;
        return sum(l.values())%(10**9+7);
