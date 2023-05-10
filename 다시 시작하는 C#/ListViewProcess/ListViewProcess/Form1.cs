using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.Globalization;

namespace ListViewProcess
{
    public partial class Form1 : Form
    {
        private Thread processthread;
        Thread checkThread = null;

        private delegate void ProcessUpdateDelegate();
        private ProcessUpdateDelegate UpProc = null;

        private delegate void TotalUpdateDelegate(int m , int n);
        private TotalUpdateDelegate ontotal = null;

        private PerformanceCounter oCpu = new PerformanceCounter("processor", "% process Time ", "_Total");
        private PerformanceCounter oMem = new PerformanceCounter("MeMory ", "% Commited Bytes In Use");
        private PerformanceCounter pCPU = new PerformanceCounter();

        bool bExit = false;
        int cp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessView();
        }

        private void ProcessUpdate()
        {
            try
            {
                while (true)
                {
                    var oldlist = new ArrayList();
                    foreach(var oldproc in Process.GetProcesses())
                    {
                        oldlist.Add(oldproc.Id.ToString());
                    }
                    Thread.Sleep(1000);


                    var newproc = Process.GetProcesses();
                    if(oldlist.Count != newproc.Length) 
                    {
                        Invoke(UpProc);
                        continue;
                    }

                    int i = 0;
                    foreach(var rewproc in Process.GetProcesses())
                    {
                        if (oldlist[i++].ToString() != rewproc.Id.ToString())
                        {
                            Invoke(UpProc);
                            break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void ProcessView()
        {
            try
            {
                this.processview.Items.Clear();
                cp =0;
                foreach(var proc in Process.GetProcesses())
                {
                    string[] str;
                    try
                    {
                        str = proc.TotalProcessorTime.ToString().Split(new char[] { '.' });
                    }
                    catch
                    {
                        str = new string[] { "" };
                        var strArray = new string[] { proc.ProcessName.ToString(), proc.Id.ToString(), str[0], NumFormat(proc.WorkingSet64) };
                        var lvt = new ListViewItem(strArray);
                        this.processview.Items.Add(lvt);
                        cp++;
                    }
                }
            }
            catch
            {

            }
            this.tssprocess.Text = "프로세스 : " + cp.ToString() + "개";
        }

        private string NumFormat(long MemNum)
        {
            MemNum = MemNum / 1024;
            return string.Format("{0:N}", MemNum + "KB");
        }

        private void getCPU_info()
        {
            while(!bExit) 
            {
                int icpu = (int)oCpu.NextValue();
                int iMem = (int)oMem.NextValue();
                Invoke(ontotal,icpu, iMem);
                Thread.Sleep(1000);
            }
        }

        private void TotalView(int m, int n) 
        {
            this.tsscpu.Text = "CPU 사용 :" + m.ToString() + "%";
            this.tssmem.Text = "실제 메모리 : " + m.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessKill();
        }
        private void ProcessKill()
        {
            try
            {
                int PID = Convert.ToInt32(this.processview.SelectedItems[0].SubItems[1].Text);
                Process tProcess = Process.GetProcessById(PID);
                if (!(tProcess == null))
                {
                    var dlr = MessageBox.Show(this.processview.SelectedItems[0].SubItems[1].Text + "프로세스를 끝내시겠습니까?", "알림", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (dlr == DialogResult.Yes) 
                    {
                        tProcess.Kill();
                        ProcessView();
                    }
                }
                else
                {
                    MessageBox.Show(this.processview.SelectedItems[0].SubItems[1].Text + "프로세스는 존재하지 않습니다", "알림",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ProcessView();
                }
            }catch 
            {
                return;
            }

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if(!(processthread ==  null)) processthread.Abort();
            if(!(checkThread == null)) checkThread.Abort();

        }
    }
}
