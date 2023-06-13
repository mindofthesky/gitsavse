class Solution:
    def equalPairs(self, grid: List[List[int]]) -> int:
        row_count = collections.Counter([tuple(row) for row in grid])
        col_count = collections.Counter([item for item in zip(*grid)])

        res = 0

        for key in row_count:
            res += row_count[key] * col_count.get(key, 0)
        return res 
