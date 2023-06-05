class Solution:
    def checkStraightLine(self, coordinates: List[List[int]]) -> bool:
        slope = self.get_slope(coordinates[0], coordinates[1])
        for i in range(2, len(coordinates)):
            m = self.get_slope(coordinates[i], coordinates[0])
            if (m != slope):
                return False
        return True

    def get_slope(self, p1:List[int], p2: List[int]):
        if(p1[0] ==p2[0]):
            return 100000
        return (float)(p2[1] - p1[1])/(p2[0] - p1[0])
