using System.Net;
using System.Net.Sockets;

namespace restart_tcp_ip
{
    public partial class Form1 : Form
    {
        TcpListener server;
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
        private void Listen()
        {
            AddTextDelegate Addtext = new AddTextDelegate(txt_server_send.AppendText);

            IPAddress addr = IPAddress.Parse("127.0.0.1");
            int port = 8080;
            server = new TcpListener(addr, port);
            server.Start();

            Invoke(Addtext, "connection");

            client = server.AcceptTcpClient();
            connected = true;

            Invoke(Addtext, "connection");

            stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            recevive = new Thread(new ThreadStart(Receive));
            recevive.Start();
        }
        private void Receive()
        {
            AddTextDelegate addText = new AddTextDelegate(txt_server_chat.AppendText);

            while (connected)
            {
                if(stream.CanRead)
                {
                    string receiveChat = reader.ReadLine();
                    if (receiveChat != null && receiveChat.Length > 0) Invoke(addText, "you text");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread listenThread = new Thread(new ThreadStart(Listen));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_server_send.AppendText("³ª:" + txt_server_send.Text);

            writer.WriteLine(txt_server_send.Text);
            writer.Flush();

            txt_server_send.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connected = false;
            if(reader != null) reader.Close();
            if(writer != null) writer.Close();
            if (server != null) server.Stop();
            if(client != null) client.Close();
            if(recevive != null) recevive.Abort();
        }
    }
}