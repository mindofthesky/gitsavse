namespace Killer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnoff = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.nyiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmspopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmspopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnoff
            // 
            this.btnoff.Location = new System.Drawing.Point(185, 137);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(75, 23);
            this.btnoff.TabIndex = 0;
            this.btnoff.Text = "button1";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(34, 71);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(38, 12);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "label1";
            // 
            // nyiTray
            // 
            this.nyiTray.Text = "notifyIcon1";
            this.nyiTray.Visible = true;
            this.nyiTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nyiTray_MouseDoubleClick);
            // 
            // cmspopup
            // 
            this.cmspopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기OToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.cmspopup.Name = "설정";
            this.cmspopup.Size = new System.Drawing.Size(118, 48);
            this.cmspopup.Text = "설정";
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.열기OToolStripMenuItem.Text = "열기(O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료XToolStripMenuItem.Text = "종 료(X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 198);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnoff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmspopup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.NotifyIcon nyiTray;
        private System.Windows.Forms.ContextMenuStrip cmspopup;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
    }
}

