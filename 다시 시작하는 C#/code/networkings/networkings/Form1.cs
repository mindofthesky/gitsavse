using System.Net.NetworkInformation;
using System.Web;

namespace networkings
{
    public partial class Form1 : Form
    {
        private static Form1 staticForm;
        public string HostNameEntry;
        public string DescriptionEnty;
        public int Hostcount = 0;
        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        string data = "aaaaaaaaaaaaaaaaaaa";
        const int timerout = 120;
        private Thread SoundPlayThread;

        public Form1()
        {
            InitializeComponent();
            staticForm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tslcbtime.Text = "5√ ";
            MainConfig();
        }
        private void MainConfig()
        {
            if(File.Exists("ICMPConfig.ini") == true)
            {
                string ss = string.Empty;
                using (StreamReader sr = new StreamReader("ICMPConfig.ini"))
                {
                    ss = sr.ReadToEnd();
                    while (ss != null)
                    {
                        HostNameEntry = sr.ReadLine();
                        DescriptionEnty = sr.ReadLine();
                        AddList(HostNameEntry, DescriptionEnty);
                        ss = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
        }
        private static void AddList(string AnyHostEmtry, string DescriptionEntry)
        {
            string[] Entry = new string[8];
            int hostcount = 0;
            Entry[0] = AnyHostEmtry;
            Entry[1] = DescriptionEntry;
            int hold = 0;
            ListViewItem Entries = new ListViewItem(Entry);
            staticForm.listBox1.Items.Add(Entries);
            hostcount = hostcount + 1;
            for (int column = 2;  column < 7; column++) 
                if(column < 6)
                    staticForm.listBox1.Items[hostcount - 1].SubItems[column].Text = hold.ToString();
        }
    }
}