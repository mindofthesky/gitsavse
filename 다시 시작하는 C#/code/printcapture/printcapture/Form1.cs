using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printcapture
{
    public partial class Form1 : Form
    {
        Point orgLocalPoint;
        Size orgLocalSize;
        bool orgBool;
        bool capbool;
        Graphics gs;
        Bitmap Capwin;
        System.Media.SoundPlayer SoundPlayer = new System.Media.SoundPlayer();

        public Form1()
        {   KeyPreview = true;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            if (orgBool == true)
            {
                orgLocalPoint = this.Location;
                orgLocalSize = this.Size;
                
            }
        }


        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'c')
            {
                orgBool = false;
                capbool = true;
                this.Opacity = 0.0;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                var fullSreen = Screen.PrimaryScreen.Bounds;
                Capwin = new Bitmap(fullSreen.Width, fullSreen.Height);
                gs = Graphics.FromImage(Capwin);
                gs.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), fullSreen.Size);
                this.ScreenShot.Image = Capwin;
                //SoundPlayer.SoundLocation = @"..\..\wav\capture.wav";
                SoundPlayer.Play();
                this.Opacity = 10.0;

                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Location = orgLocalPoint;
                this.Size = orgLocalSize;
                orgBool = true;
            }
            else if (e.KeyChar == 'e')
            {
                //SoundPlayer.SoundLocation = @"..\..\wav\capture.wav";
                SoundPlayer.Play();
                capbool = false;
                this.ScreenShot.Image = null;
            }
            else if (e.KeyChar == 's')
            {
                if (capbool == true)
                {
                    using (var Sfile = new SaveFileDialog())
                    {
                        Sfile.OverwritePrompt = true;
                        Sfile.FileName = "화면캡처";
                        Sfile.Filter = "이미지 저장(*.jpg) | *.JPEG";
                        DialogResult rst = Sfile.ShowDialog();
                        if (rst == DialogResult.OK)
                        {
                            Capwin.Save(Sfile.FileName, ImageFormat.Jpeg);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("캡쳐 화면이 ㅇ벗음니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
