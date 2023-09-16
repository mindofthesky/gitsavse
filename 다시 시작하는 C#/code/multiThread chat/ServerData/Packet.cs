﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ServerData
{
    [Serializable]
    public class Packet
    {
        public List<string> Gdata;
        public int packInt;
        public bool packetBool;
        public string senderID;
        public PacketType packetType;

        public Packet(PacketType type, string senderID)
        {
            Gdata = new List<string>(); 
            this.senderID = senderID;
            this.packetType = type;
        }

        public Packet(byte[] packetbytes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            Packet p = (Packet)bf.Deserialize(ms);
            ms.Close();
            this.Gdata = p.Gdata;
            this.packInt = p.packInt;
            this.packetBool = p.packetBool;
            this.senderID = p.senderID;
            this.packetType = p.packetType;
        }
        public byte ToBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            bf.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Close();

            return bytes[Convert.ToByte(ms.ToArray())];
        }
        public enum PacketType
        {
            Registrations,
            chat
        }
        public static string GetIPAddress()
        {
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress i in ips)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    return i.ToString();
            }

            return "127.0.0.1";
        }
        
    }
}
