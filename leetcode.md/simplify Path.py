class Solution: def simplifyPath(self, path: str) -> str: stack = ["/"] cur_str = ""

    for i in range(1, len(path)):
        if path[i] == "/" or i == len(path) - 1:
            if i == len(path) - 1 and path[i] != "/":
                    cur_str += path[i]
                    
            if len(cur_str) == 0 or cur_str == ".":
                cur_str = ""
                continue
                
            if cur_str != "..":
                
                stack.append(cur_str)
                if path[i] == "/":
                    stack.append(path[i])         
            else:
                if len(stack) > 1:
                    stack.pop()
                    stack.pop()
                
            cur_str = ""
            continue
        
        cur_str += path[i]
        
    if stack[len(stack) - 1] == "/" and len(stack) > 1:
        stack.pop()
        
    output = ""
    
    for char in stack:
        output += char
        
    return output
