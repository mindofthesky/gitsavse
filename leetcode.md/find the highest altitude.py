class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        result = [0]
        for i in range(0, len(gain)):
            temp = result[i] + gain[i]
            result.append(temp)
        return max(result)
