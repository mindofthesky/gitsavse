namespace MenuChoice
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
            cbList = new ComboBox();
            btnadd = new Button();
            txtList = new TextBox();
            lblresult = new Label();
            SuspendLayout();
            // 
            // cbList
            // 
            cbList.FormattingEnabled = true;
            cbList.Location = new Point(12, 12);
            cbList.Name = "cbList";
            cbList.Size = new Size(284, 23);
            cbList.TabIndex = 0;
            cbList.SelectedIndexChanged += cbList_SelectedIndexChanged;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(221, 53);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 1;
            btnadd.Text = "추가";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtList
            // 
            txtList.Location = new Point(12, 53);
            txtList.Name = "txtList";
            txtList.Size = new Size(203, 23);
            txtList.TabIndex = 2;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(12, 101);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(66, 15);
            lblresult.TabIndex = 3;
            lblresult.Text = "카드 선택 :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 159);
            Controls.Add(lblresult);
            Controls.Add(txtList);
            Controls.Add(btnadd);
            Controls.Add(cbList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbList;
        private Button btnadd;
        private TextBox txtList;
        private Label lblresult;
    }
}