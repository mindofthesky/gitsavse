using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxMinPerceptrons
{
    class MaxMinClass
    {
        const int MAX_PATTERN = 5;
        const int DIM = 48;
        const int L_2_NODE = 48;
        const int L_3_NODE = 3;
        const int OUTPUT = L_3_NODE;
        const int INPUT = DIM;
        
        int N_PATTERN = MAX_PATTERN;
        int Max_Iteration = 1000;

        static double[,] pattern = new double[5, 48] {{1.0,1.0,1.0,1.0,1.0,1.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         1.0,1.0,1.0,1.0,1.0,1.0},
    
                                        {1.0,1.0,1.0,1.0,1.0,0.0,
                                         1.0,0.0,0.0,0.0,0.0,1.0,
                                         1.0,0.0,0.0,0.0,0.0,1.0,
                                         1.0,0.0,0.0,0.0,0.0,1.0,
                                         1.0,1.0,1.0,1.0,1.0,0.0,
                                         1.0,0.0,0.0,0.0,0.0,0.0,
                                         1.0,0.0,0.0,0.0,0.0,0.0,
                                         1.0,1.0,0.0,0.0,0.0,0.0},
    
                                        {0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,0.0,0.0,1.0,0.0,
                                         0.0,1.0,0.0,0.0,0.0,1.0,
                                         0.0,1.0,1.0,1.0,1.0,1.0,
                                         0.0,0.0,0.0,0.0,0.0,1.0,
                                         0.0,1.0,0.0,0.0,1.0,0.0,
                                         0.0,1.0,0.0,0.0,1.0,1.0,
                                         0.0,1.0,1.0,1.0,1.0,1.0},
                                         
                                        {1.0,0.0,0.0,0.0,0.0,1.0,
                                         1.0,1.0,1.0,1.0,1.0,1.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,0.0,0.0,0.0,0.0},
    
                                        {0.0,1.0,1.0,1.0,1.0,1.0,
                                         0.0,0.0,0.0,0.0,0.0,1.0,
                                         0.0,0.0,0.0,0.0,1.0,0.0,
                                         0.0,0.0,0.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,0.0,0.0,0.0,
                                         0.0,1.0,0.0,0.0,0.0,0.0,
                                         1.0,1.0,1.0,1.0,1.0,0.0,
                                         0.0,0.0,0.0,0.0,0.0,0.0}};

        double[,] target = new double[5, 3] { { 0.0, 1.0, 0.0 },
                                              { 0.0, 0.0, 1.0 },
                                              { 1.0, 0.0, 1.0 }, 
                                              { 0.0, 1.0, 1.0 }, 
                                              { 1.0, 1.0, 1.0 } };

        double[,] weight = new double[OUTPUT, INPUT];
        double[,] dweight = new double[OUTPUT, INPUT];
        double[,] old_dweight = new double[OUTPUT, INPUT];
        double[] min = new double[INPUT];
        double[] max = new double[OUTPUT];
        double[] bias = new double[OUTPUT];
        double[] dbias = new double[OUTPUT];
        double[] old_dbias = new double[OUTPUT];
        double[] layer = new double[OUTPUT];
        double Lrate1 = 0.5, Lrate2 = 0.4;
        double Momentum1 = 0.3, Momentum2 = 0.2;
        double Ecrit = 0.001;
        int nepoch;
        double pss, tss;
        StringBuilder sb = new StringBuilder();

        public void Initialize_weight()
        {
            int i, j;
            Random rr = new Random();
            for (i = 0; i < OUTPUT; i++)
            {
                for (j = 0; j < INPUT; j++)
                {
                    weight[i, j] = ((double)(rr.Next(10000)) / 10000.0 / 2) + 0.5;
                }
                bias[i] = ((double)(rr.Next(10000)) / 10000.0 / 2) + 0.5;
            }
        }

        public void activate(int index)
        {
            int i, j;
            double wdiff, bdiff;
            for (i = 0; i < OUTPUT; i++)
            {
                max[i] = 0.0;
            }
            for (i = 0; i < OUTPUT; i++)
            {
                for (j = 0; j < INPUT; j++)
                {
                    if (pattern[index, j] > weight[i, j]) min[j] = weight[i, j];
                    else min[j] = pattern[index, j];
                    if (max[i] < min[j]) max[i] = min[j];
                }
                layer[i] = (max[i] > bias[i]) ? max[i] : bias[i]; //output node
            }
            for (i = 0; i < OUTPUT; i++)
            {
                for (j = 0; j < INPUT; j++)
                {
                    wdiff = (layer[i] == weight[i, j]) ? 1.0 : 0.0;
                    dweight[i, j] += wdiff * (target[index, i] - layer[i]); //delta weight
                }
                bdiff = (layer[i] == bias[i]) ? 1.0 : 0.0;
                dbias[i] += bdiff * (target[index, i] - layer[i]);
            }
        }

        public void compute_pss(int index)
        {
            int i;
            double error;
            pss = 0.0;
            for (i = 0; i < OUTPUT; i++)
            {
                error = layer[i] - target[index, i];
                pss += error * error;
                Lrate1 = pss;
                Lrate2 = pss;
                Momentum1 = 1 - pss;
                Momentum2 = 1 - pss;
            }
        }

        public void change_weight()
        {
            int i, j;
            for (i = 0; i < OUTPUT; i++)
            {
                for (j = 0; j < INPUT; j++)
                {
                    weight[i, j] += Lrate1 * dweight[i, j] + Momentum1 * old_dweight[i, j];
                    if (weight[i, j] < 0.0) weight[i, j] = 0.0;
                    if (weight[i, j] >= 1.0) weight[i, j] = 1.0;
                    old_dweight[i, j] = dweight[i, j];
                    dweight[i, j] = 0.0;
                }
                bias[i] += Lrate2 * dbias[i] + Momentum2 * old_dbias[i];
                if (bias[i] < 0.0) bias[i] = 0.0;
                if (bias[i] >= 1.0) bias[i] = 1.0;
                old_dbias[i] = dbias[i];
                dbias[i] = 0.0;
            }
        }

        public void Recognition()
        {
            int i, j;
            sb.AppendLine();
            sb.AppendLine("Recognition result");
            for (i = 0; i < N_PATTERN; i++)
            {
                activate(i);
                for (j = 0; j < OUTPUT; j++)
                {
                    sb.AppendLine("Target[" + i + "][" + j + "]= " + target[i, j] + ", computed[" + j + "]= " + layer[j]);
                    if (((target[i, j] - layer[j]) > 0.5) || ((target[i, j] - layer[j]) < -0.5))
                        sb.AppendLine("***");
                }
            }
        }

        public String run()
        {
            int i;
            Initialize_weight();
            sb.AppendLine("Learning Process");
            nepoch = 0;

            do
            {
                nepoch++;
                tss = 0.0;
                for (i = 0; i < N_PATTERN; i++)
                {
                    activate(i);
                    compute_pss(i);
                    tss += pss;
                }
                change_weight();
                sb.AppendLine("[" + nepoch + "] : TSS = " + tss + "\n");
            } while (tss > Ecrit);

            Recognition();
            return sb.ToString();
        }
    }
}
