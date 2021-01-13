using System;
using System.Net.NetworkInformation;

namespace HToolOne.Global
{
    internal static class Explicit
    {
        private static readonly Random RndRandom = new Random();

        private static int GetNumManual(int min, int max)
        {
            return RndRandom.Next(min, max);
        }

        internal static byte[] GetRndByteArray()
        {
            var byteArrBytes = new byte[GetNumManual(byte.MinValue, byte.MaxValue)];
            RndRandom.NextBytes(byteArrBytes);
            return byteArrBytes;
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

    }
}
