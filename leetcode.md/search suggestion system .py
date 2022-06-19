class Solution:
    def suggestedProducts(self, products: List[str], searchWord: str) -> List[List[str]]:
        answer = [[] for i in range(len(searchWord))]
        flag = False;
        products = sorted(products)
        for i in products:
            if (i[0]==searchWord[0]):
                flag = True
                for j in range(1,len(searchWord)+1):
                    if (i[0:j]==searchWord[0:j]):
                        if(len(answer[j-1])<3):
                            answer[j-1].append(i)
                        else:
                            continue
                    else:
                        break
            elif(flag):
                  break
        return answer
