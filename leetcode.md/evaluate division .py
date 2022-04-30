class Solution:
    def calcEquation(self, equations: List[List[str]], values: List[float], queries: List[List[str]]) -> List[float]:
        graph = defaultdict(dict);
        n = len(equations);
        for i in range(n):
            graph[equations[i][0]][equations[i][1]] = values[i];
            graph[equations[i][1]][equations[i][0]] = 1/values[i];
        
        def dfs(x,y ,visited):
            if x not in graph or y not in graph: return -1;
            
            if y in graph[x]:
                return graph[x][y];
            for i in graph[x]:
                if i not in visited:
                    visited.add(i);
                    temp = dfs(i,y,visited);
                    if temp == -1:
                        continue;
                    else:
                        return temp * graph[x][i];
            return -1;
        out = [];
        for p,q in queries:
            out.append(dfs(p,q,set()));
        
        return out;
            
