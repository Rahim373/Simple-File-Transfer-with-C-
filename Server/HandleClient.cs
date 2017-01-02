using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Utils;

namespace Server
{
    public class HandleClient
    {
        private const string Directory = @"C:\Users\rahim\Desktop\Server";
        TcpClient _clientSocket;
        string _clientNo = "";
        private Thread _clientThread;
        private byte[] _bytesFrom;
        private NetworkStream _networkStream;
        private TcpListener _serverSocket;


        public void StartClient(TcpClient clientSocket, string clientNo)
        {
            this._clientSocket = clientSocket;
            this._clientNo = clientNo;
            _clientThread = new Thread(Handle);
            _clientThread.Start();
            _networkStream = clientSocket.GetStream();
        }

        private void Handle()
        {
            bool fileFlag = false;
            while (true)
            {
                if (!fileFlag)
                {
                    SendFilesTree();
                    fileFlag = true;
                }
                try
                {
                    _bytesFrom = new byte[_clientSocket.ReceiveBufferSize];
                    _networkStream.Read(_bytesFrom, 0, (int)_clientSocket.ReceiveBufferSize);
                    string dataFromClient = Encoding.ASCII.GetString(_bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.Length);
                    CheckFileDownload(dataFromClient);

                }
                catch (Exception e)
                {
                    Console.WriteLine("From Server Catch >>> " + e.Message);
                }
            }
        }

        private void CheckFileDownload(string dataFromClient)
        {
            FileRequest fileRequest = JsonConvert.DeserializeObject<FileRequest>(dataFromClient);
            if (fileRequest != null)
            {
                try
                {
                    byte[] file = File.ReadAllBytes(fileRequest.Path);
                    _bytesFrom = new byte[file.Length];
                    _networkStream.Write(file, 0, file.Length);
                    _networkStream.Flush();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void SendFilesTree()
        {
            string fileTree = GetFilesInfo();

            try
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes(fileTree);
                _networkStream.Write(sendBytes, 0, sendBytes.Length);
                _networkStream.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in the Server: " + e.Message);
            }
        }

        private string GetFilesInfo()
        {
            List<FilesInfo> infos = new List<FilesInfo>();
            string[] files = System.IO.Directory.GetFiles(Directory, "*.*")
                .Select(Path.GetFileName).ToArray();
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(Path.Combine(Directory, file));
                infos.Add(new FilesInfo
                {
                    FileName = fileInfo.Name,
                    AbsolutePath = fileInfo.FullName,
                    Extension = fileInfo.Extension,
                    DateCreated = fileInfo.CreationTimeUtc,
                    Size = fileInfo.Length
                });
            }

            string serializeObject = JsonConvert.SerializeObject(infos);
            return serializeObject;
        }
    }
}
