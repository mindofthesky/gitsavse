using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.Remoting.Channels;

namespace ScreenProtect
{
    public partial class Form1 : Form
    {
        // 이거 원래 책구문은 이건데 초기로 하면 오류남 그럼 아래꺼 해도 똑같이 작동함 원래 변수는 값을 정확히 주는게 좋지만 이경우에는 안되길래 object 선언하고 
        // 할당해보니 에러는 발생하지 않음 아니근데 왜 아까전엔 안되고 지금은 되는지는 아마 다른 코드작업을 하고있어서 괜찮아보임
        // 애초에 오브젝트는 모든 변수의 상속받은 변수 이기때문에 에러가 발생 할수가 없음은 이미암 
        // 원래는 임시적으로 사용한다면 가능하지만 원래라면 절대 사용해선 안되는 객체임 object 정말 강한 변수이기때문에 
        Rectangle fullScreen = Screen.PrimaryScreen.Bounds;
        //object fullScreen = Screen.PrimaryScreen.Bounds;
        int mXstart = 0;
        int mYstart = 0;
        bool LkTime = true;
        Random r = new Random();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn , IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindwowsHookEx(int hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int CallNextHookEX(int hhk, int nCode, int Wparam, ref KBDLLHOOKSTRUCT IParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        public struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtralnfo;
        }

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_SYSKEYDOWN = 0x0104;
        private const int WM_SYSKEYUP = 0x0105;
        private static LowLevelKeyboardProc _proc = Hookcallback;
        private static int _hookID = 0;
        private int frm2_hookID = 0;

        private static int Hookcallback(int nCode, int wParam, ref KBDLLHOOKSTRUCT Iparam)
        {
            bool bReturn =  false;
            switch (wParam)
            {
                case WM_KEYDOWN:
                case WM_KEYUP:
                case WM_SYSKEYDOWN:
                case WM_SYSKEYUP:
                    bReturn = ((Iparam.vkCode == 0x09) && (Iparam.flags == 0x20)) ||
                              ((Iparam.vkCode == 0x1B) && ((Iparam.flags == 0x20))) ||
                              ((Iparam.vkCode == 0x1B) && ((Iparam.flags == 0x20))) ||
                              ((Iparam.vkCode == 0x5B) && ((Iparam.flags == 0x01))) ||
                              ((Iparam.vkCode == 0x5C) && ((Iparam.flags == 0x01)))||
                              ((Iparam.vkCode == 0x73) && (Iparam.flags == 0x20));
                        
                    break;
            }

            return CallNextHookEX(0, nCode, wParam, ref Iparam);
        }
        //원래 코드는 private 형이지만 참조를 못하기때문에 public으로 변환해야했음 주석 처리한 코드로 한다면 참조를 못해서 에러냄 
        //private delegate int LowLevelKeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT Iparam);
        public delegate int LowLevelKeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT Iparam);

        public void Form1_Lord(object sender , EventArgs e)
        {
            this.timer1.Enabled = true;
            this.locktimer.Enabled = true;
            LkTime = true;
            Cursor.Hide();
            KillCtrAltDelete();
            _hookID = SetHook(_proc);
            frm2_hookID = _hookID;
        }
        public static void KillCtrAltDelete()
        {
            RegistryKey regkey;
            string keyVlaueInt = "1";
            string subkey = "Software\\Microsoft\\Window\\CurrentVersion\\Policies\\System";

            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subkey);
                regkey.SetValue("DisableTaskMgr", keyVlaueInt);
                regkey.Close();
            }catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public static int SetHook(LowLevelKeyboardProc proc)
        {   
            using (Process curProcees = Process.GetCurrentProcess())
            using (ProcessModule curmodule  =curProcees.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curmodule.ModuleName),0);
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int w = r.Next(0, fullScreen.Width -50);
            int h = r.Next(0, fullScreen.Height -50);
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black,10);
            Rectangle retC =  new Rectangle(1 * w, 1 * h,100,100);
            g.DrawArc(p, retC, 0, 365);
        }
        private void LockTime(object sender, EventArgs e)
        {
            LkTime = false;
            this.locktimer.Enabled = false;
        }
        private void Form1_Mouse(object sender, MouseEventArgs e)
        {
            StopScreenSaver();
        }

        public void StopScreenSaver()
        {
            if(LkTime == true)
            {
                Cursor.Show();
                timer1.Enabled = false;
                UnhookWindwowsHookEx(_hookID);
                EnableCtrlAltDel();
                Application.Exit();
            }
            else
            {
                Cursor.Show();
                Form2 frm2 = new Form2();
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    mXstart = 0;
                    mYstart = 0;
                }
            }
        }
        public static void EnableCtrlAltDel()
        {
            try
            {
                string subkey = "Software\\Microsoft\\Window\\CurrentVersion\\Policies\\System";
                RegistryKey rk = Registry.CurrentUser;
                RegistryKey sk1 = rk.OpenSubKey(subkey);
                if (sk1 == null) rk.DeleteValue(subkey, false);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public Form1()
        {
            InitializeComponent();
        }
    }

    
    
    
}
