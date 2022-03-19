class FreqStack:

    def __init__(self):
        self.cnt = {};
        self.maxcount = 0;
        self.stack = {};
        

    def push(self, val: int) -> None:
        valcnt = 1 + self.cnt.get(val, 0);
        self.cnt[val] = valcnt;
        if valcnt > self.maxcount:
            self.maxcount = valcnt;
            self.stack[valcnt] = [];
        self.stack[valcnt].append(val);

    def pop(self) -> int:
        res = self.stack[self.maxcount].pop();
        self.cnt[res] -= 1;
        if not self.stack[self.maxcount]:
            self.maxcount -= 1;
        return res;
