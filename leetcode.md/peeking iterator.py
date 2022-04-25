class PeekingIterator:
    def __init__(self, iterator):
        """
        Initialize your data structure here.
        :type iterator: Iterator
        """
        self.i = iterator;
        self.peeked = False;
        self.tmp = None;
        

    def peek(self):
        """
        Returns the next element in the iteration without advancing the iterator.
        :rtype: int
        """
        if not self.peeked:
            self.peeked = True;
            self.tmp = self.i.next();
            return self.tmp;
        else:
            return self.tmp;
        

    def next(self):
        """
        :rtype: int
        """
        if self.peeked:
            self.peeked = False;
            return self.tmp;
        else:
            return self.i.next();
        

    def hasNext(self):
        """
        :rtype: bool
        """
        if self.peeked or self.i.hasNext():
            return True;
        else:
            return False;
