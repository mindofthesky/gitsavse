
import numpy as np
from keras.model import Model
from keras.layers import Dense, Input, Ladma


class Actor(object):
    def __init__(self, sess, state_dim, action_dim, action_bound, learning_rate) :
        self.sess = sess

        #값 초기화
        self.state_dim = state_dim
        self.action_dim = action_dim
        self.action_bound = action_bound
        self.learning_rate = learning_rate

        self.std_bound = [1e-2, 1.0]

        self.model, self.theta, self.states = self.build_network()
