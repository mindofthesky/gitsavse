class TrieNode:
    def __init__(self):
        self.children = {};
        
class Trie:
    def __init__(self):
        self.root = TrieNode();
        self.end = [];
    def insert(self, word):
        root = self.root;
        for c in word:
            if c not in root.children:
                root.children[c] = TrieNode();
            root = root.children[c];
        self.end.append((root,len(word)+1));
        
class Solution:
    def minimumLengthEncoding(self, words: List[str]) -> int:
        words = list(set(words));
        t = Trie();
        for w in words:
            t.insert(w[::-1]);
            
        return sum([depth for node, depth in t.end if len(node.children)  == 0]);
