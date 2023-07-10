namespace myphtolo
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
            txtid = new TextBox();
            txtpass = new TextBox();
            laid = new Label();
            lapass = new Label();
            login = new Button();
            button2 = new Button();
            button3 = new Button();
            grlog = new GroupBox();
            newMember = new Button();
            grlog.SuspendLayout();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(73, 49);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(73, 93);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(100, 23);
            txtpass.TabIndex = 1;
            // 
            // laid
            // 
            laid.AutoSize = true;
            laid.Location = new Point(13, 52);
            laid.Name = "laid";
            laid.Size = new Size(43, 15);
            laid.TabIndex = 2;
            laid.Text = "아이디";
            // 
            // lapass
            // 
            lapass.AutoSize = true;
            lapass.Location = new Point(13, 101);
            lapass.Name = "lapass";
            lapass.Size = new Size(55, 15);
            lapass.TabIndex = 3;
            lapass.Text = "비밀번호";
            // 
            // login
            // 
            login.Location = new Point(184, 30);
            login.Name = "login";
            login.Size = new Size(75, 64);
            login.TabIndex = 4;
            login.Text = "로그인";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 153);
            button2.Name = "button2";
            button2.Size = new Size(83, 23);
            button2.TabIndex = 5;
            button2.Text = "아이디 찾기";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(101, 153);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 6;
            button3.Text = "비밀번호 찾기";
            button3.UseVisualStyleBackColor = true;
            // 
            // grlog
            // 
            grlog.Controls.Add(login);
            grlog.Location = new Point(12, 22);
            grlog.Name = "grlog";
            grlog.Size = new Size(265, 119);
            grlog.TabIndex = 7;
            grlog.TabStop = false;
            grlog.Text = "로그인";
            // 
            // newMember
            // 
            newMember.Location = new Point(198, 153);
            newMember.Name = "newMember";
            newMember.Size = new Size(75, 23);
            newMember.TabIndex = 8;
            newMember.Text = "회원가입";
            newMember.UseVisualStyleBackColor = true;
            newMember.Click += newMember_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 198);
            Controls.Add(newMember);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lapass);
            Controls.Add(laid);
            Controls.Add(txtpass);
            Controls.Add(txtid);
            Controls.Add(grlog);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grlog.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private TextBox txtpass;
        private Label laid;
        private Label lapass;
        private Button login;
        private Button button2;
        private Button button3;
        private GroupBox grlog;
        private Button newMember;
    }
}