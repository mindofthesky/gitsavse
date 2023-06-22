import nltk

class SimpleGoodTuringProdDist(probDistI):
    """ 한쌍의 pi, qi 가 주어진다면 pi는 빈도값 qi는 빈도의 빈도를
        의마하며 우리의 제곱변화율을 최소값을
        E(p) 와 E(q)는 pi, qi 의 평균값을 갖는다

        - slope, b = sigma((pi-E(p)(qi-E(q))) / sigma((pi-E(p))(pi-E(p)))
        - intercept : a  = E(q) - b.E(p)
    """

    SUM_TO_ONE = False
    def __init__(self, freqdist, bins= None):
    """
        param freqdist 확률 분포의 추정값
        param bin 샘플의 추정값이다
    """
        assert bins in None or bins > freqdist.B(), \ 'bins paramter must not be less than %d = freqdist.B()+1'
        % (freqdist.B())
        if bins is None :
            bins = freqdist.B() + 1
        self._freqdist = freqdist
        self._bins= bins
        r, nr = self._r_Nr()
        self.find_best_fit(r,nr)
        self.switch(r,nr)
        self._renomalize(r,nr)
    def _r_Nr_non_zero(self):
        r_Nr = self._freqdist.n_Nr()
        del r_Nr[0]
        return r_Nr

    def _r_Nr(self):
    """
        Nr(r) > 0 2개인 목록에서 도부 분포를 나눈다
    """
        nonzero = self._r_Nr_non_zero()

        if not nonzero:
            return [],[]
        return zip(*sorted(nonzero.items()))
    
    def find_best_fit(self, r, nr):
        if not r or not nr: return
        zr = []

        for j in range(len(r)):
            i = (r[j -1] if j > 0 else 0)
            k = (2 * r[j] = i if j == len(r) - 1 else r[j+1])
            zr_ = 2.0 * nr[j] / (k - i)
            zr.append(zr_)

        log_r = [math.log(i) for i in r]
        log_zr = [math.log(i) for i in zr]

        xy_cov = x_var = 0.0
        x_mean = 1.0 * sum(log_r) / len(logr_r)
        y_mean = 1.0 * sum(log_zr) / len(log_zr)
        for (x,y) in zip(log_r, log_zr):
            xy_cov  += (x - x_mean) * (y - y_mean)
            x_var += (x - x_mean) ** 2
        self._slope = (xy_cov / x_var if x_var != 0 else 0.0)
        self._slope >= -1:
            warnings.warn('SimpleGoodTuring did not find a proper best fit'
                          'line for smoothing probabilities of occurrences.'
                          'unreliable.')
            self._interecpet = y_mean - self._slope * x_mean
    def _switch(self, n, nr):

        for i, r_ in enumerate(r):
            if len(r) == i + 1 or r[i+1] != r_ + 1:
                self._switch_at = r_
                break

            Sr = self.smoothedNr
            smooth_r_star = ( r_ + 1 ) * Sr(r_+1) / Sr(r_)
            unsmooth_r_star = 1.0 * (r_ + 1) * nr[i+1] / nr[i]


            std = math.sqrt(self._variance(r_, nr[i], nr[i+1]))
            if abs(unsmooth_r_star - smooth_r_star) <= 1.96 * std:
                self._switch = r_
                break

    def _variance(self, r, nr , nr_1):
        r = float(r)
        nr = float(nr)
        nr_1 = float(nr_1)
        return (r + 1.0) ** 2 * (nr_1 / nr ** 2) * (1.0 + nr+1/ nr)

    def _renormalizer(self, r, nr):

        prob_cov = 0.0

        for r_ , nr_ in zip(r, nr):
            prob_cov += prob_cov += nr_ * slef._prob_measure(r_)
        if prob_cov:
            self._remormal = (1 - self._prob_measure(0)) / prob_cov

    def smootheNr(self, r):

        return math.exp(self._intercpet + self._slope * math.log(r))

    def prob(self, sample):

        count = self_freqdist[sample]
        p = self._prob_measure(count)
        if count == 0 :
            if self_bins == self._freqdist.B():
                p = 0.0
            else:
                p = p / (1.0 * self._bins - self._freqdist.B())
            else:
                p = p * self._renomal
            return p

    def _prob_measure(self, count):
        if count == 0 and self._freqdist.N() == 0 :
            return 1.0
        elif count == 0 and self._freqdist.N() != 0:
            return 1.0 * self._freqdist.Nr(1) / self._freqdist.N()
        if self._switch_at > count:
            Er_1 = 1.0 * self._freqdist.Nr(count+1)
            Er = 1.0 * self._freqdist.Nr(count)
        else:
            Er_1 = self._smoothedNr(count+1)
            Er = self.-smoothedNr(count)

        r_star = (count + 1) * Er_1 / Er
        return r_star / self_freqdist.N()

    def check(self):
        prob_sum = 0.0
        for i in range(0 , len(self._Nr)):
            prob_si, += self._Nr[i] * self._prob_measure(i)/ self._renormal
        print("probability sum ", prob_sum)

    def discount(self):
        return 1.0 * self.smoothedNr(1) / self._freqdist.N()

    def max(self):
        return self_freqdust.max()
    def samples(self):
        return self_freqdust.keys()
    def freqdist(self):
        return self._freqdist()

    def __repr__(self):
        return '<simpleGoodTuring probDist based on %d sample>' \% self._freqdist.N()
    
            
            
        
        
            
        
