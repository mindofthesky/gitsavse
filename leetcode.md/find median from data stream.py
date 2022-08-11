class MedianFinder:
    
        def __init__(self):
            
            self.top = [] 
            self.bot = [] 

        def addNum(self, num: int) -> None:
            heappush(self.top, -num)
            heappush(self.bot, -heappop(self.top))
            if len(self.top) < len(self.bot):
                heappush(self.top, -heappop(self.bot))

        def findMedian(self) -> float:
            if len(self.top) == len(self.bot): 
                return (-self.top[0] + self.bot[0])/2
            return -self.top[0]
