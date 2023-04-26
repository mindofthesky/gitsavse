using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEW_TEXT_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String str = "";
        private bool TextCheck()
        {
            if (this.txtEdit.Text != "") return true;
            else
            {
                MessageBox.Show("목록에 데이터가 없습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus();
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TextCheck() == true)
            {
                this.lblResult.Text = str + this.txtEdit.Text;
                
            }
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true;
                if(TextCheck() == true)
                {
                    this.lblResult.Text = str += this.txtEdit.Text;
                    this.txtEdit.Clear();
                }
            }
        }


    }
}
