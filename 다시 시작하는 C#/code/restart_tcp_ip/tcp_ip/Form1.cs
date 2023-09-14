using System.IO;
using System.Net;
using System.Net.Sockets;

namespace tcp_ip
{
    public partial class Form1 : Form
    {

        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;

        Thread recevive;
        bool connected;

        private delegate void AddTextDelegate(string str);
        public Form1()
        {
            InitializeComponent();
        }

        private void Receive()
        {
            AddTextDelegate addText = new AddTextDelegate(txt_client_chat.AppendText);

            while (connected)
            {
                if (stream.CanRead)
                {
                    string receiveChat = reader.ReadLine();
                    if (receiveChat != null && receiveChat.Length > 0) Invoke(addText, "you text" + receiveChat);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_client_send.AppendText("³ª:" + txt_client_send.Text + "\r\n");

            writer.WriteLine(txt_client_send.Text);
            writer.Flush();

            txt_client_send.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            IPAddress addr = IPAddress.Parse("127.0.0.1");
            int port = 8080;

            client = new TcpClient();
            client.Connect(addr, port);

            stream = client.GetStream();
            connected = true;


            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            recevive = new Thread(new ThreadStart(Receive));
            recevive.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connected = false;
            if (reader != null) reader.Close();
            if (writer != null) writer.Close();
            if (client != null) client.Close();
            if (recevive != null) recevive.Abort();
        }
    }

}