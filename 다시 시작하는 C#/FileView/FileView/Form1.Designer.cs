namespace FileView
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
            this.lblpath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnhidden = new System.Windows.Forms.RadioButton();
            this.lvfile = new System.Windows.Forms.ListView();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileTimer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblresult = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(9, 16);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(37, 12);
            this.lblpath.TabIndex = 0;
            this.lblpath.Text = "경로 :";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(53, 11);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(585, 21);
            this.txtPath.TabIndex = 1;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(642, 10);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 21);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "경로";
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(11, 42);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(75, 16);
            this.rbtnAll.TabIndex = 3;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "전체 파일";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnhidden
            // 
            this.rbtnhidden.AutoSize = true;
            this.rbtnhidden.Location = new System.Drawing.Point(88, 42);
            this.rbtnhidden.Name = "rbtnhidden";
            this.rbtnhidden.Size = new System.Drawing.Size(75, 16);
            this.rbtnhidden.TabIndex = 4;
            this.rbtnhidden.TabStop = true;
            this.rbtnhidden.Text = "숨김 파일";
            this.rbtnhidden.UseVisualStyleBackColor = true;
            // 
            // lvfile
            // 
            this.lvfile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chFileName,
            this.chFileTimer,
            this.chFileSize});
            this.lvfile.HideSelection = false;
            this.lvfile.Location = new System.Drawing.Point(11, 65);
            this.lvfile.Name = "lvfile";
            this.lvfile.ShowItemToolTips = true;
            this.lvfile.Size = new System.Drawing.Size(627, 241);
            this.lvfile.TabIndex = 5;
            this.lvfile.UseCompatibleStateImageBehavior = false;
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "로경";
            this.chFilePath.Width = 400;
            // 
            // chFileName
            // 
            this.chFileName.Text = "파일 이름";
            this.chFileName.Width = 120;
            // 
            // chFileTimer
            // 
            this.chFileTimer.Text = "수정한 날짜";
            this.chFileTimer.Width = 150;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "파일크기";
            this.chFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chFileSize.Width = 150;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssbar,
            this.tsslblresult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssbar
            // 
            this.ssbar.Name = "ssbar";
            this.ssbar.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslblresult
            // 
            this.tsslblresult.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.tsslblresult.Name = "tsslblresult";
            this.tsslblresult.Size = new System.Drawing.Size(130, 17);
            this.tsslblresult.Text = "폴더 : 0 개, 파일 : 0 개";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvfile);
            this.Controls.Add(this.rbtnhidden);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblpath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnhidden;
        private System.Windows.Forms.ListView lvfile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssbar;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileTimer;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.ToolStripStatusLabel tsslblresult;
    }
}

