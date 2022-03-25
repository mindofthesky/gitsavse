class Solution:
    def calculate(self, s: str) -> int:
        out, cur, sign , stack = 0, 0 , 1 , [];
        
        for c in s :
            if c.isdigit():
                cur = cur * 10 + int(c);
            elif c in "+-":
                out += (cur  * sign);
                cur = 0;
                if c == "-":
                    sign  = -1;
                else:
                    sign = 1;
            
            elif c == "(":
                stack.append(out);
                stack.append(sign);
                out = 0;
                sign = 1;
            elif c == ")":
                out += (cur * sign);
                out *= stack.pop();
                out += stack.pop();
                cur = 0;
        return out + (cur * sign);
