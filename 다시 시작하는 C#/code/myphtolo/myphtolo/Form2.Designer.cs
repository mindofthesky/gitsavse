namespace myphtolo
{
    partial class Form2
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
            txtnewid = new TextBox();
            txtnewpwd = new TextBox();
            newok = new Button();
            newid = new Label();
            newpwd = new Label();
            SuspendLayout();
            // 
            // txtnewid
            // 
            txtnewid.Location = new Point(113, 44);
            txtnewid.Name = "txtnewid";
            txtnewid.Size = new Size(100, 23);
            txtnewid.TabIndex = 0;
            // 
            // txtnewpwd
            // 
            txtnewpwd.Location = new Point(113, 98);
            txtnewpwd.Name = "txtnewpwd";
            txtnewpwd.Size = new Size(100, 23);
            txtnewpwd.TabIndex = 1;
            // 
            // newok
            // 
            newok.Location = new Point(125, 149);
            newok.Name = "newok";
            newok.Size = new Size(75, 23);
            newok.TabIndex = 2;
            newok.Text = "확인";
            newok.UseVisualStyleBackColor = true;
            newok.Click += newok_Click;
            // 
            // newid
            // 
            newid.AutoSize = true;
            newid.Location = new Point(53, 52);
            newid.Name = "newid";
            newid.Size = new Size(43, 15);
            newid.TabIndex = 3;
            newid.Text = "아이디";
            // 
            // newpwd
            // 
            newpwd.AutoSize = true;
            newpwd.Location = new Point(53, 101);
            newpwd.Name = "newpwd";
            newpwd.Size = new Size(55, 15);
            newpwd.TabIndex = 4;
            newpwd.Text = "비밀번호";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 187);
            Controls.Add(newpwd);
            Controls.Add(newid);
            Controls.Add(newok);
            Controls.Add(txtnewpwd);
            Controls.Add(txtnewid);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnewid;
        private TextBox txtnewpwd;
        private Button newok;
        private Label newid;
        private Label newpwd;
    }
}