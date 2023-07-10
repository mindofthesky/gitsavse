using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace columheadertest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string curdir = Environment.CurrentDirectory;
            DirectoryInfo dir = new DirectoryInfo(curdir);
            FileInfo[] files = dir.GetFiles();
            
            listView1.BeginUpdate();
            listView1.View = View.Details;
            

            foreach (var fi in files) 
            {
                ListViewItem lvi = new ListViewItem(fi.Name);
                lvi.SubItems.Add(fi.Length.ToString());
                lvi.SubItems.Add(fi.LastWriteTime.ToString());
                lvi.ImageIndex = 0;
            }
            listView1.Columns.Add("파일명", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("사이즈", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("날짜", 150, HorizontalAlignment.Left);
            
            listView1.EndUpdate();
            listView1.Items.Clear();
        }
    }
}
