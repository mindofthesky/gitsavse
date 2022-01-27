class Solution:
    def isNumber(self, s: str) -> bool:
        digit, dec, e, sb = False,False,False,False;
        
        for c in s:
            if c in '0123456789':
                digit = True;
            elif c in '+-':
                if sb or digit or dec:
                    return False;
                else:
                    sb = True;
            elif c in "Ee":
                if not digit or e : return False;
                else:
                    e = True;
                    sb = False;
                    digit = False;
                    dec =False;
            elif c == '.':
                if dec or e: return False;
                else:
                    dec = True;
            else:
                return False;
        
        return digit;
                
