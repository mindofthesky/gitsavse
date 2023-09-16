using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServerData;
namespace Client
{
    public class Client
    {
        public static  Socket master;
        public static string name;
        public static string id;
        static void Main(string[] args)
        {

            Console.WriteLine("당신의 이름 : ");
            name = Console.ReadLine();
          A:Console.Clear();
            Console.WriteLine("호스트  ip 주소 : ");
            string ip = Console.ReadLine();

            master = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip),4242);

            try
            {
                master.Connect(ipe);
            }catch (Exception ex) {
                Thread.Sleep(1000);
                goto A; }

            Thread t = new Thread(Data_IN);
            t.Start();

            for(; ; )
            {
                Console.Write("::>");
                string input = Console.ReadLine();

                Packet p = new Packet(Packet.PacketType.chat, id);
                p.Gdata.Add(name);
                p.Gdata.Add(input);
                 master.Send(p.ToBytes());
                

            }
        }

        static void Data_IN()
        {
            byte[] Buffer;
            int readByte;


            for (; ; )
            {
                try
                {
                    Buffer = new byte[master.SendBufferSize];

                    readByte = master.Receive(Buffer);

                    if (readByte > 0)
                    {//핸들러 데이터
                        Packet packet = new Packet(Buffer);
                        DataManager(packet);
                    }
                }
                catch (SocketException ex)
                {

                }
            }    
        }
        public static void DataManager(Packet p)
        {
            switch (p.packetType)
            {
                case Packet.PacketType.Registrations:

                    id = p.senderID;
                    break;
                case Packet.PacketType.chat:
                    Console.WriteLine(p.Gdata[0] + ":" + p.Gdata[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    break;
            }
        }
    }
}
