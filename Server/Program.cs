using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {


        static void Main(string[] args)
        {
           TcpListener serverSocket = new TcpListener(IPAddress.Any, 250);
            TcpClient clientSocket = new TcpClient();
            int counter = 0;
            serverSocket.Start();
            Console.WriteLine("Server started on. . . " + serverSocket.LocalEndpoint);
            counter = 0;
            bool timeout = false;

            while (!timeout)
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine(">> Client no " + counter + " :" + clientSocket.Client.AddressFamily);
                HandleClient handle = new HandleClient();
                handle.StartClient(clientSocket, Convert.ToString(counter));
                
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(">>>>>>>>> Server Close <<<<<<<<<<<");
            Console.ReadLine();
        }
    }
}
