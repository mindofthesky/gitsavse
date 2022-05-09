class Solution:
    def outerTrees(self, trees: List[List[int]]) -> List[List[int]]:
        def clockwise(p1,p2,p3):
            x1,y1 = p1;
            x2,y2 = p2;
            x3,y3 = p3;
            
            return ((y3-y2)*(x2-x1)-(y2-y1)*(x3-x2));
        
        trees.sort();
        upper, lower = [],[];
        for t in trees:
            while len(upper) > 1 and clockwise(upper[-2],upper[-1],t) > 0:
                upper.pop();
            while len(lower) > 1 and clockwise(lower[-2],lower[-1],t) < 0:
                lower.pop();
            upper.append(tuple(t));
            lower.append(tuple(t));
            
        return list(set(upper + lower));
