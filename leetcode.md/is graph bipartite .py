class Solution:
    def isBipartite(self, graph: List[List[int]]) -> bool:
        visited = set()
        two_color = [set(), set()]
        for i in range(len(graph)):
            if i not in visited:
                
                queue = [(i, 0)]
                while queue:
                    node, level = queue.pop()
                    visited.add(node)
                    two_color[level].add(node)
                
                    for neighbor in graph[node]:
                        if neighbor in two_color[level]:
                            return False
                        if neighbor not in visited:
                            queue.append((neighbor, 1 if level == 0 else 0))
                    
        return True
