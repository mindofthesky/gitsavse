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
using System.Runtime.InteropServices;
namespace Killer
{
    
    public partial class Form1 : Form
    {
        private string Msg = String.Empty;
        const int WM_COPY = 0x4A;
        public struct COPYDATA {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string IpData;
        }
        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case WM_COPY:
                        COPYDATA cds = (COPYDATA)m.GetLParam(typeof(COPYDATA));
                        if (cds.IpData.Split('$')[0] == "001")
                        {
                            Msg = cds.IpData.Split('$')[1];
                            this.lblMsg.Text = "메세지" + Msg;
                        }

                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            }catch { }
        }

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            VisibleChanged(true, false);
            var tproc = Process.GetProcessesByName("killer");
            if(tproc.Length == 0)
            {
                var proc = new Process();
                proc.StartInfo.FileName = "Kiler.exe";
                proc.Start();

            }
        }

        private void VisibleChanged(bool FormVisible, bool TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nyiTray.Visible = TrayIconVisible;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChanged(false, true);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChanged(true, false);
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void nyiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChanged(true, false);
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            var tproc = Process.GetProcessesByName("Killer");
            if(tproc.Length == 1) 
                tproc[0].Kill();
            this.Dispose();
            Application.Exit();

            
        }
    }
}
