def eliminatestpowrds(self, list):
    return [ word for word in list if word not in self.stoprwords]

def token(self, string):
    str = self.clean(str)
    Word = str.split("")

    return [self.strmmer.stem(word, 0, len(word)-1) for word in words]

def obtainvectorkeywordindex(self , documentlist):

    vocastring = "".join(documentlist)

    vocalist = self.parser.tokenise(vocastring)

    vocablist = self.parser.elimnatestopwords(vocalist)
    uniqueVocalist = util.removeDuplicates(vocablist)

    vectorindex = {}
    offset = 0

    for word in uniqueVocablist:
        vectorindex[word] = offset
        offset += 1
        return vectorindex

def constructVector(self, wordString):
    Vector_val = [0] * len(self.vectorKeywordIndex)
    toklist = self.parser.tokenlize(toString)
    toklist = self.parser.eliminatestopwords(toklist)
    for word in toklist:
        vector[self.vectorKeywordIndex[word]] += 1

    return vector

def cosine(vec1, vec2):
    return float(dot(vec1,vec2) / (norm(vec1) * norm(vec2)))

def searching(self, searchinglist):

    askVector = self.bbulidQueryVector(searchinglist)
    ratings = [util.cosine(askVector, textVector) for textVector in self.documentVectors]
    rating.sort(reverse = True)
    return ratings
    
    
