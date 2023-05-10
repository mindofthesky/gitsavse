using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PreventKiller
{   

    public partial class Form1 : Form
    {
        //데이터값 설정 
       
        public Form1()
        {
            InitializeComponent();
        }
        const int WM_COYDAT = 0x4A;
        //struct 배열 설정을 통해서 값을 구조체로 할당하며 
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string IpData;
        }
        private Thread MsgSendThre = null; //시스템 시간값 전송 값
        private Thread ProcKillChk = null; // 종료방지 체킹
        IntPtr Inthwd;
        //IntPtr C# 포인터 배열 Marshal을 통해 포인터 캐스팅 단 MarshalAs 객체를 먼저 생성하여야 IntPtr 를 생성 가능
        private void From1_Load(object sender, EventArgs e)
        {
            MsgSendThre = new Thread(MsgSendThreRun);
            MsgSendThre.Start();
            ProcKillChk = new Thread(ProcKillChkRun);
            ProcKillChk.Start();

        }
        private void MsgSendThreRun()
        {
            while (true)
            {
                Thread.Sleep(1000);
                var tproc = Process.GetProcessesByName("PreventKilerAgent");
                if (tproc.Length != 0)
                {
                    Inthwd = tproc[0].MainWindowHandle;
                    byte[] buff = System.Text.Encoding.Default.GetBytes("001$" + DateTime.Now.ToString());
                    COPYDATASTRUCT cds = new COPYDATASTRUCT();
                    cds.dwData = IntPtr.Zero;
                    cds.cbData = buff.Length;
                    cds.IpData = "001$" + DateTime.Now.ToString();
                    

                 }
            }
        }
        private void ProcKillChkRun()
        {
            while(true)
            {
                var tproc = Process.GetProcessesByName("PreventKilerAgent");
                if (tproc.Length == 1) continue;
                else
                {
                    var proc = new Process();
                    proc.StartInfo.FileName = "PreventKillAgent";
                    proc.Start();
                }
                Thread.Sleep(1000);
            }
        }

    }
}
