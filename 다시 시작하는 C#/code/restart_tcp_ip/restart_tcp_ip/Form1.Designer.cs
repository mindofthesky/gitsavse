namespace restart_tcp_ip
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
            txt_server_chat = new TextBox();
            txt_server_send = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_server_chat
            // 
            txt_server_chat.Location = new Point(3, 0);
            txt_server_chat.Multiline = true;
            txt_server_chat.Name = "txt_server_chat";
            txt_server_chat.Size = new Size(418, 267);
            txt_server_chat.TabIndex = 0;
            // 
            // txt_server_send
            // 
            txt_server_send.Location = new Point(3, 273);
            txt_server_send.Multiline = true;
            txt_server_send.Name = "txt_server_send";
            txt_server_send.Size = new Size(333, 38);
            txt_server_send.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(346, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 2;
            button1.Text = "send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 317);
            Controls.Add(button1);
            Controls.Add(txt_server_send);
            Controls.Add(txt_server_chat);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_server_chat;
        private TextBox txt_server_send;
        private Button button1;
    }
}