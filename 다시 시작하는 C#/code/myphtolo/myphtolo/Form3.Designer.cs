namespace myphtolo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hasbtn = new Button();
            marblebtn = new Button();
            oselotbtn = new Button();
            mypagebtn = new Button();
            logoutbtn = new Button();
            SuspendLayout();
            // 
            // hasbtn
            // 
            hasbtn.Location = new Point(99, 157);
            hasbtn.Name = "hasbtn";
            hasbtn.Size = new Size(174, 23);
            hasbtn.TabIndex = 0;
            hasbtn.Text = "던전앤파이터TCG";
            hasbtn.UseVisualStyleBackColor = true;
            hasbtn.Click += hasbtn_Click;
            // 
            // marblebtn
            // 
            marblebtn.Location = new Point(99, 206);
            marblebtn.Name = "marblebtn";
            marblebtn.Size = new Size(174, 23);
            marblebtn.TabIndex = 1;
            marblebtn.Text = "모두의마블";
            marblebtn.UseVisualStyleBackColor = true;
            // 
            // oselotbtn
            // 
            oselotbtn.Location = new Point(99, 260);
            oselotbtn.Name = "oselotbtn";
            oselotbtn.Size = new Size(174, 23);
            oselotbtn.TabIndex = 2;
            oselotbtn.Text = "오셀로";
            oselotbtn.UseVisualStyleBackColor = true;
            oselotbtn.Click += oselotbtn_Click;
            // 
            // mypagebtn
            // 
            mypagebtn.Location = new Point(99, 434);
            mypagebtn.Name = "mypagebtn";
            mypagebtn.Size = new Size(75, 23);
            mypagebtn.TabIndex = 3;
            mypagebtn.Text = "마이페이지";
            mypagebtn.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            logoutbtn.Location = new Point(198, 434);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(75, 23);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "로그아웃";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 542);
            Controls.Add(logoutbtn);
            Controls.Add(mypagebtn);
            Controls.Add(oselotbtn);
            Controls.Add(marblebtn);
            Controls.Add(hasbtn);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button hasbtn;
        private Button marblebtn;
        private Button oselotbtn;
        private Button mypagebtn;
        private Button logoutbtn;
    }
}