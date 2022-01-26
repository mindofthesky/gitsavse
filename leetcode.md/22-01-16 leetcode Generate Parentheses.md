
class Solution:

    def generateParenthesis(self, n: int) -> List[str]:
        stack = [];
        res = [];
        
        def backtra(OpenNode, closeNode):
            if OpenNode == closeNode == n:
                res.append("".join(stack));
                return;
            if OpenNode < n:
                stack.append("(");
                backtra(OpenNode + 1, closeNode);
                stack.pop();
            
            if closeNode < OpenNode:
                stack.append(")");
                backtra(OpenNode, closeNode + 1);
                stack.pop();
            
        backtra(0, 0);
        return res;
