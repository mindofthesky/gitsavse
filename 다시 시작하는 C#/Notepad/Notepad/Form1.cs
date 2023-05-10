using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Notepad
{
    
    public partial class Form1 : Form
    {
        private Boolean txtNoteChange;
        private string fWord;
        private Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.txtNoteChange == true)
            {
                var msg = this.Text + "파일의 내용이 변경 되었습니다 저장하시겠습니까?" + "\r\n 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dlr == DialogResult.Yes)
                {
                    textSave();
                    this.txtNote.ResetText();
                    this.Text = "제목없음";
                    this.txtNoteChange = false;
                }
                else if (dlr == DialogResult.No)
                {
                    this.txtNote.ResetText();
                    this.Text = "제목없음";
                    this.txtNoteChange = false;
                }
                else if(dlr == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    this.txtNote.ResetText();
                    this.Text = "제목없음";
                    this.txtNoteChange = false;
                }
                                
            }
            else
            {
                this.txtNote.ResetText() ;
                this.Text = "제목없음";
                this.txtNoteChange = false;
            }
        }
        private void textSave()
        {

        }
        private void textSave()
        {
            if(this.Text == "제목없음")
            {
                
                var dlr = this.stdfile.ShowDialog();
                if(dlr != DialogResult.Cancel)
                {
                    var str = this.stdfile.FileNames;
                    var sw = new StreamWriter(str, false , System.Text.Encoding.Default);
                    sw.Write(this.txtNote.Text);
                    sw.Flush();
                    sw.Close();
                    this.Text = str;
                    this.txtNoteChange =false;
                }
            }
            else
            {
                var strt = this.Text;
                var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                sw.Write(this.txtNote.Text);
                sw.Flush();
                sw.Close();
                this.Text = strt;
                this.txtNoteChange =false;
            }
        }
    }
}
