using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myphtolo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oselotbtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void hasbtn_Click(object sender, EventArgs e)
        {
            DNFTCG.Form1 form1 = new DNFTCG.Form1();
            form1.ShowDialog();
        }
    }
}
