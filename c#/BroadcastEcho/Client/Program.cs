using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client
{
	class Program
	{
		static TcpClient tcpClient;
		static NetworkStream stream;
		static bool _isRun = true;

		static void Main(string[] args)
		{
			tcpClient = new TcpClient();
			tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8888);
			stream = tcpClient.GetStream();

			Thread thread = new Thread(new ThreadStart(ReceiveMessages));
			thread.Start();

			while (_isRun == true)
			{
				try
				{
					string message = Console.ReadLine();
					byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
					stream.Write(data, 0, data.Length);

					if (message == "exit")
						break;
				}
				catch
				{
					_isRun = false;
				}
			}

			thread.Abort();
			stream.Close();
			tcpClient.Close();
		}

		private static void ReceiveMessages()
		{
			while (_isRun == true)
			{
				try
				{
					byte[] dataResponce = new byte[64];
					int nBytes = stream.Read(dataResponce, 0, dataResponce.Length);
					Console.WriteLine("Server: {0}", Encoding.UTF8.GetString(dataResponce, 0, nBytes));
				}
				catch
				{
					_isRun = false;
				}
			}
		}
	}
}
