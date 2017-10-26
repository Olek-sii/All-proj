using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
	class Program
	{
		static void Main(string[] args)
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8888);
			NetworkStream stream = tcpClient.GetStream();
			while (true)
			{
				string message = Console.ReadLine();
				byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
				stream.Write(data, 0, data.Length);
				
				byte[] dataResponce = new byte[64];
				int nBytes = stream.Read(dataResponce, 0, dataResponce.Length);
				Console.WriteLine("Server: {0}", Encoding.UTF8.GetString(dataResponce, 0, nBytes));

				if (message == "exit")
					break;
			}
			stream.Close();
			tcpClient.Close();
		}
	}
}
