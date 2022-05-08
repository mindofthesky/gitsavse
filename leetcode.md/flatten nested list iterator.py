class NestedIterator:
    def __init__(self, nestedList: [NestedInteger]):
        
        def flatten(nl):
            tmp = [];
            for i in nl:
                if i.isInteger():
                    tmp.append(i.getInteger());
                else:
                    tmp.extend(flatten(i.getList()));
            return tmp
                             
        self.n = deque(flatten(nestedList));
    
    def next(self) -> int:
        return self.n.popleft();
    
    def hasNext(self) -> bool:
         return self.n;
