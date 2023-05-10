namespace ListViewProcess
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
            this.processview = new System.Windows.Forms.ListView();
            this.chname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chpid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chmemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssprocess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsscpu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssmem = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Kill = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processview
            // 
            this.processview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chname,
            this.chpid,
            this.chtime,
            this.chmemory});
            this.processview.HideSelection = false;
            this.processview.Location = new System.Drawing.Point(2, 1);
            this.processview.Name = "processview";
            this.processview.Size = new System.Drawing.Size(384, 372);
            this.processview.TabIndex = 0;
            this.processview.UseCompatibleStateImageBehavior = false;
            // 
            // chname
            // 
            this.chname.Text = "프로세스 이름";
            // 
            // chpid
            // 
            this.chpid.Text = "PID";
            // 
            // chtime
            // 
            this.chtime.Text = "사용 시간";
            // 
            // chmemory
            // 
            this.chmemory.Text = "메모리 사용량";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssprocess,
            this.tsscpu,
            this.tssmem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssprocess
            // 
            this.tssprocess.Name = "tssprocess";
            this.tssprocess.Size = new System.Drawing.Size(85, 17);
            this.tssprocess.Text = "프로세스 : 0개";
            // 
            // tsscpu
            // 
            this.tsscpu.Name = "tsscpu";
            this.tsscpu.Size = new System.Drawing.Size(86, 17);
            this.tsscpu.Text = "CPU 사용 : 0%";
            // 
            // tssmem
            // 
            this.tssmem.Name = "tssmem";
            this.tssmem.Size = new System.Drawing.Size(99, 17);
            this.tssmem.Text = "실제 메모리 : 0%";
            // 
            // btn_Kill
            // 
            this.btn_Kill.Location = new System.Drawing.Point(281, 379);
            this.btn_Kill.Name = "btn_Kill";
            this.btn_Kill.Size = new System.Drawing.Size(92, 23);
            this.btn_Kill.TabIndex = 2;
            this.btn_Kill.Text = "프로세스 종료";
            this.btn_Kill.UseVisualStyleBackColor = true;
            this.btn_Kill.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 485);
            this.Controls.Add(this.btn_Kill);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.processview);
            this.Name = "Form1";
            this.Text = "프로세스뷰";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView processview;
        private System.Windows.Forms.ColumnHeader chname;
        private System.Windows.Forms.ColumnHeader chpid;
        private System.Windows.Forms.ColumnHeader chtime;
        private System.Windows.Forms.ColumnHeader chmemory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssprocess;
        private System.Windows.Forms.ToolStripStatusLabel tsscpu;
        private System.Windows.Forms.ToolStripStatusLabel tssmem;
        private System.Windows.Forms.Button btn_Kill;
    }
}

