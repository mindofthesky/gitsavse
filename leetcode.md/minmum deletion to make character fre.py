class Solution:
    def minDeletions(self, s: str) -> int:
        count = collections.Counter(s);
        res = 0;
        used = set();
        for char, fre in count.items():
            while fre > 0 and fre in used:
                fre -= 1;
                res += 1;
            used.add(fre);
        return res;
