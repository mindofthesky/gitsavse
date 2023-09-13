namespace restartcal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtExp = new TextBox();
            txtResult = new TextBox();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_0 = new Button();
            btn_pluma = new Button();
            btn_dot = new Button();
            btn_div = new Button();
            btn_mul = new Button();
            btn_min = new Button();
            btn_sum = new Button();
            btn_result = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnDelete = new Button();
            button4 = new Button();
            btnSqrt = new Button();
            btnsqr = new Button();
            btnRecip = new Button();
            btnMC = new Button();
            btnMR = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // txtExp
            // 
            txtExp.Location = new Point(12, 12);
            txtExp.Name = "txtExp";
            txtExp.ReadOnly = true;
            txtExp.Size = new Size(326, 23);
            txtExp.TabIndex = 0;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 41);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Horizontal;
            txtResult.Size = new Size(326, 51);
            txtResult.TabIndex = 1;
            txtResult.KeyPress += EnterPress;
            // 
            // btn_1
            // 
            btn_1.FlatStyle = FlatStyle.Flat;
            btn_1.Location = new Point(12, 428);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(75, 71);
            btn_1.TabIndex = 10;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_Allnumber_Click;
            // 
            // btn_2
            // 
            btn_2.FlatStyle = FlatStyle.Flat;
            btn_2.Location = new Point(93, 428);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(75, 71);
            btn_2.TabIndex = 10;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_Allnumber_Click;
            // 
            // btn_3
            // 
            btn_3.FlatStyle = FlatStyle.Flat;
            btn_3.Location = new Point(174, 428);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(75, 71);
            btn_3.TabIndex = 10;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_Allnumber_Click;
            // 
            // btn_4
            // 
            btn_4.FlatStyle = FlatStyle.Flat;
            btn_4.Location = new Point(12, 351);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(75, 71);
            btn_4.TabIndex = 10;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_Allnumber_Click;
            // 
            // btn_5
            // 
            btn_5.FlatStyle = FlatStyle.Flat;
            btn_5.Location = new Point(93, 351);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(75, 71);
            btn_5.TabIndex = 10;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_Allnumber_Click;
            // 
            // btn_6
            // 
            btn_6.FlatStyle = FlatStyle.Flat;
            btn_6.Location = new Point(174, 351);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(75, 71);
            btn_6.TabIndex = 10;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_Allnumber_Click;
            // 
            // btn_7
            // 
            btn_7.FlatStyle = FlatStyle.Flat;
            btn_7.Location = new Point(12, 274);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(75, 71);
            btn_7.TabIndex = 10;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_Allnumber_Click;
            // 
            // btn_8
            // 
            btn_8.FlatStyle = FlatStyle.Flat;
            btn_8.Location = new Point(93, 274);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(75, 71);
            btn_8.TabIndex = 10;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_Allnumber_Click;
            // 
            // btn_9
            // 
            btn_9.FlatStyle = FlatStyle.Flat;
            btn_9.Location = new Point(174, 274);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(75, 71);
            btn_9.TabIndex = 10;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_Allnumber_Click;
            // 
            // btn_0
            // 
            btn_0.FlatStyle = FlatStyle.Flat;
            btn_0.Location = new Point(93, 505);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(75, 77);
            btn_0.TabIndex = 10;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_Allnumber_Click;
            // 
            // btn_pluma
            // 
            btn_pluma.FlatStyle = FlatStyle.Flat;
            btn_pluma.Location = new Point(12, 505);
            btn_pluma.Name = "btn_pluma";
            btn_pluma.Size = new Size(75, 77);
            btn_pluma.TabIndex = 10;
            btn_pluma.Text = "±";
            btn_pluma.UseVisualStyleBackColor = true;
            btn_pluma.Click += btn_pluma_Click;
            // 
            // btn_dot
            // 
            btn_dot.FlatStyle = FlatStyle.Flat;
            btn_dot.Location = new Point(174, 505);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(75, 77);
            btn_dot.TabIndex = 10;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_div
            // 
            btn_div.FlatStyle = FlatStyle.Flat;
            btn_div.Location = new Point(255, 198);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(75, 70);
            btn_div.TabIndex = 14;
            btn_div.Text = "÷";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn_mul
            // 
            btn_mul.FlatStyle = FlatStyle.Flat;
            btn_mul.Location = new Point(255, 274);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(75, 70);
            btn_mul.TabIndex = 15;
            btn_mul.Text = "×";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += btn_mul_Click;
            // 
            // btn_min
            // 
            btn_min.FlatStyle = FlatStyle.Flat;
            btn_min.Location = new Point(255, 352);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(75, 70);
            btn_min.TabIndex = 16;
            btn_min.Text = "-";
            btn_min.UseVisualStyleBackColor = true;
            btn_min.Click += btn_min_Click;
            // 
            // btn_sum
            // 
            btn_sum.FlatStyle = FlatStyle.Flat;
            btn_sum.Location = new Point(255, 427);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(75, 72);
            btn_sum.TabIndex = 17;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // btn_result
            // 
            btn_result.FlatStyle = FlatStyle.Flat;
            btn_result.Location = new Point(255, 505);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(75, 77);
            btn_result.TabIndex = 18;
            btn_result.Text = "=";
            btn_result.UseVisualStyleBackColor = true;
            btn_result.Click += btn_result_Click;
            // 
            // btnCE
            // 
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Location = new Point(12, 198);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(75, 70);
            btnCE.TabIndex = 19;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Location = new Point(93, 198);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 70);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(174, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 70);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "<X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(12, 145);
            button4.Name = "button4";
            button4.Size = new Size(75, 47);
            button4.TabIndex = 22;
            button4.Text = "%";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Location = new Point(93, 147);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(75, 45);
            btnSqrt.TabIndex = 23;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnsqr
            // 
            btnsqr.FlatStyle = FlatStyle.Flat;
            btnsqr.Location = new Point(174, 147);
            btnsqr.Name = "btnsqr";
            btnsqr.Size = new Size(75, 45);
            btnsqr.TabIndex = 24;
            btnsqr.Text = "x^2";
            btnsqr.UseVisualStyleBackColor = true;
            btnsqr.Click += btnsqr_Click;
            // 
            // btnRecip
            // 
            btnRecip.FlatStyle = FlatStyle.Flat;
            btnRecip.Location = new Point(255, 147);
            btnRecip.Name = "btnRecip";
            btnRecip.Size = new Size(75, 45);
            btnRecip.TabIndex = 25;
            btnRecip.Text = "1/x";
            btnRecip.UseVisualStyleBackColor = true;
            btnRecip.Click += btnRecip_Click;
            // 
            // btnMC
            // 
            btnMC.FlatStyle = FlatStyle.Flat;
            btnMC.Location = new Point(12, 117);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(55, 24);
            btnMC.TabIndex = 26;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.FlatStyle = FlatStyle.Flat;
            btnMR.Location = new Point(73, 117);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(54, 24);
            btnMR.TabIndex = 27;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += btnMR_Click;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(133, 117);
            button10.Name = "button10";
            button10.Size = new Size(59, 24);
            button10.TabIndex = 28;
            button10.Text = "M+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(198, 117);
            button11.Name = "button11";
            button11.Size = new Size(58, 24);
            button11.TabIndex = 29;
            button11.Text = "M-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(262, 117);
            button12.Name = "button12";
            button12.Size = new Size(68, 24);
            button12.TabIndex = 30;
            button12.Text = "MS";
            button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 588);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnRecip);
            Controls.Add(btnsqr);
            Controls.Add(btnSqrt);
            Controls.Add(button4);
            Controls.Add(btnDelete);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btn_result);
            Controls.Add(btn_sum);
            Controls.Add(btn_min);
            Controls.Add(btn_mul);
            Controls.Add(btn_div);
            Controls.Add(btn_dot);
            Controls.Add(btn_pluma);
            Controls.Add(btn_0);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(txtResult);
            Controls.Add(txtExp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExp;
        private TextBox txtResult;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_0;
        private Button btn_pluma;
        private Button btn_dot;
        private Button btn_div;
        private Button btn_mul;
        private Button btn_min;
        private Button btn_sum;
        private Button btn_result;
        private Button btnCE;
        private Button btnC;
        private Button btnDelete;
        private Button button4;
        private Button btnSqrt;
        private Button btnsqr;
        private Button btnRecip;
        private Button btnMC;
        private Button btnMR;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}