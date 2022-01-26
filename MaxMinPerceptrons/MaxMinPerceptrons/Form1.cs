using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaxMinPerceptrons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[,] w = new double[3, 48];
        double[,] dweight = new double[3, 48];
        double[,] old_weight = new double[3, 48];
        double[] min = new double[48];
        double[] max = new double[3];
        double[] bias = new double[3];
        double[] dbias = new double[3];
        double[] old_dbias = new double[3];
        double[] layer = new double[3];
        double Lrate1 = 0.5, Lrate2 = 0.4;
        double Momentum1 = 0.3, Momentum2 = 0.2;
        double Ecrit = 0.001;
        int nepoch;
        double pss, tss;
        StringBuilder a = new StringBuilder();

        static double[,] pattern = new double[5, 42]
        {
                                        {1.0,1.0,1.0,1.0,1.0,1.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,                                        
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         0.0,1.0,1.0,1.0,0.0,0.0,
                                         1.0,1.0,1.0,1.0,1.0,1.0},

                                        {1.0,1.0,1.0,1.0,1.0,0.0,                                        
                                         1.0,0.0,0.0,0.0,0.0,1.0,
                                         1.0,0.0,0.0,0.0,0.0,1.0,
                                         1.0,1.0,1.0,1.0,1.0,0.0,
                                         1.0,0.0,0.0,0.0,0.0,0.0,
                                         1.0,0.0,0.0,0.0,0.0,0.0,
                                         1.0,1.0,0.0,0.0,0.0,0.0},

                                        {0.0,0.0,1.0,1.0,0.0,0.0,                                     
                                         0.0,1.0,0.0,0.0,0.0,1.0,
                                         0.0,1.0,1.0,1.0,1.0,1.0,
                                         0.0,0.0,0.0,0.0,0.0,1.0,
                                         0.0,1.0,0.0,0.0,1.0,0.0,
                                         0.0,1.0,0.0,0.0,1.0,1.0,
                                         0.0,1.0,1.0,1.0,1.0,1.0},

                                        {1.0,0.0,0.0,0.0,0.0,1.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,1.0,0.0,0.0,
                                         0.0,0.0,0.0,0.0,0.0,0.0},

                                        {0.0,1.0,1.0,1.0,1.0,1.0,
                                         0.0,0.0,0.0,0.0,0.0,1.0,                                       
                                         0.0,0.0,0.0,1.0,0.0,0.0,
                                         0.0,0.0,1.0,0.0,0.0,0.0,
                                         0.0,1.0,0.0,0.0,0.0,0.0,
                                         1.0,1.0,1.0,1.0,1.0,0.0,
                                         0.0,0.0,0.0,0.0,0.0,0.0}
        };

        double[,] target = new double[4, 3]
        {
                                              { 0.0, 1.0, 0.0 },
                                              { 0.0, 0.0, 1.0 },
                                              { 1.0, 1.0, 0.0 },
                                              { 0.0, 1.0, 1.0 }

         };




        

        public void Initialize_weight()
        {
            int i, j;
            Random r = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 48; j++)
                {
                    w[i, j] = ((double)(r.Next(10000)) / 10000.0 / 2) + 0.5;
                    // 연산값  
                }
                bias[i] = ((double)(r.Next(10000)) / 10000.0 / 2) + 0.5; // 바이어스 가중치 
            }
        }

        public void activate(int index)
        {
            int i, j;
            double wdiff, bdiff;
            for (i = 0; i < 3; i++)
            {
                max[i] = 0.0;
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 42; j++)
                {
                    if (pattern[index, j] > w[i, j]) min[j] = w[i, j];
                    else min[j] = pattern[index, j];
                    if (max[i] < min[j]) max[i] = min[j];
                }
                layer[i] = (max[i] > bias[i]) ? max[i] : bias[i]; //output node
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 48; j++)
                {
                    wdiff = (layer[i] == w[i, j]) ? 1.0 : 0.0;
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
            for (i = 0; i < 3; i++)
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
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 42; j++)
                {
                    w[i, j] += Lrate1 * dweight[i, j] + Momentum1 * old_weight[i, j];
                    if (w[i, j] < 0.0) w[i, j] = 0.0;
                    if (w[i, j] >= 1.0) w[i, j] = 1.0;
                    old_weight[i, j] = dweight[i, j];
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
            a.AppendLine();
            a.AppendLine("Recognition result");
            for (i = 0; i < 3; i++)
            {
                activate(i);
                for (j = 0; j < 3; j++)
                {
                    a.AppendLine("Target[" + i + "][" + j + "]= " + target[i, j] + ", computed[" + j + "]= " + layer[j]);
                    if (((target[i, j] - layer[j]) > 0.5) || ((target[i, j] - layer[j]) < -0.5)) a.Append("");
                    //sb.AppendLine("***");
                }
            }
        }

        public String run()
        {
            int i;
            Initialize_weight();

            nepoch = 0;

            do
            {
                nepoch++;
                tss = 0.0;
                for (i = 0; i < 3; i++)
                {
                    activate(i);
                    compute_pss(i);
                    tss += pss;
                }
                change_weight();
                a.AppendLine("[" + nepoch + "] : TSS = " + tss + "\n");
            } while (tss > Ecrit);

            Recognition();
            return a.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            txtResult.Text = run().ToString();
            //lblResult.Text = result;
        }
    }
}
