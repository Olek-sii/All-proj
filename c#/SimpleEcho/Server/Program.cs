using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
			server.Start();

			TcpClient tcpClient = server.AcceptTcpClient();
			NetworkStream stream = tcpClient.GetStream();
			while (true)
			{
				byte[] data = new byte[64];
				int nBytes = stream.Read(data, 0, data.Length);
				string message = Encoding.UTF8.GetString(data, 0, nBytes);
				stream.Write(data, 0, data.Length);

				if (message == "exit")
					break;
			}
			stream.Close();
			tcpClient.Close();
		}
	}
}
