class Solution:
    def numUniqueEmails(self, emails: List[str]) -> int:
        lookup = set();
        for e in emails:
            local, domain = e.split('@');
            tmp = [];
            for c in local:
                if c=='.': continue;
                if c=='+': break;
                tmp.append(c);
            lookup.add("".join(tmp)+'@'+domain);
            
        return len(lookup);
