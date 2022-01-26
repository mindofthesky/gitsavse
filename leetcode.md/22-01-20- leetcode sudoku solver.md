class Solution:

    def solveSudoku(self, board: List[List[str]]) -> None:
        """
        Do not return anything, modify board in-place instead.
        """
        rows,cols,block,seen = defaultdict(set),defaultdict(set),defaultdict(set),deque([])
        for i in range(9):
            for j in range(9):
                if board[i][j]!=".":
                    rows[i].add(board[i][j])
                    cols[j].add(board[i][j])
                    block[(i//3,j//3)].add(board[i][j])
                else:
                    seen.append((i,j))
                    
        def dfs():
            if not seen:
                return True
        
            r,c = seen[0]
            t = (r//3,c//3)
            for n in {'1','2','3','4','5','6','7','8','9'}:
                if n not in rows[r] and n not in cols[c] and n not in block[t]:
                    board[r][c]=n
                    rows[r].add(n)
                    cols[c].add(n)
                    block[t].add(n)
                    seen.popleft()
                    if dfs():
                        return True
                    else:
                        board[r][c]="."
                        rows[r].discard(n)
                        cols[c].discard(n)
                        block[t].discard(n)
                        seen.appendleft((r,c))
            return False
    
        dfs()
        
        왜 깊이 우선 탐색 알고리즘을 사용했는지 이해 안가는 문제중 하나 
