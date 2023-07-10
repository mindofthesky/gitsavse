namespace myphtolo
{
    partial class Form4
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
            change_btn = new Button();
            change_pass = new TextBox();
            txtpass_change = new Label();
            SuspendLayout();
            // 
            // change_btn
            // 
            change_btn.Location = new Point(114, 129);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(75, 23);
            change_btn.TabIndex = 0;
            change_btn.Text = "변경하기";
            change_btn.UseVisualStyleBackColor = true;
            change_btn.Click += change_btn_Click;
            // 
            // change_pass
            // 
            change_pass.Location = new Point(104, 58);
            change_pass.Name = "change_pass";
            change_pass.Size = new Size(100, 23);
            change_pass.TabIndex = 1;
            // 
            // txtpass_change
            // 
            txtpass_change.AutoSize = true;
            txtpass_change.Location = new Point(43, 61);
            txtpass_change.Name = "txtpass_change";
            txtpass_change.Size = new Size(55, 15);
            txtpass_change.TabIndex = 2;
            txtpass_change.Text = "비밀번호";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 182);
            Controls.Add(txtpass_change);
            Controls.Add(change_pass);
            Controls.Add(change_btn);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button change_btn;
        private TextBox change_pass;
        private Label txtpass_change;
    }
}