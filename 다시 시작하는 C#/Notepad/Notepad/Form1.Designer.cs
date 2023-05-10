namespace Notepad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.찾기FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.tdText = new System.Windows.Forms.FontDialog();
            this.otdfile = new System.Windows.Forms.OpenFileDialog();
            this.stdfile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장AToolStripMenuItem,
            this.끝내기XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.잘라내기TToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.찾기FToolStripMenuItem,
            this.다음찾기NToolStripMenuItem,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // 서식OToolStripMenuItem
            // 
            this.서식OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈WToolStripMenuItem,
            this.글꼴FToolStripMenuItem});
            this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            this.서식OToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.서식OToolStripMenuItem.Text = "서식(O)";
            // 
            // 새로만들기NToolStripMenuItem
            // 
            this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
            this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.새로만들기NToolStripMenuItem.Text = "새로 만들기(N)";
            this.새로만들기NToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.열기OToolStripMenuItem.Text = "열기(O)";
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.저장SToolStripMenuItem.Text = "저장(S)";
            // 
            // 다른이름으로저장AToolStripMenuItem
            // 
            this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
            this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(A)";
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.끝내기XToolStripMenuItem.Text = "끝내기(X)";
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.실행취소UToolStripMenuItem.Text = "실행 취소(U)";
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(T)";
            // 
            // 복사CToolStripMenuItem
            // 
            this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            this.복사CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.복사CToolStripMenuItem.Text = "복사(C)";
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)";
            // 
            // 찾기FToolStripMenuItem
            // 
            this.찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem";
            this.찾기FToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.찾기FToolStripMenuItem.Text = "찾기(F)";
            // 
            // 다음찾기NToolStripMenuItem
            // 
            this.다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem";
            this.다음찾기NToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.다음찾기NToolStripMenuItem.Text = "다음 찾기(N)";
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모두선택AToolStripMenuItem.Text = "모두 선택(A)";
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(D)";
            // 
            // 자동줄바꿈WToolStripMenuItem
            // 
            this.자동줄바꿈WToolStripMenuItem.Name = "자동줄바꿈WToolStripMenuItem";
            this.자동줄바꿈WToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자동줄바꿈WToolStripMenuItem.Text = "자동 줄 바꿈(W)";
            // 
            // 글꼴FToolStripMenuItem
            // 
            this.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem";
            this.글꼴FToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.글꼴FToolStripMenuItem.Text = "글꼴(F)";
            this.글꼴FToolStripMenuItem.Click += new System.EventHandler(this.글꼴FToolStripMenuItem_Click);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(0, 24);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(800, 426);
            this.txtNote.TabIndex = 1;
            // 
            // otdfile
            // 
            this.otdfile.FileName = "openFileDialog1";
            this.otdfile.Filter = "텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // stdfile
            // 
            this.stdfile.Filter = "텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "메모장";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 찾기FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음찾기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.FontDialog tdText;
        private System.Windows.Forms.OpenFileDialog otdfile;
        private System.Windows.Forms.SaveFileDialog stdfile;
    }
}

