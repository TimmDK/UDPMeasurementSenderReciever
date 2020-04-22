using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPWeatherReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpReciever = new UdpClient(1089);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 1089);

            //Waiting
            Console.WriteLine("Waiting for data");
            try
            {
                while (true)
                {
                    byte[] recieveBytes = udpReciever.Receive(ref endPoint);
                    //Now ready for datastream
                    
                    string recievedData = Encoding.ASCII.GetString(recieveBytes);

                    Console.WriteLine("Recieved data: " + recievedData.ToString());
                    Console.WriteLine();
                    Thread.Sleep(5000);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
