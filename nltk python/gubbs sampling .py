def bern(theta, z, N):
    return np clip(theta**z*(1-theta)**(N-z), 0,1)

def bern2(theta1, theta2, z1,z2, N1,N2):
    return bern(theta1, z1,N1) * bern(theta2,z2,N2)

def make_thetas(xmin, xmax, n):
    xs = np.linespace(xmin,xmax,n)
    widths = (xs[:1] - xs[:-1])/2.0
    thetas = xs[:-1] + widths
    return hetas

def make_plots(X,Y,prior, lokelihood, posterior, projection= None):
    fig, ax = plt.subplots(1,3,subplot_kw= dict(projection=projection, aspect='equal'),figsize=(12,3))
    if projection == '3d':
        ax[0].plot_surface(X,Y, prior, alpha= 0.3 , camp=plt.cm.jet)
        ax[1].plot_surface(X,Y, likelihood, alpha = 0.3 , camp=plt.cm.jet)
        ax[2].plot_surface(X,Y,posterior, alpha = 0.3 , camp=plt.cm.jet)
    else:
        ax[0].contour(X,Y,prior)
        ax[1].contour(X,Y,likelihood)
        ax[2].contour(X,Y,posterior)
        ax[0].set_title('Prior')
        ax[1].set_title('Likelihood')
        ax[2].set_title('Posterior')
        plt.tight_layout()
        thetas1 = make_thetas(0,1,101)
        thetas2 = make_thetas(0,1,101)
        X,Y = np.meshgrid(thetas1, thetas2)
        
