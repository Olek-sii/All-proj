using System.Net.Sockets;
using System.Threading;

namespace Server
{
	class Client
	{
		private TcpClient _tcpClient;
		private Server _server;
		private NetworkStream _stream;

		public Client(TcpClient tcpClient, Server server)
		{
			_tcpClient = tcpClient;
			_stream = tcpClient.GetStream();
			_server = server;

			Thread thread = new Thread(new ThreadStart(Receive));
			thread.Start();
		}

		public void Send(byte[] data)
		{
			_stream.Write(data, 0, data.Length);
		}

		private void Receive()
		{
			bool isRun = true;
			while (isRun)
			{
				try
				{
					byte[] data = new byte[64];
					int nBytes = _stream.Read(data, 0, data.Length);
					_server.Broadcast(data);
				}
				catch
				{
					isRun = false;
					_stream.Close();
					_tcpClient.Close();
					_server.Close(this);
				}
			}
		}
	}
}
