using System;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace UDPWeatherSender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to prepare sending weather data");
            Console.ReadKey();

            Random rvalue = new Random();
            Measurement m;

            UdpClient udpSender = new UdpClient();
            udpSender.EnableBroadcast = true;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 1089);

            Console.WriteLine("Ready to send. Press any key to start");
            Console.ReadKey();

            while (true)
            {
                m = new Measurement(DateTime.Now, "Holbæk", 12.5);

                byte[] sendBytes = Encoding.ASCII.GetBytes(m.ToString());

                try
                {
                    Console.WriteLine("Sending: " + m.ToString());
                    udpSender.Send(sendBytes, sendBytes.Length, endPoint);
                    Thread.Sleep(5000);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }








        }
    }
}
