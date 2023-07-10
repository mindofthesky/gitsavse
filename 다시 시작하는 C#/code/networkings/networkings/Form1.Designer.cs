namespace networkings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolbar = new ToolStrip();
            tbnaddhost = new ToolStripButton();
            tsbtnstart = new ToolStripButton();
            tsbtnstop = new ToolStripButton();
            tslcbtime = new ToolStripComboBox();
            listBox1 = new ListBox();
            statusStrip1 = new StatusStrip();
            tsslblstatus = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolbar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolbar
            // 
            toolbar.Items.AddRange(new ToolStripItem[] { tbnaddhost, tsbtnstart, tsbtnstop, tslcbtime });
            toolbar.Location = new Point(0, 0);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(780, 25);
            toolbar.TabIndex = 0;
            toolbar.Text = "toolStrip1";
            // 
            // tbnaddhost
            // 
            tbnaddhost.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbnaddhost.Image = (Image)resources.GetObject("tbnaddhost.Image");
            tbnaddhost.ImageTransparentColor = Color.Magenta;
            tbnaddhost.Name = "tbnaddhost";
            tbnaddhost.Size = new Size(23, 22);
            tbnaddhost.Text = "toolStripButton1";
            // 
            // tsbtnstart
            // 
            tsbtnstart.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnstart.Image = (Image)resources.GetObject("tsbtnstart.Image");
            tsbtnstart.ImageTransparentColor = Color.Magenta;
            tsbtnstart.Name = "tsbtnstart";
            tsbtnstart.Size = new Size(23, 22);
            tsbtnstart.Text = "toolStripButton2";
            // 
            // tsbtnstop
            // 
            tsbtnstop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnstop.Image = (Image)resources.GetObject("tsbtnstop.Image");
            tsbtnstop.ImageTransparentColor = Color.Magenta;
            tsbtnstop.Name = "tsbtnstop";
            tsbtnstop.Size = new Size(23, 22);
            tsbtnstop.Text = "toolStripButton3";
            // 
            // tslcbtime
            // 
            tslcbtime.Name = "tslcbtime";
            tslcbtime.Size = new Size(121, 25);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(4, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(773, 319);
            listBox1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslblstatus });
            statusStrip1.Location = new Point(0, 346);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(780, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslblstatus
            // 
            tsslblstatus.Name = "tsslblstatus";
            tsslblstatus.Size = new Size(62, 17);
            tsslblstatus.Text = "상태: 정지";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 368);
            Controls.Add(statusStrip1);
            Controls.Add(listBox1);
            Controls.Add(toolbar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolbar;
        private ToolStripButton tbnaddhost;
        private ToolStripButton tsbtnstart;
        private ToolStripButton tsbtnstop;
        private ToolStripComboBox tslcbtime;
        private ListBox listBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslblstatus;
        private System.Windows.Forms.Timer timer1;
    }
}