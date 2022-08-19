class Solution:
    def ladderLength(self, beginWord: str, endWord: str, wordList: List[str]) -> int:
        
        alpha= "abcdefghijklmnopqrstuvwxyz";
        wordset = set(wordList + [beginWord]);
        
        graph = defaultdict(set);
        for s in wordList + [beginWord]:
            for i in range(len(s)):
                p1, p2 = s[0:i], s[i+1:];
                for a in alpha:
                    tmp = p1 + a + p2;
                    if tmp in wordset and tmp != s:
                        graph[s].add(tmp);
        q = deque([(beginWord,0)]);
        visited = set();
        
        while q:
            node, step = q.popleft();
            if node == endWord: return step + 1;
            if node not in visited:
                visited.add(node);
                for nx in graph[node]:
                    if nx not in visited: q.append((nx, step + 1));
        return 0;
