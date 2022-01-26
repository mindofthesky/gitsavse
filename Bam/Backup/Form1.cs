using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bam
{
    public class Input : Button
    {
        public int num;      

        private void InitializeComponent()
        {

            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }

    public class Ouput : Button
    {
        public int num;
       
    }

    public partial class Form1:Form
    {
 
        Input[,] Input = new Input[5,5];
        Ouput[,] Output = new Ouput[3, 1];
      

        private int[,] s = new int[2, 25] {
                     {1,1,1,1,1, 1,-1,-1,-1,1, 1,-1,-1,-1,1, 1,-1,-1,-1,1, 1,1,1,1,1},
                     {-1,-1,-1,-1,1, -1,-1,-1,-1,1, -1,-1,-1,-1,1, -1,-1,-1,-1,1, -1,-1,-1,-1,1}
                     };

        private int[,] t = new int[2, 3]{
                                        {1, 1, -1},
                                        {-1, 1, 1}
                                        };

 
        
        private int[,] w = new int[25, 3];

        private int[] NET_y = new int[3];
        private int[] NET_x = new int[25];

        private int[] y = new int[3];
        private int[] x = new int[25];


        public Form1()
        {
            InitializeComponent();
            Paint_Set();  //디자인 폼         
            Patern_Stor();// 연결강도 구하기
           
        }

        public void Comput_Y(int t_num){

            int x, y, z=-1;



               for (z = 0; z < 3; z++){
                    for (x = 0; x < 25; x++)
                    {
                        NET_y[z] += this.x[x] * w[x, z];
                    }
                }


               for (x = 0; x < 3; x++)
               {
                   if (NET_y[x] > 0) this.y[x] = 1;                 
                   else if (NET_y[x] == 0) this.y[x] = this.y[x];
                   else this.y[x] = -1;
               }


                for (y = 0; y < 3; y++)
                {
                    if (this.y[y] == 1)
                    {
                        Output[y, 0].BackColor = Color.Black;
                    }
                    else
                    {
                        Output[y, 0].BackColor = Color.White;
                    }
                }
 

            //초기화
            for (z = 0; z < 3; z++)
            {
                NET_y[z] = 0;
            }

        }

        public void Comput_X(int s_num)
        {

            int x, y;
            int count = -1;       

                for (x = 0; x < 25; x++)
                {
                    for (y = 0; y < 3; y++)
                    {
                        NET_x[x] += this.y[y] * w[x, y];
                    }
                }          

            for (y = 0; y < 3; y++)
            {
                for (x = 0; x < 25; x++)
                {
                    if (NET_x[x] > 0) this.x[x] = 1;                  
                    else if (NET_x[x] == 0) this.x[x] = this.x[x];
                    else this.x[x] = -1;
                }
            }
         

            for (y = 0; y < 5; y++)
            {
                for (x = 0; x < 5; x++)
                {
                    count++;
                    if (this.x[count] == 1)
                    {
                        Input[x, y].BackColor = Color.Black;
                    }
                    else
                    {
                        Input[x, y].BackColor = Color.White;
                    }
                }
            }


                for (x = 0; x < 25; x++)
                {
                    NET_x[x] =0;
                }
            

        }     

        public void Patern_Stor() // 연결강도 구하기
        {
            int count = 0;

            this.richTextBox1.AppendText("======= X 저장 패턴=========\n");
            
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 25; x++)
                {
                    count++;
                    this.richTextBox1.AppendText(string.Format("{0,5}", s[y, x] + " "));
                    if (count % 5 == 0) this.richTextBox1.AppendText("\n");
                }

                this.richTextBox1.AppendText("\n");
                this.richTextBox1.AppendText("\n");
            }

                this.richTextBox1.AppendText("======= Y 저장 패턴=========\n");
                for (int y = 0; y < 2; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        this.richTextBox1.AppendText(t[y, x] + " ");
                    }

                    this.richTextBox1.AppendText("\n");
                    this.richTextBox1.AppendText("\n");
                }


            this.richTextBox1.AppendText("======= 연결강도=========\n");
            for (int z = 0; z < 2; z++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 25; x++)
                    {
                        w[x, y] += s[z, x] * t[z, y];
                    }
                }
            }


            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 25; x++)
                {
                    this.richTextBox1.AppendText(w[x, y] + " ");
                }
                this.richTextBox1.AppendText("\n");
            }

        }

        public void Paint_Set() //디자인 폼
        {
            int count = 0;


            // X_bt 패턴인식 폼
            Button X_bt = new Button();

            X_bt.Width = 120;
            X_bt.Height = 45;
            X_bt.Top = 90;
            X_bt.Left = 330;
            this.Controls.Add(X_bt);
            X_bt.Click += new EventHandler(this.Ypatter_Click);
            X_bt.Text = "X축 패턴인식 ->";

            // Y_`bt 패턴인식 폼
            Button Y_bt = new Button();
            Y_bt.Width = 120;
            Y_bt.Height = 45;
            Y_bt.Top = 140;
            Y_bt.Left = 330;
            this.Controls.Add(Y_bt);
            Y_bt.Text = "<- Y축 패턴인식";
            Y_bt.Click += new EventHandler(this.Xpatter_Click);


            // 초기화 폼
            Button Init_bt = new Button();
            Init_bt.Width = 120;
            Init_bt.Height = 45;
            Init_bt.Top = 190;
            Init_bt.Left = 330;
            this.Controls.Add(Init_bt);
            Init_bt.Text = "초기화";
            Init_bt.Click += new EventHandler(this.Init_bt_Click);


            //Input

            for (int y = 0; y < 5; y++)
                for (int x = 0; x < 5; x++)
                {
                    Input[y, x] = new Input();
                }

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Input[y, x].Width = 40;
                    Input[y, x].Height = 40;
                    Input[y, x].Top = x * 40 + 30;
                    Input[y, x].Left = y * 40 + 30;

                    Input[y, x].BackColor = Color.White;
                    this.Controls.Add(Input[y, x]);
                    Input[y, x].Click += new EventHandler(this.Input_Click);
                }
            }



            // Output
            
            for (int y = 0; y < 3; y++)
                for (int x = 0; x < 1; x++)
                {
                    Output[y, x] = new Ouput();
                }

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 1; x++)
                {
                    Output[y, x].Width = 40;
                    Output[y, x].Height = 40;
                    Output[y, x].Top = x * 40 + 120;
                    Output[y, x].Left = y * 40 + 500;
                    Output[y, x].Click += new EventHandler(this.Output_Click);

                    Output[y, x].BackColor = Color.White;
                    this.Controls.Add(Output[y, x]);
                }
            }

           
        }

        public void Xpatter_Click(object sender, EventArgs e)
        {
            int x, y;
            int count = -1;
            int s_num = 0;
            int check_num = 0;
            bool check = false;

            //검증
            while (check != true)
            {
                Comput_X(s_num);
                Comput_Y(s_num);


                if (s_num > 1)
                {
                    break;
                }

                for (x = 0; x < 2; x++)
                {
                    count++;
                    if (this.y[count] == t[s_num, count]) check_num++;
                    else continue;
                }

                if (check_num == 2) check = true;

                count = -1;
                check_num = 0;
                s_num++;
            }


        } // x-> y

        public void Ypatter_Click(object sender, EventArgs e)
        {
            int x, y;
            int count = -1;
            int s_num = 0;
            int check_num = 0;
            bool check = false;


            //검증
            while (check != true)
            {
                Comput_Y(s_num);
                Comput_X(s_num);

                if (s_num > 1)
                {
                    break;
                }

                for (y = 0; y < 5; y++)
                {
                    for (x = 0; x < 5; x++)
                    {
                        count++;
                       // MessageBox.Show(count + "" + s_num);
                        if (this.x[count] == s[s_num, count]) check_num++;
                        else continue;
                    }
                }

                if (check_num == 25) check = true;
                count = -1;
                check_num = 0;
                s_num++;
            }
        } // y->x

        public void Output_Click(object sender, EventArgs e) //y축 입력
        {
            Ouput Out = (Ouput)sender;

            if (Out.BackColor == Color.Black)
            {
                Out.BackColor = Color.White;
               // Out.num = -1;
            }
            else
            {
                Out.BackColor = Color.Black;
                //Out.num = 1;
            }



            for (int y = 0; y < 1; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (Output[x, y].BackColor == Color.Black) this.y[x] = 1;
                    else this.y[x] = -1;
                }
            }

        } 

        public void Input_Click(object sender, EventArgs e) //x축 입력
        {
            Input BP = (Input)sender;

            if (BP.BackColor == Color.Black){
                BP.BackColor = Color.White;
 
            }
            else{
                BP.BackColor = Color.Black;
              
            }

            int x, y;
            int count = -1;
            for (y = 0; y < 5; y++)
            {
                for (x = 0; x < 5; x++)
                {
                    ++count;
                    if (Input[x, y].BackColor == Color.Black) this.x[count] = 1;
                    else this.x[count] = -1;
                }
            }
        }

        public void Init_bt_Click(object sender, EventArgs e)
        {

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Input[y, x].BackColor = Color.White;
                    Input[y, x].num = -1;
                }
            }


            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 1; x++)
                {
                    Output[y, x].BackColor = Color.White;
                    Output[y, x].num = -1;
                }
            }

        } //초기화


    }
}
