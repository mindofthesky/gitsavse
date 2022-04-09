class RandomizedSet:

    def __init__(self):
        self.nummap = {};
        self.numlist = [];

    def insert(self, val: int) -> bool:
        res = val not in self.nummap;
        if res:
            self.nummap[val] = len(self.numlist);
            self.numlist.append(val);
        return res;

    def remove(self, val: int) -> bool:
        res = val in self.nummap;
        if res:
            idx = self.nummap[val];
            lastval = self.numlist[-1];
            self.numlist[idx] = lastval;
            self.numlist.pop();
            self.nummap[lastval] = idx;
            del self.nummap[val];
        return res;
    def getRandom(self) -> int:
        return random.choice(self.numlist);
