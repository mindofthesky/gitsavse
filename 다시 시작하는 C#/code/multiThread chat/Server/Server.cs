using System;
using System.Collections.Generic;
using ServerData;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using static ServerData.Packet;

namespace Server
{
    internal class Server
    {
        static Socket listenerSocket;
        static List<Clientdata> _client;
        static void Main(string[] args) // 시작 서버단 
        {
            Console.WriteLine("서버 시작 중" + Packet.GetIPAddress());
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _client = new List<Clientdata>();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packet.GetIPAddress()), 4242);

            listenerSocket.Bind(ip);


            Thread listenThread = new Thread(ListenThread);
            listenThread.Start();


           
           

            // 데이터 관리자가 잇음 
        }

        // 리스너가 클라이언트에게 리슨을 연결을 전달
        static void ListenThread()
        { //무한 루프문 
            for (; ; )
            {
                listenerSocket.Listen(0);
                _client.Add(new Clientdata(listenerSocket.Accept()));
            }
        }
       

        // client thread 는 리시브 데이터를 가각 클라이언트에게 제공 
        public static void Data_IN(object cSocket)
        {
            Socket clientSocket = (Socket)cSocket;

            byte[] Buffer;
            int readByte;

            for(; ; )
            {
                Buffer = new byte[clientSocket.SendBufferSize];

                readByte = clientSocket.Receive(Buffer); 

                if (readByte > 0) 
                {//핸들러 데이터
                    Packet packet = new Packet(Buffer);
                    DataManager(packet);
                }
            }
        }
        public static void DataManager(Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.chat:
                    foreach(Clientdata c in _client)
                    {
                        //c.clientSoket.Send()
                    }
                    break;
            }
        }

        class Clientdata
        {
            public Socket clientSoket;
            public Thread clientThread; 
            public string id;

            public Clientdata()
            {
                id = Guid.NewGuid().ToString();
                clientThread = new Thread(Server.Data_IN);
                clientThread.Start();
            }
            public Clientdata(Socket clientSocket)
            {
                this.clientSoket = clientSoket;
                id = Guid.NewGuid().ToString();
                clientThread = new Thread(Server.Data_IN);
                clientThread.Start();
                SendReistrationPacket();
            }
            
            public void SendReistrationPacket()
            {
                Packet p = new Packet(PacketType.Registrations,id);
                p.Gdata.Add(id);
                
               // clientSoket.Send(Convert.Tos(p.ToByte()));

            }
        }
    }
}
