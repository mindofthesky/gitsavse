namespace tcp_ip
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
            button1 = new Button();
            txt_client_send = new TextBox();
            txt_client_chat = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(345, 285);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 5;
            button1.Text = "send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_client_send
            // 
            txt_client_send.Location = new Point(2, 285);
            txt_client_send.Multiline = true;
            txt_client_send.Name = "txt_client_send";
            txt_client_send.Size = new Size(333, 38);
            txt_client_send.TabIndex = 4;
            // 
            // txt_client_chat
            // 
            txt_client_chat.Location = new Point(2, 12);
            txt_client_chat.Multiline = true;
            txt_client_chat.Name = "txt_client_chat";
            txt_client_chat.Size = new Size(418, 267);
            txt_client_chat.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 330);
            Controls.Add(button1);
            Controls.Add(txt_client_send);
            Controls.Add(txt_client_chat);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_client_send;
        private TextBox txt_client_chat;
    }
}