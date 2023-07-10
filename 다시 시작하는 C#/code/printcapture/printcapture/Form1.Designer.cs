namespace printcapture
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
            this.ScreenShot = new System.Windows.Forms.PictureBox();
            this.stateMu = new System.Windows.Forms.StatusStrip();
            this.tsstxt = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShot)).BeginInit();
            this.stateMu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenShot
            // 
            this.ScreenShot.Location = new System.Drawing.Point(12, 12);
            this.ScreenShot.Name = "ScreenShot";
            this.ScreenShot.Size = new System.Drawing.Size(776, 409);
            this.ScreenShot.TabIndex = 0;
            this.ScreenShot.TabStop = false;
            // 
            // stateMu
            // 
            this.stateMu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsstxt});
            this.stateMu.Location = new System.Drawing.Point(0, 428);
            this.stateMu.Name = "stateMu";
            this.stateMu.Size = new System.Drawing.Size(800, 22);
            this.stateMu.TabIndex = 1;
            this.stateMu.Text = "statusStrip1";
            // 
            // tsstxt
            // 
            this.tsstxt.Name = "tsstxt";
            this.tsstxt.Size = new System.Drawing.Size(267, 17);
            this.tsstxt.Text = "전체 화면 캡처: c , 화면지우기 : e , 캡처 저장 : s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stateMu);
            this.Controls.Add(this.ScreenShot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShot)).EndInit();
            this.stateMu.ResumeLayout(false);
            this.stateMu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ScreenShot;
        private System.Windows.Forms.StatusStrip stateMu;
        private System.Windows.Forms.ToolStripStatusLabel tsstxt;
    }
}

