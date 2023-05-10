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
using System.Threading;
namespace FileView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread threadfileview = null;

        private delegate void OnDelegateFile(string tp, string fn, string fi, string fc);
        private OnDelegateFile OnFile = null;

        bool flag = false;

        int Dircount = 0;
        int Filecount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFile = new OnDelegateFile(OnFile);
        }

        private void FileResult(string fp, string fn, string fi, string fc)
        {
            string fsize = GetFileSize(Convert.ToDouble(fi));
            this.lvfile.Items.Add(new ListViewItem(new string[] {fp,fn,fc,fsize}));
            this.tsslblresult.Text = string.Format("폴더 : {0} 개, 파일 : {1} 개",Dircount,Filecount);
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Byte";
            if (byteCount >= 1073741824.0)
            { 
                size = string.Format("{0:##.##}", byteCount / 1073741824.0) + "GB";
                

            }
            else if(byteCount >= 1048576.0)
            {
                size = string.Format("{0:##.##}", byteCount / 1048576.0) + "MB";
            }
            else if(byteCount >= 1024.0)
            {
                size = string.Format("{0:##.##}", byteCount / 1024.0) + "KB";
            }
            else if (byteCount  > 0 && byteCount < 1024.0) 
            {
                size = byteCount.ToString() + "Byte";
            }
            return size;
            //throw new NotImplementedException();
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            ItemsClear();
            flag = false;
            if(threadfileview != null)
                threadfileview.Abort();
            if(this.txtPath.Text != " ")
            {
                this.lvfile.Items.Clear();
                threadfileview = new Thread(new ParameterizedThreadStart(FileView));
                threadfileview.Start(this.folderBrowserDialog1.SelectedPath);
            }
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            if(this.folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
            { 
            this.txtPath.Text = this.folderBrowserDialog1.SelectedPath;
            threadfileview = new Thread(new ParameterizedThreadStart(FileView));
            threadfileview.Start(this.folderBrowserDialog1.SelectedPath);
            }
        }

        private void FileView(object path)
        {
            Dircount++;
            DirectoryInfo di = new DirectoryInfo((string)path);
            DirectoryInfo[] dti = di.GetDirectories();
            foreach(var f in di.GetFiles())
            {
                if (flag == true)
                {
                    Filecount++;
                    Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(),f.CreationTime.ToString());
                }
                else
                {
                    if (f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString())) ;
                    {
                        Filecount++;
                        Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(), f.CreationTime.ToString());
                    }
                }
            }
            for (int i = 0; i < di.GetFiles().Length; i++)
            {
                try
                {
                    FileView(dti[i].FullName);
                }
                catch
                {
                    continue;
                }
            }

        }

        private void ItemsClear()
        {
            Dircount = 0;
            Filecount   = 0;
            this.lvfile.Items.Clear();
        }
    }
}
