class Solution:
    def isValidSerialization(self, preorder: str) -> bool:
        stack = [];

        for n in preorder.split(","):
            stack.append(n);
            while len(stack) > 2 and stack[-2:] == ["#"] * 2 and stack[-3]!= "#":
                stack.pop();
                stack.pop();
                stack.pop();
                stack.append("#");
        return stack == ["#"];
