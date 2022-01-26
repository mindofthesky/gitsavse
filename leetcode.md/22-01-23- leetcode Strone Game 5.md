class Solution:
    def winnerSquareGame(self, n: int) -> bool:
        winner = [False];
        
        for i in range(1 , n + 1):
            j = 1;
            winner.append(False);
            while(stone := j * j) <= i:
                if not winner[i - stone]:
                    winner[i] = True;
                    break;
                j += 1;
        
        return winner[n];
