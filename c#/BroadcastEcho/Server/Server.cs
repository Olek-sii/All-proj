using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Server
{
	class Server
	{
		private List<Client> _clients = new List<Client>();
		private TcpListener _tcpListener;

		public Server()
		{
			_tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
			_tcpListener.Start();

			Thread receiveConnectionsThread = new Thread(new ThreadStart(ReceiveConnections));
			receiveConnectionsThread.Start();
		}

		private void ReceiveConnections()
		{
			while (true)
			{
				TcpClient tcpClient = _tcpListener.AcceptTcpClient();
				_clients.Add(new Client(tcpClient, this));
			}
		}

		public void Broadcast(byte[] data)
		{
			foreach (Client client in _clients)
			{
				client.Send(data);
			}
		}

		public void Close(Client client)
		{
			_clients.Remove(client);
		}
	}
}
