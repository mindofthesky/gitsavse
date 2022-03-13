class Solution:
    def findMinDifference(self, timePoints: List[str]) -> int:
        for i, time in enumerate(timePoints):
            hour, minutes = time.split(":");
            min_past = int(hour) * 60 + int(minutes);
            timePoints[i] = min_past;
        timePoints.sort();
        
        res = 1440 + timePoints[0] -timePoints[-1];
        
        for i in range(1, len(timePoints)):
            res = min(res, timePoints[i] - timePoints[i - 1]);
        
        return res;
