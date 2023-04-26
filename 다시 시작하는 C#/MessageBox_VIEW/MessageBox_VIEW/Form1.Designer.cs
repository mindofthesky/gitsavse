namespace MessageBox_VIEW
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
            Option1 = new GroupBox();
            Option2 = new GroupBox();
            raOk = new RadioButton();
            raokcancel = new RadioButton();
            raYesNo = new RadioButton();
            raError = new RadioButton();
            rainformation = new RadioButton();
            raQuestion = new RadioButton();
            BtShow = new Button();
            Option1.SuspendLayout();
            Option2.SuspendLayout();
            SuspendLayout();
            // 
            // Option1
            // 
            Option1.Controls.Add(raYesNo);
            Option1.Controls.Add(raokcancel);
            Option1.Controls.Add(raOk);
            Option1.Location = new Point(12, 12);
            Option1.Name = "Option1";
            Option1.Size = new Size(200, 100);
            Option1.TabIndex = 0;
            Option1.TabStop = false;
            Option1.Text = "Type";
            // 
            // Option2
            // 
            Option2.Controls.Add(raQuestion);
            Option2.Controls.Add(rainformation);
            Option2.Controls.Add(raError);
            Option2.Location = new Point(236, 12);
            Option2.Name = "Option2";
            Option2.Size = new Size(200, 100);
            Option2.TabIndex = 1;
            Option2.TabStop = false;
            Option2.Text = "icon";
            // 
            // raOk
            // 
            raOk.AutoSize = true;
            raOk.Location = new Point(15, 22);
            raOk.Name = "raOk";
            raOk.Size = new Size(38, 19);
            raOk.TabIndex = 0;
            raOk.TabStop = true;
            raOk.Text = "ok";
            raOk.UseVisualStyleBackColor = true;
            // 
            // raokcancel
            // 
            raokcancel.AutoSize = true;
            raokcancel.Location = new Point(15, 47);
            raokcancel.Name = "raokcancel";
            raokcancel.Size = new Size(72, 19);
            raokcancel.TabIndex = 1;
            raokcancel.TabStop = true;
            raokcancel.Text = "okcancel";
            raokcancel.UseVisualStyleBackColor = true;
            // 
            // raYesNo
            // 
            raYesNo.AutoSize = true;
            raYesNo.Location = new Point(15, 72);
            raYesNo.Name = "raYesNo";
            raYesNo.Size = new Size(59, 19);
            raYesNo.TabIndex = 2;
            raYesNo.TabStop = true;
            raYesNo.Text = "YesNo";
            raYesNo.UseVisualStyleBackColor = true;
            // 
            // raError
            // 
            raError.AutoSize = true;
            raError.Location = new Point(6, 22);
            raError.Name = "raError";
            raError.Size = new Size(50, 19);
            raError.TabIndex = 0;
            raError.TabStop = true;
            raError.Text = "Error";
            raError.UseVisualStyleBackColor = true;
            // 
            // rainformation
            // 
            rainformation.AutoSize = true;
            rainformation.Location = new Point(6, 47);
            rainformation.Name = "rainformation";
            rainformation.Size = new Size(88, 19);
            rainformation.TabIndex = 1;
            rainformation.TabStop = true;
            rainformation.Text = "Information";
            rainformation.UseVisualStyleBackColor = true;
            // 
            // raQuestion
            // 
            raQuestion.AutoSize = true;
            raQuestion.Location = new Point(6, 72);
            raQuestion.Name = "raQuestion";
            raQuestion.Size = new Size(73, 19);
            raQuestion.TabIndex = 2;
            raQuestion.TabStop = true;
            raQuestion.Text = "Question";
            raQuestion.UseVisualStyleBackColor = true;
            // 
            // BtShow
            // 
            BtShow.ForeColor = SystemColors.ActiveCaptionText;
            BtShow.Location = new Point(439, 120);
            BtShow.Name = "BtShow";
            BtShow.Size = new Size(75, 23);
            BtShow.TabIndex = 3;
            BtShow.Text = "show";
            BtShow.UseVisualStyleBackColor = true;
            BtShow.Click += BtShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 155);
            Controls.Add(BtShow);
            Controls.Add(Option2);
            Controls.Add(Option1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "메세지 박스";
            Option1.ResumeLayout(false);
            Option1.PerformLayout();
            Option2.ResumeLayout(false);
            Option2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Option1;
        private RadioButton raYesNo;
        private RadioButton raokcancel;
        private RadioButton raOk;
        private GroupBox Option2;
        private RadioButton raQuestion;
        private RadioButton rainformation;
        private RadioButton raError;
        private Button BtShow;
    }
}